using UnityEngine;
using System.Collections.Generic;

public class UIColorPicker : MonoBehaviour
{
	public Color value;
	public UIWidget selectionWidget;
	public List<EventDelegate> onChange;
}
