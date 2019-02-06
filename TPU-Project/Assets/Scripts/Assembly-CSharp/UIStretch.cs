using UnityEngine;

public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Both = 3,
		BasedOnHeight = 4,
		FillKeepingRatio = 5,
		FitInternalKeepingRatio = 6,
	}

	public Camera uiCamera;
	public GameObject container;
	public Style style;
	public bool runOnlyOnce;
	public Vector2 relativeSize;
	public Vector2 initialSize;
	public Vector2 borderPadding;
	[SerializeField]
	private UIWidget widgetContainer;
}
