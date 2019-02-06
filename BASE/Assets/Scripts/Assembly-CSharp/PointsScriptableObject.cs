using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class PointsScriptableObject : ScriptableObject
{
	[SerializeField]
	public string LayerOfPoints;
	public string TypePoints;
	public List<SettingObject> ListObject;
	public SettingDistanceObject settingDistance;
	public bool AssetBundleInOneFile;
}
