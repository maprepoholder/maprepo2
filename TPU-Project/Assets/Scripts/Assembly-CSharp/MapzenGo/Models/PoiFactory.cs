using MapzenGo.Models.Factories;
using UnityEngine;
using MapzenGo.Models.Settings;

namespace MapzenGo.Models
{
	public class PoiFactory : Factory
	{
		public Material mat;
		[SerializeField]
		private GameObject _labelPrefab;
		[SerializeField]
		private GameObject _container;
		[SerializeField]
		protected PoiFactorySettings FactorySettings;
	}
}
