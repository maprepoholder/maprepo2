using UnityEngine;

public class CoherentUISystem : MonoBehaviour
{
	public enum CoherentFilteringModes
	{
		PointFiltering = 1,
		LinearFiltering = 2,
	}

	[SerializeField]
	private bool m_EnableProxy;
	[SerializeField]
	private bool m_AllowCookies;
	[SerializeField]
	private string m_CookiesResource;
	[SerializeField]
	private string m_CachePath;
	[SerializeField]
	private string m_HTML5LocalStoragePath;
	[SerializeField]
	private bool m_ForceDisablePluginFullscreen;
	[SerializeField]
	private bool m_DisableWebSecurity;
	[SerializeField]
	private int m_DebuggerPort;
	public Camera m_MainCamera;
	public bool DeviceSupportsSharedTextures;
	[SerializeField]
	private bool m_UseURLCache;
	[SerializeField]
	private int m_MemoryCacheSize;
	[SerializeField]
	private int m_DiskCacheSize;
}
