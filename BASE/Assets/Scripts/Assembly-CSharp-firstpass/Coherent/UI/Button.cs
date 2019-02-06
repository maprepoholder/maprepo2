using System;

namespace Coherent.UI
{
	[Serializable]
	public class Button
	{
		public string Label;
		public bool Disabled;
		public ButtonHandler Click;
	}
}
