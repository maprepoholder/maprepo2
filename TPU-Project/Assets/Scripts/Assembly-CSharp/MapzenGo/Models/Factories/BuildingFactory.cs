using UnityEngine;
using MapzenGo.Models.Settings;

namespace MapzenGo.Models.Factories
{
	public class BuildingFactory : Factory
	{
		[SerializeField]
		private bool _useTriangulationNet;
		[SerializeField]
		protected BuildingFactorySettings FactorySettings;
	}
}
