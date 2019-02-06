using UnityEngine;

public class IControlObject : MonoBehaviour
{
	public int index;
	public int ID;
	public SettingObject SettingObject;
	public SettingDistanceObject settingDistance;
	public string LayerOfPoints;
	public bool noneUI;
	public Point ThisPoint;
	public string nameImagePreview;
	[SerializeField]
	private Transform _thisTransform;
	public Canvas canvasSorting;
}
