using UnityEngine;

public class UI2DSprite : UIBasicSprite
{
	[SerializeField]
	private Sprite mSprite;
	[SerializeField]
	private Shader mShader;
	[SerializeField]
	private Vector4 mBorder;
	[SerializeField]
	private bool mFixedAspect;
	[SerializeField]
	private float mPixelSize;
	public Sprite nextSprite;
}
