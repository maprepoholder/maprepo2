using UnityEngine.UI;
using UnityEngine;
using RenderHeads.Media.AVProVideo;

public class ControlVideoPlayLan : Singleton<ControlVideoPlayLan>
{
	public Toggle AudioToggle;
	public GameObject PlayIcon;
	public Button buttonClose;
	public RectTransform videoTransform;
	public Image fade;
	public MediaPlayer _mediaPlayer;
	public MediaPlayer _mediaPlayerB;
	public DisplayUGUI _mediaDisplay;
	public TweenAlpha tweenAlpha;
	public Slider _videoSeekSlider;
	public Slider _audioVolumeSlider;
	public MediaPlayer.FileLocation _location;
	[SerializeField]
	private MediaPlayer _loadingPlayer;
}
