using UnityEngine;
using Coherent.UI;

public class CoherentUIMenu : MonoBehaviour
{
	[SerializeField]
	private CoherentUIView View;
	[SerializeField]
	public string MenuID;
	[SerializeField]
	public string ParentID;
	[SerializeField]
	public bool Visible;
	[SerializeField]
	public Button[] Buttons;
}
