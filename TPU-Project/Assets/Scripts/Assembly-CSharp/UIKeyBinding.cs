using UnityEngine;

public class UIKeyBinding : MonoBehaviour
{
	public enum Modifier
	{
		Any = 0,
		Shift = 1,
		Control = 2,
		Alt = 3,
		None = 4,
	}

	public enum Action
	{
		PressAndClick = 0,
		Select = 1,
		All = 2,
	}

	public KeyCode keyCode;
	public Modifier modifier;
	public Action action;
}
