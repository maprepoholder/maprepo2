using UnityEngine;

public class CoherentUIView : MonoBehaviour
{
	public enum CoherentViewInputState
	{
		TakeAll = 0,
		TakeNone = 1,
		Transparent = 2,
	}

	public enum DrawOrder
	{
		Normal = 0,
		AfterPostEffects = 1,
	}

	[SerializeField]
	private string m_Page;
	[SerializeField]
	private int m_Width;
	[SerializeField]
	private int m_Height;
	[SerializeField]
	private int m_XPos;
	[SerializeField]
	private int m_YPos;
	[SerializeField]
	private bool m_ScaleToFit;
	[SerializeField]
	private bool m_EnableWebGLSupport;
	[SerializeField]
	private string m_InitialScript;
	[SerializeField]
	private CoherentViewInputState m_ViewInputState;
	[SerializeField]
	private bool m_IsTransparent;
	[SerializeField]
	private bool m_SupportClickThrough;
	[SerializeField]
	private float m_ClickThroughAlphaThreshold;
	[SerializeField]
	private bool m_ClickToFocus;
	[SerializeField]
	private bool m_DisplayVirtualKeyboard;
	[SerializeField]
	private bool m_IsOnDemand;
	[SerializeField]
	private bool m_ControlTimeOnDemand;
	[SerializeField]
	private int m_TargetFramerate;
	[SerializeField]
	private DrawOrder m_DrawAfterPostEffects;
	[SerializeField]
	private bool m_FlipY;
	[SerializeField]
	private CoherentUISystem.CoherentFilteringModes m_Filtering;
	[SerializeField]
	private bool m_ReceivesInput;
	[SerializeField]
	protected CoherentUISystem m_Context;
	[SerializeField]
	private bool m_InterceptAllEvents;
	[SerializeField]
	private bool m_EnableBindingAttribute;
	[SerializeField]
	private bool m_IsIndependentOfZBuffer;
	[SerializeField]
	private bool m_ShowJavaScriptDialogs;
	[SerializeField]
	private bool m_ForceSoftwareRendering;
	[SerializeField]
	private bool m_IgnoreDisplayDensity;
	[SerializeField]
	private bool m_UseCameraDimensions;
	[SerializeField]
	private bool m_CorrectGamma;
	[SerializeField]
	private bool m_EnableIME;
}
