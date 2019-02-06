using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Category
{
    typeObject,
    Transport,
    TEHNOLOG
}


public class ManagerToggle: MonoBehaviour
{
    List<Toggle> ListObjectSetup = new List<Toggle>();
    List<Toggle> ListObjectSetupTehnol = new List<Toggle>();
    List<Toggle> ListTransportSetup = new List<Toggle>();
    public List<Toggle> ListBorder = new List<Toggle>();
    public GameObject prefabSwith;

    [Space]
    public Toggle SwithBorders;
    public Toggle SwithTypeObject;
    public Toggle SwithTypeObjectTehnolog;
    public Toggle SwithTransport;

    [Space]
    public Transform parentTypeObject, parentTypeObjectTehnol;
    [Space]
    public Transform parentTransport;

    [Space]
    public Toggle TogglePPT;
    public Toggle ToggleGZRO;

    [Space]
    public GameObject LayerPPT;
    public GameObject LayerGZRO;

    [Space]
    public Toggle SwitchPlaneLayer;
    public Toggle SwitchPlaneLayerUndeground;

    [SerializeField]
    private bool _isPlanar;
    public bool IsPlanar
    {
        get { return _isPlanar; }
        set { _isPlanar = value; }
    }

    [SerializeField]
    private bool _isUndeground;
   
    public bool IsUndeground
    {
        get { return _isUndeground; }
        set
        {
            _isUndeground = value;
        }
    }
    public bool AnyTogglesOn(List<Toggle> m_Toggles)
    {

        return m_Toggles.Find((x => x.isOn)) != null;
    }
    void CheckParetnToggle(List<Toggle> toggles, Toggle toggleParent,bool isOn)
    {
        if (isOn)
        {
            if (!toggleParent.isOn) toggleParent.isOn = true;
        }
        else
        {
            if (AnyTogglesOn(toggles)) return;
            toggleParent.isOn = false;
        }
    }



    void CheckChildren(List<Toggle>toggles,bool isOn,string objectName )
    {
        if (isOn && !AnyTogglesOn(toggles))
        {
            foreach (Toggle variable in toggles) variable.isOn = true;
        }

        if (!isOn)
        {
            foreach (Toggle variable in toggles) variable.isOn = false;
        }
    }

    void Start()
    {
       
    }
    void Awake()
    {
        SwithBorders.onValueChanged.AddListener(isOn =>
        {
            CheckChildren(ListBorder,isOn,"BORDER");
        });
        SwithTypeObject.onValueChanged.AddListener(isOn =>
        {
            CheckChildren(ListObjectSetup,isOn, "OBJECT_KOMERCHESKIE");
        });
        SwithTypeObjectTehnolog.onValueChanged.AddListener(isOn =>
        {
            CheckChildren(ListObjectSetupTehnol, isOn, "OBJECT_TEHNOLOG");
        });

        SwithTransport.onValueChanged.AddListener(isOn =>
        {
            CheckChildren(ListTransportSetup, isOn,"TRANSPORT");
        });

        if (TogglePPT && LayerPPT)
        {
            TogglePPT.onValueChanged.AddListener(isOn =>
            {
                LayerPPT.SetActive(isOn);
                CheckParetnToggle(ListBorder, SwithBorders,isOn);
            });
            LayerPPT.SetActive(false);
        }
        else TogglePPT.transform.parent.gameObject.SetActive(false);

        if (ToggleGZRO && LayerGZRO)
        {
            ToggleGZRO.onValueChanged.AddListener(isOn => LayerGZRO.SetActive(isOn));
            ToggleGZRO.onValueChanged.AddListener(isOn =>
            {
                LayerGZRO.SetActive(isOn);
                CheckParetnToggle(ListBorder, SwithBorders, isOn);
            });
            LayerGZRO.SetActive(false);
        }
        else ToggleGZRO.transform.parent.gameObject.SetActive(false);
    }

    public void AddObject(ObjectSetup objectAdd)
    {
        var prefab = Instantiate(prefabSwith);
        var PrefabColor = prefab.GetComponent<SetupColorLegend>();
        PrefabColor.SetupImageColor(objectAdd.ColorLegend);
        Transform _parent = null;
        switch (objectAdd._scenObjectType.CategoryObject)
        {
            case Category.typeObject:
                _parent = parentTypeObject;
                break;
            case Category.TEHNOLOG:
                _parent = parentTypeObjectTehnol;
                break;
            case Category.Transport:
                _parent = parentTransport;
                break;
        }
        prefab.transform.SetParent(_parent, false);
        prefab.gameObject.SetActive(true);
        
//        prefab.transform.SetParent(objectAdd._scenObjectType.CategoryObject == Category.Transport ? parentTransport : parentTypeObject, false);
//        prefab.gameObject.SetActive(true);

        var nameSwith = prefab.GetComponentInChildren<Text>();
        nameSwith.text = objectAdd._scenObjectType.NameLayer;//SettingLayer.LayerNames.ContainsKey(objectAdd.layerObject)? SettingLayer.LayerNames[objectAdd.layerObject]:"None object";

        var prefabSwithNew = prefab.GetComponent<Toggle>();
        prefabSwithNew.name = objectAdd._scenObjectType.NameLayer;
        //
        if (objectAdd._scenObjectType.CategoryObject == Category.Transport)
        {
            ListTransportSetup.Add(prefabSwithNew);
            prefabSwithNew.onValueChanged.AddListener(ison =>
            {
                objectAdd._scenObjectType.MeshShow.SetActive(ison);
                CheckParetnToggle(ListTransportSetup, SwithTransport, ison);
            });
        }
        else if (objectAdd._scenObjectType.CategoryObject == Category.typeObject)
        {
            ListObjectSetup.Add(prefabSwithNew);
            prefabSwithNew.onValueChanged.AddListener(ison =>
            {
                objectAdd._scenObjectType.MeshShow.SetActive(ison);
                CheckParetnToggle(ListObjectSetup, SwithTypeObject, ison);
            });
        }
        else if (objectAdd._scenObjectType.CategoryObject == Category.TEHNOLOG)
        {
            ListObjectSetupTehnol.Add(prefabSwithNew);
            prefabSwithNew.onValueChanged.AddListener(ison =>
            {
                objectAdd._scenObjectType.MeshShow.SetActive(ison);
                CheckParetnToggle(ListObjectSetupTehnol, SwithTypeObjectTehnolog, ison);
            });
        }

        if (objectAdd.ExistPlaneLayer)
        {
            SwitchPlaneLayer.onValueChanged.AddListener(isOn =>
            {
                IsPlanar = isOn;
                objectAdd.ChangeLayerViewType(isOn, IsUndeground);
            });
            SwitchPlaneLayerUndeground.onValueChanged.AddListener(isOn =>
            {
                IsUndeground = isOn;
                objectAdd.ChangeLayerViewType(IsPlanar, isOn);
            });

        }
    }

    
}
