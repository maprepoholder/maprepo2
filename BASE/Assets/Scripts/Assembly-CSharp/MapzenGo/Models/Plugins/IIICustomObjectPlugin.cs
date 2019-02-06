using UnityEngine;
using System.Collections.Generic;
using MapzenGo.Models;

namespace MapzenGo.Models.Plugins
{
	public class IIICustomObjectPlugin : MonoBehaviour
	{
		public GameObject clone;
		public double Lan;
		public double Longi;
		public double LanRevers;
		public double LongiRevers;
		public List<GameObject> objectsInstance;
		public TileManagerSystem tm;
		public List<Vector2d> _customObjectsPosition;
	}
}
