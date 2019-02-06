using UnityEngine;

public class CoherentUILiveGameView : MonoBehaviour
{
	[SerializeField]
	private string m_LiveName;
	[SerializeField]
	private int m_Width;
	[SerializeField]
	private int m_Height;
	[SerializeField]
	private UnityEngine.Object m_CameraGo;
	[SerializeField]
	private Texture2D m_SourceTexture;
	[SerializeField]
	private bool m_ReadAlpha;
}
