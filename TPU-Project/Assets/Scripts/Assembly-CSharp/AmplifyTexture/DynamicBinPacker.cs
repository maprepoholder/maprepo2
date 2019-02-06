using System;
using UnityEngine;
using System.Collections.Generic;

namespace AmplifyTexture
{
	[Serializable]
	public class DynamicBinPacker : RectanglePacker
	{
		[Serializable]
		public class Node : Rectangle
		{
			[SerializeField]
			private int m_index;
			[SerializeField]
			private bool m_leaf;
			[SerializeField]
			private string m_key;
			[SerializeField]
			private int m_keyHash;
			[SerializeField]
			private List<int> m_children;
		}

		public enum SplitHeuristic
		{
			VerticalAxis = 0,
			LongestAxis = 1,
		}

		[SerializeField]
		private SplitHeuristic m_splitHeuristic;
		[SerializeField]
		private List<DynamicBinPacker.Node> m_nodeList;
		[SerializeField]
		private Node m_root;
	}
}
