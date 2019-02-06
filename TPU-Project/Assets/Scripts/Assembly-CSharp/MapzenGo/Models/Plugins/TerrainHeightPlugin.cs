using UnityEngine;

namespace MapzenGo.Models.Plugins
{
	public class TerrainHeightPlugin : Plugin
	{
		public enum TileServices
		{
			Default = 0,
			Satellite = 1,
			Terrain = 2,
			Toner = 3,
			Watercolor = 4,
		}

		public int sampleCount;
		public TileServices TileService;
		[SerializeField]
		protected string _key;
	}
}
