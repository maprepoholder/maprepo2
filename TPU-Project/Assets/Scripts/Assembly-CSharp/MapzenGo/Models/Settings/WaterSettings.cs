using System;
using MapzenGo.Models.Enums;
using UnityEngine;

namespace MapzenGo.Models.Settings
{
	[Serializable]
	public class WaterSettings : BaseSetting
	{
		public WaterType Type;
		public Material Material;
	}
}
