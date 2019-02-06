namespace MapzenGo.Models.Plugins
{
	public class MapImagePlugin : Plugin
	{
		public enum TileServices
		{
			Default = 0,
			Satellite = 1,
			Terrain = 2,
			Toner = 3,
			Watercolor = 4,
			Photo = 5,
			MapBox_Satelite = 6,
			MapBoxMy = 7,
			MapBoxMy2 = 8,
			Handdra = 9,
		}

		public string userStyle;
		public string token;
		public TileServices TileService;
	}
}
