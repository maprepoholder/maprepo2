using UnityEngine;

public class UILabel : UIWidget
{
	public enum Crispness
	{
		Never = 0,
		OnDesktop = 1,
		Always = 2,
	}

	public enum Effect
	{
		None = 0,
		Shadow = 1,
		Outline = 2,
		Outline8 = 3,
	}

	public enum Overflow
	{
		ShrinkContent = 0,
		ClampContent = 1,
		ResizeFreely = 2,
		ResizeHeight = 3,
	}

	public enum Modifier
	{
		None = 0,
		ToUppercase = 1,
		ToLowercase = 2,
		Custom = 255,
	}

	public Crispness keepCrispWhenShrunk;
	[SerializeField]
	private Font mTrueTypeFont;
	[SerializeField]
	private UIFont mFont;
	[SerializeField]
	private string mText;
	[SerializeField]
	private int mFontSize;
	[SerializeField]
	private FontStyle mFontStyle;
	[SerializeField]
	private NGUIText.Alignment mAlignment;
	[SerializeField]
	private bool mEncoding;
	[SerializeField]
	private int mMaxLineCount;
	[SerializeField]
	private Effect mEffectStyle;
	[SerializeField]
	private Color mEffectColor;
	[SerializeField]
	private NGUIText.SymbolStyle mSymbols;
	[SerializeField]
	private Vector2 mEffectDistance;
	[SerializeField]
	private Overflow mOverflow;
	[SerializeField]
	private bool mApplyGradient;
	[SerializeField]
	private Color mGradientTop;
	[SerializeField]
	private Color mGradientBottom;
	[SerializeField]
	private int mSpacingX;
	[SerializeField]
	private int mSpacingY;
	[SerializeField]
	private bool mUseFloatSpacing;
	[SerializeField]
	private float mFloatSpacingX;
	[SerializeField]
	private float mFloatSpacingY;
	[SerializeField]
	private bool mOverflowEllipsis;
	[SerializeField]
	private int mOverflowWidth;
	[SerializeField]
	private Modifier mModifier;
	[SerializeField]
	private bool mShrinkToFit;
	[SerializeField]
	private int mMaxLineWidth;
	[SerializeField]
	private int mMaxLineHeight;
	[SerializeField]
	private float mLineWidth;
	[SerializeField]
	private bool mMultiline;
}
