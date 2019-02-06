using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class TexturePacker
	{
		[SerializeField]
		private VirtualTextureBase m_asset;
		[SerializeField]
		private DynamicBinPacker m_rectPacker;
	}
}
