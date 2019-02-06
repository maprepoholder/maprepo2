using System;
using MapzenGo.Models.Enums;
using UnityEngine;

namespace MapzenGo.Models.Settings
{
	[Serializable]
	public class BuildingSettings : BaseSetting
	{
		public BuildingType Type;
		public Material Material;
		public int MinimumBuildingHeight;
		public int MaximumBuildingHeight;
		public bool IsVolumetric;
	}
}
