using UnityEngine;
using AmplifyTexture;

public class AmplifyTextureCameraBase : MonoBehaviour
{
	[SerializeField]
	private PhysicalCache.Size m_cacheSize;
	[SerializeField]
	private PhysicalCache.Compression m_cacheCompression;
	[SerializeField]
	private int m_pagesPerFrame;
	[SerializeField]
	private int m_streamingThreads;
	[SerializeField]
	private FilterMode m_filter;
	[SerializeField]
	private int m_anisoLevel;
	[SerializeField]
	private PrePassSize m_prePassSize;
	[SerializeField]
	private PrePassFov m_prePassFov;
	[SerializeField]
	private PrePassFarPlane m_prePassFarPlane;
	[SerializeField]
	private DebugDisplay m_debugDisplay;
	[SerializeField]
	private PhysicalCache.Size m_backupCacheSize;
	[SerializeField]
	private PhysicalCache.Compression m_backupCacheCompression;
	[SerializeField]
	private int m_cacheWidth;
	[SerializeField]
	private int m_cacheHeight;
	[SerializeField]
	private Camera m_camera;
}
