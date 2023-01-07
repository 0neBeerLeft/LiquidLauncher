using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BunifuAnimatorNS;

public class AnimationCompletedEventArg : EventArgs
{
	[CompilerGenerated]
	private Animation animation_0;

	[CompilerGenerated]
	private Control control_0;

	[CompilerGenerated]
	private AnimateMode animateMode_0;

	public Animation Animation
	{
		[CompilerGenerated]
		get
		{
			return animation_0;
		}
		[CompilerGenerated]
		set
		{
			animation_0 = value;
		}
	}

	public Control Control
	{
		[CompilerGenerated]
		get
		{
			return control_0;
		}
		[CompilerGenerated]
		internal set
		{
			control_0 = value;
		}
	}

	public AnimateMode Mode
	{
		[CompilerGenerated]
		get
		{
			return animateMode_0;
		}
		[CompilerGenerated]
		internal set
		{
			animateMode_0 = value;
		}
	}
}
