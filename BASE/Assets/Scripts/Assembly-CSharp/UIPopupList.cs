using UnityEngine;
using System.Collections.Generic;

public class UIPopupList : UIWidgetContainer
{
	public enum Position
	{
		Auto = 0,
		Above = 1,
		Below = 2,
	}

	public enum Selection
	{
		OnPress = 0,
		OnClick = 1,
	}

	public enum OpenOn
	{
		ClickOrTap = 0,
		RightClick = 1,
		DoubleClick = 2,
		Manual = 3,
	}

	public UIAtlas atlas;
	public UIFont bitmapFont;
	public Font trueTypeFont;
	public int fontSize;
	public FontStyle fontStyle;
	public string backgroundSprite;
	public string highlightSprite;
	public Sprite background2DSprite;
	public Sprite highlight2DSprite;
	public Position position;
	public Selection selection;
	public NGUIText.Alignment alignment;
	public List<string> items;
	public Vector2 padding;
	public Color textColor;
	public Color backgroundColor;
	public Color highlightColor;
	public bool isAnimated;
	public bool isLocalized;
	public UILabel.Modifier textModifier;
	public bool separatePanel;
	public int overlap;
	public OpenOn openOn;
	public List<EventDelegate> onChange;
	[SerializeField]
	protected string mSelectedItem;
	[SerializeField]
	protected UIPanel mPanel;
	[SerializeField]
	protected UIBasicSprite mBackground;
	[SerializeField]
	protected UIBasicSprite mHighlight;
	[SerializeField]
	protected UILabel mHighlightedLabel;
	[SerializeField]
	protected List<UILabel> mLabelList;
	[SerializeField]
	protected float mBgBorder;
	public bool keepValue;
	[SerializeField]
	private GameObject eventReceiver;
	[SerializeField]
	private string functionName;
	[SerializeField]
	private float textScale;
	[SerializeField]
	private UIFont font;
	[SerializeField]
	private UILabel textLabel;
	public GameObject source;
}
