using System;
using UnityEngine;
using System.Collections.Generic;

namespace AmplifyTexture
{
	[Serializable]
	public class TextureCombo
	{
		[SerializeField]
		private TextureDesc[] m_layers;
		[SerializeField]
		private string m_signature;
		[SerializeField]
		private int m_signatureHash;
		[SerializeField]
		private int m_comboWidth;
		[SerializeField]
		private int m_comboHeight;
		[SerializeField]
		private int m_targetWidth;
		[SerializeField]
		private int m_targetHeight;
		[SerializeField]
		private bool m_tiled;
		public int m_area;
		public int m_largestSize;
		public Rectangle m_packedRect;
		public int m_tileTop;
		public int m_tileBottom;
		public int m_tileLeft;
		public int m_tileRight;
		public int m_numTilesWidth;
		public int m_numTilesHeight;
		public List<string> m_materials;
	}
}
