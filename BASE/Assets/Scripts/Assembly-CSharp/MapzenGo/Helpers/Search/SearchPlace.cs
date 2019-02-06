using System;
using UnityEngine;

namespace MapzenGo.Helpers.Search
{
	[Serializable]
	public class SearchPlace : MonoBehaviour
	{
		public string namePlace;
		public string namePlaceСache;
		[SerializeField]
		public StructSearchData DataStructure;
	}
}
