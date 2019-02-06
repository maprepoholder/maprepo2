using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[System.Serializable]
public struct MeshData
{
    public Material DefailtMateial;
    public MeshRenderer meshRender;
}

public class ChangeMaterial : MonoBehaviour
{

    public Material materialDisable;
    public List<MeshData> listObject;
    void Awake()
    {
        foreach (MeshRenderer meshRenderer in GetComponentsInChildren<MeshRenderer>())   {

            listObject.Add(new MeshData(){DefailtMateial = meshRenderer.sharedMaterial,meshRender = meshRenderer});
        }
    }

    public void ToggleEnble(bool isOn)
    {
        foreach (MeshData meshData in listObject)
        {
            meshData.meshRender.sharedMaterial = isOn ? meshData.DefailtMateial : materialDisable;
            meshData.meshRender.shadowCastingMode = isOn ? ShadowCastingMode.On : ShadowCastingMode.Off;
            var collider = meshData.meshRender.GetComponent<MeshCollider>();
            if (collider) collider.enabled = isOn;
        }
    }
}
