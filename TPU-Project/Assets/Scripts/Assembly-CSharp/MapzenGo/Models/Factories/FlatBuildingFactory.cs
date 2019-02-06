using UnityEngine;
using MapzenGo.Models.Settings;

namespace MapzenGo.Models.Factories
{
	public class FlatBuildingFactory : Factory
	{
		[SerializeField]
		private bool _useTriangulationNet;
		[SerializeField]
		protected BuildingFactorySettings FactorySettings;
	}
}
