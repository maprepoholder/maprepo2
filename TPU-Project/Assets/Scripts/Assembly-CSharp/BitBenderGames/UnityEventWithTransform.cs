using System;
using UnityEngine.Events;
using UnityEngine;

namespace BitBenderGames
{
	[Serializable]
	public class UnityEventWithTransform : UnityEvent<Transform>
	{
	}
}