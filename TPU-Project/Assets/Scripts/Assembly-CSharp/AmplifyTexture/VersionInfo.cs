using System;
using UnityEngine;

namespace AmplifyTexture
{
	[Serializable]
	public class VersionInfo
	{
		[SerializeField]
		private int m_major;
		[SerializeField]
		private int m_minor;
		[SerializeField]
		private int m_release;
	}
}
