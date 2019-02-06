using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Collections;



public class ToggleEvents : MonoBehaviour
{
	public UnityEvent		_OnEvents;
	public UnityEvent		_OffEvents;



	public void OnToggle(bool isOn)
	{
		if (isOn)
			_OnEvents.Invoke();
		else
			_OffEvents.Invoke();

		OnToggleInt(isOn);
	}


	protected virtual void OnToggleInt(bool isOn) {}
}
