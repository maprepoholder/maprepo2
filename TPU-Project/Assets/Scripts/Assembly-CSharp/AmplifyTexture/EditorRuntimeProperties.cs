using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class EditorRuntimeProperties
	{
		public PhysicalCache.Size m_cacheSize;
		public PhysicalCache.Compression m_cacheCompression;
		public int m_pagesPerFrame;
		public int m_streamingThreads;
		public FilterMode m_filter;
		public int m_anisoLevel;
		public PrePassSize m_prePassSize;
		public PrePassFov m_prePassFov;
		public PrePassFarPlane m_prePassFarPlane;
		public DebugDisplay m_debugDisplay;
	}
}
