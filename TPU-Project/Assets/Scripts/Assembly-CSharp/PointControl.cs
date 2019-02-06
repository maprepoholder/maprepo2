using MapzenGo.Models;
using UnityEngine;

public class PointControl : IControlObject
{
	[SerializeField]
	private Tile _parenTile;
	public IUI_Point UIElements;
	[SerializeField]
	private bool _isenable;
	public Vector2d _positionInMap;
}
