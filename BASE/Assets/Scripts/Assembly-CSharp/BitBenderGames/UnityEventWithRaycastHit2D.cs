using System;
using UnityEngine.Events;
using UnityEngine;

namespace BitBenderGames
{
	[Serializable]
	public class UnityEventWithRaycastHit2D : UnityEvent<RaycastHit2D>
	{
	}
}
