using System;
using UnityEngine;

namespace MapzenGo.Helpers.Search
{
	[Serializable]
	public class SearchData
	{
		[SerializeField]
		public string label;
		[SerializeField]
		public Vector2 coordinates;
	}
}
