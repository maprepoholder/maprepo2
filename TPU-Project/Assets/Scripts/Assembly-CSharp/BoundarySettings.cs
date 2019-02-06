using System;
using UnityEngine;
using MapzenGo.Models.Enums;

[Serializable]
public class BoundarySettings : BaseSetting
{
	public Material Material;
	public BoundaryType Type;
	public float Width;
}
