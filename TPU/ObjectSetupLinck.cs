using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSetupLinck : ObjectSetup
{
    public ObjectSetup parent;
    public override void Awake()
    {
        Debug.LogError("Link - " + gameObject.name );
    }

    void Start ()
    {
        if(parent!=null) _scenObjectType = parent._scenObjectType;
    }
}
