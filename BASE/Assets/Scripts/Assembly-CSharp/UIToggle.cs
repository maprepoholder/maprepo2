using UnityEngine;
using System.Collections.Generic;

public class UIToggle : UIWidgetContainer
{
	public int group;
	public UIWidget activeSprite;
	public bool invertSpriteState;
	public Animation activeAnimation;
	public Animator animator;
	public UITweener tween;
	public bool startsActive;
	public bool instantTween;
	public bool optionCanBeNone;
	public List<EventDelegate> onChange;
	[SerializeField]
	private UISprite checkSprite;
	[SerializeField]
	private Animation checkAnimation;
	[SerializeField]
	private GameObject eventReceiver;
	[SerializeField]
	private string functionName;
	[SerializeField]
	private bool startsChecked;
}
