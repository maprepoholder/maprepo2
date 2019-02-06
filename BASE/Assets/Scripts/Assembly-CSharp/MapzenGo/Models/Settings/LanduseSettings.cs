using System;
using MapzenGo.Models.Enums;
using UnityEngine;

namespace MapzenGo.Models.Settings
{
	[Serializable]
	public class LanduseSettings : BaseSetting
	{
		public LanduseKind Type;
		public Material Material;
	}
}
