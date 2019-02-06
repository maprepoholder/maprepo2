using System;
using Assets.MapzenGo.Models.Enums;
using UnityEngine;

namespace MapzenGo.Models.Settings
{
	[Serializable]
	public class PoiSettings : BaseSetting
	{
		public PoiType Type;
		public Sprite Sprite;
	}
}
