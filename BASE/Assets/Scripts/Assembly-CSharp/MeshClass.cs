using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

[Serializable]
public struct MeshClass
{
	public List<Material> materials;
	public ArrayList combineInstances;
	public Transform parent;
}
