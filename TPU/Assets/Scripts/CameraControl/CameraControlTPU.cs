using System;
using System.Collections;
using System.Collections.Generic;
using TouchScript;
using TouchScript.Gestures;
using TouchScript.Gestures.TransformGestures;
using TouchScript.Layers;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

[Serializable]
public struct MaxMinLocal
{
    public float Min;
    public float Max;
}
public struct MaxMinXY
{
    public float MinX;
    public float MaxX;
    public float MinY;
    public float MaxY;
}

[Serializable]
public struct GestureSettingLocal
{
    public Transform RotationHorisont;

    [HideInInspector]
    public Camera cam;
    [HideInInspector]
    public ScreenTransformGesture Gesture_MoveCamera;
    [HideInInspector]
    public ScreenTransformGesture Gesture_ScaleRotationCamera;
    [HideInInspector]
    public Transform CameraTransform;

    [Range(15, 90)]
    public float StartEngle;
    [Range(30, 2000)]
    public float StartZoom;

    [Range(1, 20)]
    public float SpeedRotate;
}

public class CameraControlTPU : MonoBehaviour
{
    public FollowUI pointTextAligne;

    public GameObject SplashScreen;
    public GameObject ExitScreen;
    //public CanvasGroup cg;
    public Transform pivot;
    public GestureSettingLocal Setting;
    public bool enbleRotateShow;
   // public Material mat;

    
    public MaxMinLocal SetupZoomMaxMin;
    public string NameLayerMask = "Ground";

    [Space]
    public LayerMask layerGround;
    [Space]

    public Collider PlaneZone;
    public bool ShowPoint; 


    MaxMinXY ZoneMove;
    private Vector3 worldStartPoint;
    const float ANGLE_ROTATION = 0.2f;
    private int layer_mask;
    private float Distance {get {return Vector3.Distance(pivot.position, Setting.CameraTransform.position);}}
    private Transform _thisTransform;
    public  Transform ThisTransform {get { return _thisTransform ?? (_thisTransform = transform); }}


    public Animator an;
    [Header("Setting for Demo")]
    public float ZoomTo = 500;

    public float f = 0.5f;
    #region Initialization
    void Awake()
    {
        //if(pointTextAligne==null) pointTextAligne = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        var groundPlane = GameObject.CreatePrimitive(PrimitiveType.Plane).transform;
        groundPlane.SetParent(transform);
        groundPlane.localScale = Vector3.one*500;
        groundPlane.gameObject.layer = LayerMask.NameToLayer(NameLayerMask);
        groundPlane.GetComponent<MeshRenderer>().enabled = false;

        if (PlaneZone==null)
        {
            PlaneZone = GameObject.CreatePrimitive(PrimitiveType.Plane).transform.GetComponent<Collider>();
            PlaneZone.transform.localScale = Vector3.one*100;
            var mr = PlaneZone.GetComponent<MeshRenderer>();
            //mr.material = mat;
            mr.enabled = false;
        }

        Vector3 pt1 = PlaneZone.bounds.center - PlaneZone.bounds.extents;
        Vector3 pt2 = PlaneZone.bounds.center + PlaneZone.bounds.extents;
        ZoneMove.MinX = pt1.x;
        ZoneMove.MinY = pt1.z;
        ZoneMove.MaxX = pt2.x;
        ZoneMove.MaxY = pt2.z;

        layer_mask = LayerMask.GetMask(NameLayerMask);
        pivot = ShowPoint?GameObject.CreatePrimitive(PrimitiveType.Sphere).transform:new GameObject("point").transform;
        pivot.localScale = Vector3.one * 30;

        Setting.Gesture_ScaleRotationCamera = gameObject.AddComponent<ScreenTransformGesture>();
        Setting.Gesture_ScaleRotationCamera.Type = TransformGesture.TransformType.Rotation|TransformGesture.TransformType.Scaling;
        Setting.Gesture_ScaleRotationCamera.MinPointers = 2;
        Setting.Gesture_ScaleRotationCamera.MaxPointers = 10;


        Setting.Gesture_MoveCamera = gameObject.AddComponent<ScreenTransformGesture>();
        Setting.Gesture_MoveCamera.Type = TransformGesture.TransformType.Translation;
        Setting.Gesture_MoveCamera.MinPointers = 0;
        Setting.Gesture_MoveCamera.MaxPointers = 1;

        var Gesture_MoveCamera222 = gameObject.AddComponent<LongPressGesture>();

        Gesture_MoveCamera222.TimeToPress = 0.4f;

        //Gesture_MoveCamera222.OnLongPress.AddListener(PressLong);
        Gesture_MoveCamera222.StateChanged += (sender, args) =>
        {
            switch (args.State)
            {
                case Gesture.GestureState.Ended:
                {
                    RaycastHit hit;
                    if (Physics.Raycast(Setting.cam.ScreenPointToRay(Gesture_MoveCamera222.ScreenPosition), out hit,10000, ~(1 << LayerMask.NameToLayer("Ground"))))
                    {
                            var objectSetup = hit.transform.GetComponent<ObjectSetup>();

                        if(objectSetup) ControlText.Instance.AssigneObject(objectSetup, hit.point);
                            //pointTextAligne.transform.position = hit.point;
                            //pointTextAligne.textMesh.text = objectSetup._scenObjectType.NameLayer;

                            
                    }
                    break;
                }
            }
        };

        Setting.cam = GetComponentInChildren<Camera>();
        Setting.CameraTransform = Setting.cam.transform;
        Setting.CameraTransform.localPosition = Vector3.back * Setting.StartZoom;

        Setting.RotationHorisont.localEulerAngles = Vector3.right * Setting.StartEngle;
     }

