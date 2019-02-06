using System;
using UnityEngine;
using MapzenGo.Models.Enums;

namespace MapzenGo.Models.Settings
{
	[Serializable]
	public class RoadSettings : BaseSetting
	{
		public Material Material;
		public RoadType Type;
		public RailwayType TypeRail;
		public float Width;
		public float Order;
	}
}
