using System;
using UnityEngine;

public class TweenLetters : UITweener
{
	[Serializable]
	public class AnimationProperties
	{
		public TweenLetters.AnimationLetterOrder animationOrder;
		public float overlap;
		public bool randomDurations;
		public Vector2 randomness;
		public Vector2 offsetRange;
		public Vector3 pos;
		public Vector3 rot;
		public Vector3 scale;
		public float alpha;
	}

	public enum AnimationLetterOrder
	{
		Forward = 0,
		Reverse = 1,
		Random = 2,
	}

	public AnimationProperties hoverOver;
	public AnimationProperties hoverOut;
}
