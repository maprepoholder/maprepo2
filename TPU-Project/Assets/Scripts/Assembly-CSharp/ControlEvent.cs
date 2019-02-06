using UnityEngine;

public class ControlEvent : Singleton<ControlEvent>
{
	public GameObject ScreenLoad;
	public GameObject ScreenLoadApp;
	[SerializeField]
	private Camera _camera;
	[SerializeField]
	private float _distanceToGround;
}
