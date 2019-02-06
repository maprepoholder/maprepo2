using System;
using MapzenGo.Models.Enums;
using UnityEngine;

namespace MapzenGo.Models.Settings
{
	[Serializable]
	public class PlaceSettings : BaseSetting
	{
		public PlaceType Type;
		public Color Color;
		public Font Font;
		public int FontSize;
		public Color OutlineColor;
	}
}
