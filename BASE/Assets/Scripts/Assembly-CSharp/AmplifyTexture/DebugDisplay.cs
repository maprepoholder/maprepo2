using System;

namespace AmplifyTexture
{
	[Serializable]
	public struct DebugDisplay
	{
		public bool cache;
		public int cacheSize;
		public bool table;
		public int tableSize;
		public bool prePass;
		public int prePassSize;
	}
}
