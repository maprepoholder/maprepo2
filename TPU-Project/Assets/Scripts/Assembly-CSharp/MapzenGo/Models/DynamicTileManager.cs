using UnityEngine;

namespace MapzenGo.Models
{
	public class DynamicTileManager : TileManager
	{
		[SerializeField]
		private Rect _centerCollider;
		[SerializeField]
		private Transform _player;
		[SerializeField]
		private int _removeAfter;
		[SerializeField]
		private bool _keepCentralized;
	}
}