    private void PressLong(Gesture arg0)
    {
        Debug.LogError("");
        arg0.SendMessageTarget.SendMessageUpwards("Long");
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1);
        gameObject.AddComponent<FullscreenLayer>();
        if (useGUILayout) SplashScreen.SetActive(false);
    }

    private void OnEnable()
    {
        Setting.Gesture_MoveCamera.StateChanged += MoveHandler;
        Setting.Gesture_ScaleRotationCamera.StateChanged += RotationScaleHandler;
    }
    private void OnDisable()
    {
        Setting.Gesture_MoveCamera.StateChanged -= MoveHandler;
        Setting.Gesture_ScaleRotationCamera.StateChanged -= RotationScaleHandler;
    }

    public bool rightclicked, middleclicked;
    public float distance = 5.0f;
    public float xSpeed = 125.0f;
    private float x = 0.0f;
    private Vector3 startPosition;


    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    public LayerMask CamOcclusion;
    void occludeRay(/*ref Vector3 targetFollow*/)
    {
        return;
        Ray ray = Setting.cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            print("I'm looking at " + hit.transform.name);
        else
            print("I'm looking at nothing!");
    
        return;
    #region prevent wall clipping
    //declare a new raycast hit.
    RaycastHit wallHit = new RaycastHit();
        //linecast from your player (targetFollow) to your cameras mask (camMask) to find collisions.
      //  Ray d= new Ray(Setting.CameraTransform.position, Setting.CameraTransform.localPosition.normalized);
        Debug.DrawRay(Setting.CameraTransform.position, Setting.CameraTransform.forward,Color.magenta,100,true);

        if (Physics.Raycast(Setting.CameraTransform.position, Setting.CameraTransform.forward, out wallHit, 1000,CamOcclusion))
        {
            Debug.LogError("!!!!!!!!!!!!!!!");
            Debug.LogError(wallHit.collider.gameObject.name);
            //the smooth is increased so you detect geometry collisions faster.
            /*smooth = 10f;
            //the x and z coordinates are pushed away from the wall by hit.normal.
            //the y coordinate stays the same.
            camPosition = new Vector3(wallHit.point.x + wallHit.normal.x * 0.5f, camPosition.y, wallHit.point.z + wallHit.normal.z * 0.5f);*/
        }
        #endregion
    }

    public void LateUpdate()
    {
       // occludeRay();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            rightclicked = true;
            startPosition = Input.mousePosition;
            yaw = ThisTransform.localEulerAngles.y;
            pitch = Setting.RotationHorisont.localEulerAngles.x;
        }

        if (Input.GetMouseButtonUp(1)) rightclicked = false;

        if (rightclicked)
        {
            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            
            ThisTransform.localEulerAngles = new Vector3(0.0f, yaw, 0.0f);
            Setting.RotationHorisont.localEulerAngles = new Vector3(Mathf.Clamp(pitch, 35, 90), 0, 0);
            return;
        }

        if (Input.mouseScrollDelta.magnitude>0)
        {
            Zoom(1+Input.mouseScrollDelta.y * 0.1f);
        }
        //rightclicked = Input.GetMouseButtonDown(1) || Input.GetMouseButton(1) || Input.GetMouseButtonUp(1);
    }

