using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Rendering;


public class CloneObjectToDummy : MonoBehaviour
{
    public bool makeInstance = true;
    public bool SetupStatic = true;
    public bool CastingShadow = true;
    public GameObject Prefab;
    public GameObject PrefabIco;
    public List<GameObject> PrefabClone;
    public Vector3 AngleRotate;
    

#if UNITY_EDITOR
    public void CloneObject()
    {
        foreach (GameObject obj in PrefabClone)
        {
            Destroy(obj);
        }
        PrefabClone.Clear();

        foreach (Transform o in transform.GetComponentsInChildren<Transform>())
        {
            if (o.name==transform.name) continue;


            var clone = makeInstance?PrefabUtility.InstantiatePrefab(Prefab) as GameObject:Instantiate(Prefab, Vector3.zero, Quaternion.identity, o);

            clone.transform.SetParent(o);
            clone.transform.localPosition = Vector3.zero;
            clone.transform.localScale = Vector3.one;
            
			if(clone.GetComponent<MeshRenderer>()!=null)
			clone.GetComponent<MeshRenderer>().shadowCastingMode =
                CastingShadow ? ShadowCastingMode.On : ShadowCastingMode.Off;

            clone.transform.localEulerAngles = AngleRotate;
            //clone.transform.localEulerAngles = Vector3.zero;

            clone.isStatic = SetupStatic;

            if (PrefabIco!=null)
            {
                var cloneIco = makeInstance ? PrefabUtility.InstantiatePrefab(PrefabIco) as GameObject : Instantiate(PrefabIco, Vector3.zero, Quaternion.identity, o);
                cloneIco.transform.SetParent(o);
                cloneIco.transform.localPosition = Vector3.zero;
                cloneIco.transform.localScale = Vector3.one;
                cloneIco.GetComponent<MeshRenderer>().shadowCastingMode =  ShadowCastingMode.Off;
            }
            PrefabClone.Add(clone);
        }    
    }
    public void DeleteClone()
    {
        foreach (GameObject obj in PrefabClone)
        {
            DestroyImmediate(obj);
        }
        PrefabClone.Clear();
    }
#endif
}

#if UNITY_EDITOR
[CustomEditor(typeof(CloneObjectToDummy))]
public class CloneObjectToDummyEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CloneObjectToDummy myScript = (CloneObjectToDummy)target;
        if (GUILayout.Button("Clone Object"))
        {
            myScript.CloneObject();
        }
        if (myScript.PrefabClone!=null&&myScript.PrefabClone.Count>0&&GUILayout.Button("Delete clone Object"))
        {
            myScript.DeleteClone();
        }
    }
}
#endif


