namespace MapzenGo.Models.Plugins
{
	public class TileMap : Plugin
	{
		public enum TileServices
		{
			Default = 0,
			Satellite = 1,
			EsriSatellite = 2,
			Terrain = 3,
			Toner = 4,
			Watercolor = 5,
			Photo = 6,
			MapBox_Satelite = 7,
			MapBoxMy = 8,
			MapBoxMy2 = 9,
			Handdra = 10,
			Transport = 11,
			TransportNEW = 12,
			YandexSatellite = 13,
			TwoGIS = 14,
			DigitalGlobe = 15,
			GoogleSatelite = 16,
		}

		public TileServices TileService;
	}
}
