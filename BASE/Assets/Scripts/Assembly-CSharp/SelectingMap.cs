using UnityEngine;

public class SelectingMap : Singleton<SelectingMap>
{
	public MeshRenderer MapTileRenderer;
	public Material SatelliteMap;
	public Material StreetMap;
	public MapSelected currentMap;
}
