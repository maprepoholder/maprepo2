using UnityEngine;
using System.Collections.Generic;
using MapzenGo.Helpers.VectorD;

namespace MapzenGo.Models
{
	public class Tile : MonoBehaviour
	{
		public List<IControlObject> ObjectInTile;
		public TileMap TileMap;
		public GameObject BuildingTile;
		[SerializeField]
		public RectD Rect;
		public float checkeDistance;
	}
}
