using UnityEngine;
using MapzenGo.Models.Enums;

namespace MapzenGo.Models
{
	public class Landuse : MonoBehaviour
	{
		public string Id;
		public string Type;
		public LanduseKind Kind;
		public string Name;
		public int SortKey;
	}
}