#endregion

    #region Rotate Horizontal
    public void RotateHorisontalEvent(bool direction)
    {
        enableHorizontRotate = true;
        StartCoroutine(RotateHorisontalCour(direction));
    }

    public bool enableHorizontRotate { set; get; }

    private IEnumerator RotateHorisontalCour(bool direction)
    {
        while (enableHorizontRotate)
        {
            yield return null;
            Setting.RotationHorisont.localEulerAngles = new Vector3(Mathf.Clamp(Setting.RotationHorisont.localEulerAngles.x + (direction ? -1 * f : 1 * f), 35, 90), 0, 0);
        }
    }
    #endregion

    #region Rotate Vertical
    public void RotateVerticalEvent(bool direction)
    {
        enableVerticalRotate = true;
        StartCoroutine(RotateVerticalCour(direction));
    }

    public bool enableVerticalRotate { set; get; }

    private IEnumerator RotateVerticalCour(bool direction)
    {
        while (enableVerticalRotate)
        {
            yield return null;
            ThisTransform.localEulerAngles = (ThisTransform.localEulerAngles + Vector3.up * (direction ? -1f*f : 1f*f));
        }
    }





    #endregion

    #region DEMO ZOOM

    private bool ZoomCameraPosition(float DeltaScale, float zoomToDemo, bool dir)
    {
        var positionlocal = (-Vector3.forward * (1 - DeltaScale) * Distance);
        Setting.CameraTransform.localPosition = dir
            ? (Setting.CameraTransform.localPosition + positionlocal).clampVectorZ(SetupZoomMaxMin.Min, -zoomToDemo)
            : (Setting.CameraTransform.localPosition + positionlocal).clampVectorZ(-zoomToDemo, SetupZoomMaxMin.Max);
        return Math.Abs(-Setting.CameraTransform.localPosition.z - zoomToDemo) < 0.1f;
    }

    #endregion

    #region Zoom


    public void ZoomEvent(bool direction)
    {
        enableZoom = true;
        StartCoroutine(ZoomCour(direction));
    }

    public bool enableZoom { set; get; }

    private IEnumerator ZoomCour(bool direction)
    {
        while (enableZoom)
        {
            yield return null;
            Zoom(!direction ? 0.99f : 1.01f);
        }
    }
    #endregion

    public void Exit(bool ok)
    {
        if (!ok)
        {
            ExitScreen.SetActive(true);
            return;
        }
        Debug.LogException(new Exception("QUIT"));
        Application.Quit();
    }

    #region Handler TouchScript
    private void RotationScaleHandler(object sender, EventArgs e)
    {
       /* if (rightclicked)
        {
            Debug.LogError("MouseMove");
            return;
        }*/

        switch (Setting.Gesture_ScaleRotationCamera.State)
        {
            case Gesture.GestureState.Began:
            case Gesture.GestureState.Possible:
                GestureBegin(Setting.Gesture_ScaleRotationCamera.ScreenPosition);
                break;
            case Gesture.GestureState.Changed:
                GestureChanged_ScaleRoatation();
                break;
            case Gesture.GestureState.Ended:
            case Gesture.GestureState.Cancelled:
            case Gesture.GestureState.Failed:
                break;
        }
    }
    private void MoveHandler(object sender, EventArgs e)
    {
        //Debug.LogError("MoveHandler");
        if (Input.GetMouseButton(1)|| Input.GetMouseButtonDown(1)|| Input.GetMouseButtonUp(1))
        {
            return;
        }

        switch (Setting.Gesture_MoveCamera.State)
        {
            case Gesture.GestureState.Possible:
            case Gesture.GestureState.Began:
               // GraphicRaycasterс.enabled = false;
                pivot.position = worldStartPoint = getWorldPoint(Setting.Gesture_MoveCamera.ScreenPosition);
                break;
            case Gesture.GestureState.Changed:
                //cg.interactable = false;
                GestureChanged_Move();
                break;
            case Gesture.GestureState.Ended:
            case Gesture.GestureState.Cancelled:
            case Gesture.GestureState.Failed:
               // GraphicRaycasterс.enabled = true;
                break;
                
        }
    }
    #endregion


    private void GestureBegin(Vector3 ScreenPosition)
    {
        pivot.position = worldStartPoint = getWorldPoint(ScreenPosition);
    }

    public void GestureChanged_Move()
    {
        if (enableZoom||enableHorizontRotate||enableVerticalRotate) return;

        Vector3 worldDelta = getWorldPoint(Setting.Gesture_MoveCamera.ScreenPosition) - worldStartPoint;
        Move(-worldDelta);
    }

    public void GestureChanged_ScaleRoatation()
    {
        /*if(!enbleRotateShow) ThisTransform.localEulerAngles = (ThisTransform.localEulerAngles + Vector3.up* Setting.Gesture_ScaleRotationCamera.DeltaRotation);

        if (Mathf.Abs(Setting.Gesture_ScaleRotationCamera.DeltaScale) > ANGLE_ROTATION* 0.8f && Mathf.Abs(Setting.Gesture_ScaleRotationCamera.DeltaScale) < 1.1f / *&& (Setting.CameraTransform.localPosition.z < zoomMaxMin.Min || Setting.CameraTransform.localPosition.z > zoomMaxMin.Max)* /)
        {
            ZoomCameraPosition(Setting.Gesture_ScaleRotationCamera.DeltaScale);
        }*/
        if(!enbleRotateShow) ThisTransform.localEulerAngles = (ThisTransform.localEulerAngles + Vector3.up * Setting.Gesture_ScaleRotationCamera.DeltaRotation);
        if (Mathf.Abs(Setting.Gesture_ScaleRotationCamera.DeltaScale) > ANGLE_ROTATION * 0.8f /*&& (Setting.CameraTransform.localPosition.z < zoomMaxMin.Min || Setting.CameraTransform.localPosition.z > zoomMaxMin.Max)*/)
        {
            Zoom(Setting.Gesture_ScaleRotationCamera.DeltaScale);
            /*Setting.CameraTransform.localPosition =
                (Setting.CameraTransform.localPosition +
                 (-Vector3.forward * (1 - Setting.Gesture_ScaleRotationCamera.DeltaScale) *
                 Distance)).clampVectorZ(SetupZoomMaxMin.Min, SetupZoomMaxMin.Max);

            */
            if (Mathf.Abs(Setting.CameraTransform.localPosition.z - SetupZoomMaxMin.Min) < 0.5f ||
                Mathf.Abs(Setting.CameraTransform.localPosition.z - SetupZoomMaxMin.Max) < 0.5f) return;

            Vector3 worldDelta = Vector3.Distance(ThisTransform.position, pivot.position) * (ThisTransform.position - pivot.position).normalized * (1 - Setting.Gesture_ScaleRotationCamera.DeltaScale);
            Move(worldDelta);
        }

    }

    public void Zoom(float DeltaScale)
    {
        //Debug.LogError(DeltaScale);
        Setting.CameraTransform.localPosition =
                (Setting.CameraTransform.localPosition +
                 (-Vector3.forward * (1 - /*Setting.Gesture_ScaleRotationCamera.*/DeltaScale) *
                 Distance)).clampVectorZ(SetupZoomMaxMin.Min, SetupZoomMaxMin.Max);
    }

    public void Move(Vector3 position)
    {
        if (ThisTransform.position.x + position.x< ZoneMove.MinX|| ThisTransform.position.z + position.z < ZoneMove.MinY) return;
        if (ThisTransform.position.x + position.x > ZoneMove.MaxX || ThisTransform.position.z + position.z > ZoneMove.MaxY) return;

        ThisTransform.Translate(position.x, 0, position.z, Space.World);
    }


    
    [ContextMenu("Test zoom to Demo")]
    public void StartDemoShow(bool DemoMode)
    {
        Debug.LogError(DemoMode);

        
        if (DemoMode)
        {
            an.enabled = true;
            an.Play("Rotate360UI");
        }
        else an.enabled = false;

        enbleRotateShow = DemoMode;
        if (DemoMode) StartCoroutine(ZoomToDemo());
    }

    private IEnumerator ZoomToDemo()
    {
        bool direction = (Mathf.Abs(Setting.CameraTransform.localPosition.z) > ZoomTo);
        while (!ZoomCameraPosition(direction ? 1.01f : 0.99f, ZoomTo, direction))
        {
            yield return null;
            Debug.LogError("ZOOM");
        }

        while (enbleRotateShow)
        {
           
            yield return null;
            transform.Rotate(Vector3.down, Setting.SpeedRotate * Time.deltaTime, Space.World);
        }
    }


    private Vector3 getWorldPoint(Vector2 screenPoint)
    {
        RaycastHit hit;
        Physics.Raycast(Setting.cam.ScreenPointToRay(screenPoint), out hit, 10000, layer_mask);
        return hit.point;
    }
}


