using MapzenGo.Models.Factories;
using UnityEngine;
using MapzenGo.Models.Settings;

namespace MapzenGo.Models
{
	public class PlacesFactory : Factory
	{
		[SerializeField]
		private GameObject _labelPrefab;
		[SerializeField]
		private GameObject _container;
		[SerializeField]
		protected PlacesFactorySettings FactorySettings;
	}
}
