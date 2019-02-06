using UnityEngine;
using UnityEngine.UI;

public class RootScen : Singleton<RootScen>
{
	public GameObject MessageBox;
	public Text textMessage;
	[SerializeField]
	private ManagerHTML _managerHTML;
	[SerializeField]
	private CoherentUIView _vieweHTML;
	public PointsScriptableObject PontObject;
	public Color colorRailWay;
	public Color colorTrainStation;
	public AudioSource myAudioSource;
	public TPU_DATA TpuData;
}
