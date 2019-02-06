using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class PageFile
	{
		[SerializeField]
		private string m_fileName;
		[SerializeField]
		private VirtualTextureBase m_asset;
		[SerializeField]
		private int m_totalPageCount;
		[SerializeField]
		private int m_headerLength;
	}
}
