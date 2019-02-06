using UnityEngine;

namespace MapzenGo.Models
{
	public class Building : MonoBehaviour
	{
		public string Id;
		public string Type;
		public string Kind;
		public string Name;
		public bool isParent;
		[SerializeField]
		private string _addr_Street;
		public string LanduseKind;
		public int SortKey;
		public float Height;
		[SerializeField]
		private string _root_id;
	}
}
