using UnityEngine;

public class UISpriteAnimation : MonoBehaviour
{
	public int frameIndex;
	[SerializeField]
	protected int mFPS;
	[SerializeField]
	protected string mPrefix;
	[SerializeField]
	protected bool mLoop;
	[SerializeField]
	protected bool mSnap;
}
