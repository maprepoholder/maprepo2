using UnityEngine;

public class UICamera : MonoBehaviour
{
	public enum EventType
	{
		World_3D = 0,
		UI_3D = 1,
		World_2D = 2,
		UI_2D = 3,
	}

	public enum ProcessEventsIn
	{
		Update = 0,
		LateUpdate = 1,
	}

	public EventType eventType;
	public bool eventsGoToColliders;
	public LayerMask eventReceiverMask;
	public ProcessEventsIn processEventsIn;
	public bool debug;
	public bool useMouse;
	public bool useTouch;
	public bool allowMultiTouch;
	public bool useKeyboard;
	public bool useController;
	public bool stickyTooltip;
	public float tooltipDelay;
	public bool longPressTooltip;
	public float mouseDragThreshold;
	public float mouseClickThreshold;
	public float touchDragThreshold;
	public float touchClickThreshold;
	public float rangeDistance;
	public string horizontalAxisName;
	public string verticalAxisName;
	public string horizontalPanAxisName;
	public string verticalPanAxisName;
	public string scrollAxisName;
	public bool commandClick;
	public KeyCode submitKey0;
	public KeyCode submitKey1;
	public KeyCode cancelKey0;
	public KeyCode cancelKey1;
	public bool autoHideCursor;
}
