using System;
using UnityEngine;

namespace MapzenGo.Models
{
	[Serializable]
	public struct TileMap
	{
		public Tile thisTile;
		public GameObject MapTileGameObject;
		[SerializeField]
		private Transform _mapTileTransform;
		[SerializeField]
		private Renderer _mapTileRenderer;
		[SerializeField]
		private Material _mapTileMaterial;
		public bool isShow;
	}
}
