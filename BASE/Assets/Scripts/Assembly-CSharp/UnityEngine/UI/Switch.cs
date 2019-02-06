using System;
using UnityEngine.Events;
using UnityEngine;
using Tween;

namespace UnityEngine.UI
{
	public class Switch : Selectable
	{
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}

		public bool isTweening;
		public float TransitionDuration;
		public Color[] m_textColor;
		public Color[] PanelColor;
		public Ease toggleTransition;
		public Image graphic;
		public ToggleEvent onValueChanged;
		[SerializeField]
		private bool m_IsOn;
	}
}
