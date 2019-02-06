using System;

namespace AmplifyTexture
{
	[Serializable]
	public class PhysicalCache
	{
		public enum Size
		{
			_32MB_2K = 0,
			_64MB_4K = 1,
			_128MB_4K = 2,
			_256MB_8K = 3,
			_512MB_8K = 4,
			_1024MB_16K = 5,
			_2048MB_16K = 6,
		}

		public enum Compression
		{
			None = 0,
			BlockBased = 1,
		}

	}
}
