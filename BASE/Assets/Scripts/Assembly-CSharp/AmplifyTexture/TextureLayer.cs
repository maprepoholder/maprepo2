using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class TextureLayer
	{
		public TextureLayerType m_type;
		public string m_propertyName;
		public Color m_defaultValue;
		public CompressionType m_rgbCompType;
		public CompressionType m_alphaCompType;
		public int m_rgbQuality;
		public int m_alphaQuality;
	}
}
