using System;
using MapzenGo.Models.Enums;
using UnityEngine;

namespace MapzenGo.Models.Settings
{
	[Serializable]
	public class EarthSettings : BaseSetting
	{
		public EarthType Type;
		public Material Material;
	}
}
