using System;
using UnityEngine.Events;
using UnityEngine;

namespace BitBenderGames
{
	[Serializable]
	public class UnityEventWithPositionAndTransform : UnityEvent<Vector3, Transform>
	{
	}
}
