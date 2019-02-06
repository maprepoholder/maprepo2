using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class TextureDesc
	{
		[SerializeField]
		private string m_guid;
		[SerializeField]
		private byte[] m_crc;
		[SerializeField]
		private TextureWrapMode m_wrapMode;
		[SerializeField]
		private bool m_linear;
		[SerializeField]
		private int m_width;
		[SerializeField]
		private int m_height;
		[SerializeField]
		private int m_bpp;
		[SerializeField]
		private UVGridType m_gridType;
		[SerializeField]
		private int m_gridWidth;
		[SerializeField]
		private int m_gridHeight;
		[SerializeField]
		private int m_gridTileWidth;
		[SerializeField]
		private int m_gridTileHeight;
		[SerializeField]
		private TextureMetaType m_metaType;
	}
}
