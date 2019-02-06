using System.Collections.Generic;
using UnityEngine;
using MapzenGo.Models.Plugins;

namespace MapzenGo.Models
{
	public class TileManagerSystem : Singleton<TileManagerSystem>
	{
		public bool EnableCheck;
		public List<Vector2d> tile;
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
		public bool LoadTileAdd;
		[SerializeField]
		protected string _mapzenLayers;
		[SerializeField]
		protected Material MapMaterial;
		[SerializeField]
		private List<Plugin> _plugins;
		public Vector2d CenterTms;
		[SerializeField]
		private Rect _centerCollider;
		[SerializeField]
		private Transform _player;
		[SerializeField]
		private int _removeAfter;
		[SerializeField]
		private bool _keepCentralized;
		public Tile mainTile;
		public TextAsset DataPPT;
	}
}
