using UnityEngine;
using System.Collections.Generic;
using MapzenGo.Models.Plugins;

namespace MapzenGo.Models
{
	public class TileManager : MonoBehaviour
	{
		[SerializeField]
		public double Latitude;
		[SerializeField]
		public double Longitude;
		[SerializeField]
		public int RangeXMin;
		[SerializeField]
		public int RangeXMax;
		[SerializeField]
		public int RangeYMin;
		[SerializeField]
		public int RangeYMax;
		[SerializeField]
		public int Zoom;
		[SerializeField]
		public float TileSize;
		[SerializeField]
		protected string _key;
		[SerializeField]
		protected Material MapMaterial;
		[SerializeField]
		private List<Plugin> _plugins;
		public Vector2d CenterTms;
		public Vector2d CenterInMercator;
	}
}
