using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	public int frameIndex;
	[SerializeField]
	protected int framerate;
	public bool ignoreTimeScale;
	public bool loop;
	public Sprite[] frames;
}
