using UnityEngine;
using UnityEngine.UI;

public class ManagerHTML : Singleton<ManagerHTML>
{
	public CoherentUIView _view;
	public float zoomPluss;
	public RectTransform center;
	public bool isInitLaunch;
	[SerializeField]
	private Button buttonPrint;
	[SerializeField]
	private IControlObject _currentSelect;
}
