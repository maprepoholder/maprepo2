using UnityEngine;

public class UIDrawCall : MonoBehaviour
{
	public enum ShadowMode
	{
		None = 0,
		Receive = 1,
		CastAndReceive = 2,
	}

	public enum Clipping
	{
		None = 0,
		TextureMask = 1,
		SoftClip = 3,
		ConstrainButDontClip = 4,
	}

}
