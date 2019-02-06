using System;
using UnityEngine;

namespace UniRx
{
	[Serializable]
	public class ReactiveProperty<T>
	{
		[SerializeField]
		private T value;
	}
}
