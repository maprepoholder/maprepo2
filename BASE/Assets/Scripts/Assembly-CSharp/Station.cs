using System;

[Serializable]
public class Station : Point
{
	public Models ModelsStation;
	public Railway RailWayStation;
	public DataStation DataStation;
	public bool onlyGeometry;
}
