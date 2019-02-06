using MapzenGo.Models.Settings.Base;
using System.Collections.Generic;

namespace MapzenGo.Models.Settings
{
	public class BuildingFactorySettings : SettingsLayers
	{
		public BuildingSettings DefaultBuilding;
		public List<BuildingSettings> SettingsBuildings;
	}
}
