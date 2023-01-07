using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace BunifuAnimatorNS;

[DebuggerStepThrough]
[ProvideProperty("Decoration", typeof(Control))]
public class BunifuTransition : Component, IExtenderProvider
{
	protected class QueueItem
	{
		public Animation animation;

		public Controller controller;

		public Control control;

		[CompilerGenerated]
		private DateTime dateTime_0;

		public AnimateMode mode;

		public Rectangle clipRectangle;

		public bool isActive;

		public DateTime ActivateTime
		{
			[CompilerGenerated]
			get
			{
				return dateTime_0;
			}
			[CompilerGenerated]
			private set
			{
				dateTime_0 = value;
			}
		}

		public bool IsActive
		{
			get
			{
				return isActive;
			}
			set
			{
				if (isActive == value)
				{
					return;
				}
				isActive = value;
				if (value)
				{
					ActivateTime = DateTime.Now;
					return;
				}
				int num = default(int);
				int num2 = default(int);
				while (num == num2)
				{
					num2 = 1;
					int num3 = num;
					num = 1;
					if (1 > num3)
					{
						break;
					}
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class3
	{
		public QueueItem item2;

		public BunifuTransition _003C_003E4__this;

		internal void _003CWork_003Eb__0()
		{
			_003C_003E4__this.method_5(item2);
		}
	}

	[CompilerGenerated]
	private sealed class Class4
	{
		public AnimateMode mode;

		public Control control;

		internal void _003CRepairState_003Eb__0()
		{
			try
			{
				switch (mode)
				{
				case AnimateMode.Hide:
					control.Visible = false;
					break;
				case AnimateMode.Show:
					control.Visible = true;
					break;
				}
			}
			catch
			{
			}
			int num = default(int);
			int num2 = default(int);
			while (num == num2)
			{
				num2 = 1;
				int num3 = num;
				num = 1;
				if (1 > num3)
				{
					break;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class5
	{
		public QueueItem item;

		internal void _003CClearQueue_003Eb__0()
		{
			switch (item.mode)
			{
			case AnimateMode.Hide:
				item.control.Visible = false;
				return;
			case AnimateMode.Show:
				item.control.Visible = true;
				return;
			}
			int num = default(int);
			int num2 = default(int);
			while (num == num2)
			{
				num2 = 1;
				int num3 = num;
				num = 1;
				if (1 > num3)
				{
					break;
				}
			}
		}
	}

	private IContainer icontainer_0;

	protected List<QueueItem> queue = new List<QueueItem>();

	private Thread thread_0;

	private System.Windows.Forms.Timer timer_0;

	[CompilerGenerated]
	private EventHandler<AnimationCompletedEventArg> eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	[CompilerGenerated]
	private EventHandler<TransfromNeededEventArg> eventHandler_2;

	[CompilerGenerated]
	private EventHandler<NonLinearTransfromNeededEventArg> eventHandler_3;

	[CompilerGenerated]
	private EventHandler<MouseEventArgs> eventHandler_4;

	[CompilerGenerated]
	private EventHandler<PaintEventArgs> eventHandler_5;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private Animation animation_0;

	[CompilerGenerated]
	private Cursor cursor_0;

	[CompilerGenerated]
	private int int_1;

	private AnimationType animationType_0;

	private Control control_0;

	private int int_2;

	[CompilerGenerated]
	private float float_0;

	private List<QueueItem> list_0 = new List<QueueItem>();

	private readonly Dictionary<Control, DecorationControl> dictionary_0 = new Dictionary<Control, DecorationControl>();

	[DefaultValue(1500)]
	public int MaxAnimationTime
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public Animation DefaultAnimation
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

	[DefaultValue(typeof(Cursor), "Default")]
	public Cursor Cursor
	{
		[CompilerGenerated]
		get
		{
			return cursor_0;
		}
		[CompilerGenerated]
		set
		{
			cursor_0 = value;
		}
	}

	public bool IsCompleted
	{
		get
		{
			lock (queue)
			{
				return queue.Count == 0;
			}
		}
	}

	[DefaultValue(10)]
	public int Interval
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public AnimationType AnimationType
	{
		get
		{
			return animationType_0;
		}
		set
		{
			animationType_0 = value;
			method_6(animationType_0);
		}
	}

	[DefaultValue(0.02f)]
	public float TimeStep
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
		[CompilerGenerated]
		set
		{
			float_0 = value;
		}
	}

	public event EventHandler<AnimationCompletedEventArg> AnimationCompleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler<AnimationCompletedEventArg> eventHandler = eventHandler_0;
			EventHandler<AnimationCompletedEventArg> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AnimationCompletedEventArg> value2 = (EventHandler<AnimationCompletedEventArg>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<AnimationCompletedEventArg> eventHandler = eventHandler_0;
			EventHandler<AnimationCompletedEventArg> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<AnimationCompletedEventArg> value2 = (EventHandler<AnimationCompletedEventArg>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler AllAnimationsCompleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<TransfromNeededEventArg> TransfromNeeded
	{
		[CompilerGenerated]
		add
		{
			EventHandler<TransfromNeededEventArg> eventHandler = eventHandler_2;
			EventHandler<TransfromNeededEventArg> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TransfromNeededEventArg> value2 = (EventHandler<TransfromNeededEventArg>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<TransfromNeededEventArg> eventHandler = eventHandler_2;
			EventHandler<TransfromNeededEventArg> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TransfromNeededEventArg> value2 = (EventHandler<TransfromNeededEventArg>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<NonLinearTransfromNeededEventArg> NonLinearTransfromNeeded
	{
		[CompilerGenerated]
		add
		{
			EventHandler<NonLinearTransfromNeededEventArg> eventHandler = eventHandler_3;
			EventHandler<NonLinearTransfromNeededEventArg> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NonLinearTransfromNeededEventArg> value2 = (EventHandler<NonLinearTransfromNeededEventArg>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<NonLinearTransfromNeededEventArg> eventHandler = eventHandler_3;
			EventHandler<NonLinearTransfromNeededEventArg> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<NonLinearTransfromNeededEventArg> value2 = (EventHandler<NonLinearTransfromNeededEventArg>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<MouseEventArgs> MouseDown
	{
		[CompilerGenerated]
		add
		{
			EventHandler<MouseEventArgs> eventHandler = eventHandler_4;
			EventHandler<MouseEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<MouseEventArgs> value2 = (EventHandler<MouseEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<MouseEventArgs> eventHandler = eventHandler_4;
			EventHandler<MouseEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<MouseEventArgs> value2 = (EventHandler<MouseEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<PaintEventArgs> FramePainted
	{
		[CompilerGenerated]
		add
		{
			EventHandler<PaintEventArgs> eventHandler = eventHandler_5;
			EventHandler<PaintEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PaintEventArgs> value2 = (EventHandler<PaintEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<PaintEventArgs> eventHandler = eventHandler_5;
			EventHandler<PaintEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<PaintEventArgs> value2 = (EventHandler<PaintEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BunifuTransition()
	{
		Init();
	}

	public BunifuTransition(IContainer container)
	{
		container.Add(this);
		Init();
	}

	protected virtual void Init()
	{
		AnimationType = AnimationType.VertSlide;
		DefaultAnimation = new Animation();
		MaxAnimationTime = 1500;
		TimeStep = 0.02f;
		Interval = 10;
		base.Disposed += BunifuTransition_Disposed;
		timer_0 = new System.Windows.Forms.Timer();
		timer_0.Tick += timer_0_Tick;
		timer_0.Interval = 1;
		timer_0.Start();
	}

	private void method_0()
	{
		thread_0 = new Thread(method_1);
		thread_0.IsBackground = true;
		thread_0.Name = "Animator thread";
		thread_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.Stop();
		control_0 = new Control();
		control_0.CreateControl();
		method_0();
	}

	private void BunifuTransition_Disposed(object sender, EventArgs e)
	{
		ClearQueue();
		if (thread_0 != null)
		{
			thread_0.Abort();
			return;
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	private void method_1()
	{
		while (true)
		{
			Thread.Sleep(Interval);
			try
			{
				int num = 0;
				List<QueueItem> list = new List<QueueItem>();
				List<QueueItem> list2 = new List<QueueItem>();
				lock (queue)
				{
					num = queue.Count;
					bool flag = false;
					foreach (QueueItem item3 in queue)
					{
						if (item3.IsActive)
						{
							flag = true;
						}
						if (item3.controller != null && item3.controller.IsCompleted)
						{
							list.Add(item3);
						}
						else if (item3.IsActive)
						{
							if ((DateTime.Now - item3.ActivateTime).TotalMilliseconds > (double)MaxAnimationTime)
							{
								list.Add(item3);
							}
							else
							{
								list2.Add(item3);
							}
						}
					}
					if (!flag)
					{
						foreach (QueueItem item4 in queue)
						{
							if (!item4.IsActive)
							{
								list2.Add(item4);
								item4.IsActive = true;
								break;
							}
						}
					}
				}
				foreach (QueueItem item5 in list)
				{
					method_7(item5);
				}
				foreach (QueueItem item6 in list2)
				{
					try
					{
						QueueItem item2 = item6;
						control_0.BeginInvoke((MethodInvoker)delegate
						{
							method_5(item2);
						});
					}
					catch
					{
						method_7(item6);
					}
				}
				if (num == 0)
				{
					if (list.Count > 0)
					{
						OnAllAnimationsCompleted();
					}
					method_2();
				}
			}
			catch
			{
			}
		}
	}

	private void method_2()
	{
		List<QueueItem> list = new List<QueueItem>();
		lock (list_0)
		{
			Dictionary<Control, QueueItem> dictionary = new Dictionary<Control, QueueItem>();
			foreach (QueueItem item in list_0)
			{
				if (item.control != null)
				{
					if (dictionary.ContainsKey(item.control))
					{
						list.Add(dictionary[item.control]);
					}
					dictionary[item.control] = item;
				}
				else
				{
					list.Add(item);
				}
			}
			foreach (QueueItem value in dictionary.Values)
			{
				if (value.control != null && !method_3(value.control, value.mode))
				{
					if (control_0 != null)
					{
						method_4(value.control, value.mode);
					}
				}
				else
				{
					list.Add(value);
				}
			}
			foreach (QueueItem item2 in list)
			{
				list_0.Remove(item2);
			}
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	private bool method_3(Control control_1, AnimateMode animateMode_0)
	{
		return animateMode_0 switch
		{
			AnimateMode.Hide => !control_1.Visible, 
			AnimateMode.Show => control_1.Visible, 
			_ => true, 
		};
	}

	private void method_4(Control control_1, AnimateMode animateMode_0)
	{
		control_0.Invoke((MethodInvoker)delegate
		{
			try
			{
				switch (animateMode_0)
				{
				case AnimateMode.Hide:
					control_1.Visible = false;
					break;
				case AnimateMode.Show:
					control_1.Visible = true;
					break;
				}
			}
			catch
			{
			}
			int num = default(int);
			int num2 = default(int);
			while (num == num2)
			{
				num2 = 1;
				int num3 = num;
				num = 1;
				if (1 > num3)
				{
					break;
				}
			}
		});
	}

	private void method_5(QueueItem queueItem_0)
	{
		lock (queueItem_0)
		{
			try
			{
				if (queueItem_0.controller == null)
				{
					queueItem_0.controller = method_8(queueItem_0.control, queueItem_0.mode, queueItem_0.animation, queueItem_0.clipRectangle);
				}
				if (!queueItem_0.controller.IsCompleted)
				{
					queueItem_0.controller.BuildNextFrame();
				}
			}
			catch
			{
				if (queueItem_0.controller != null)
				{
					queueItem_0.controller.Dispose();
				}
				method_7(queueItem_0);
			}
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	private void method_6(AnimationType animationType_1)
	{
		switch (animationType_1)
		{
		case AnimationType.Custom:
		{
			int num = default(int);
			int num2 = default(int);
			while (num == num2)
			{
				num2 = 1;
				int num3 = num;
				num = 1;
				if (1 > num3)
				{
					break;
				}
			}
			break;
		}
		case AnimationType.Rotate:
			DefaultAnimation = Animation.Rotate;
			break;
		case AnimationType.HorizSlide:
			DefaultAnimation = Animation.HorizSlide;
			break;
		case AnimationType.VertSlide:
			DefaultAnimation = Animation.VertSlide;
			break;
		case AnimationType.Scale:
			DefaultAnimation = Animation.Scale;
			break;
		case AnimationType.ScaleAndRotate:
			DefaultAnimation = Animation.ScaleAndRotate;
			break;
		case AnimationType.HorizSlideAndRotate:
			DefaultAnimation = Animation.HorizSlideAndRotate;
			break;
		case AnimationType.ScaleAndHorizSlide:
			DefaultAnimation = Animation.ScaleAndHorizSlide;
			break;
		case AnimationType.Transparent:
			DefaultAnimation = Animation.Transparent;
			break;
		case AnimationType.Leaf:
			DefaultAnimation = Animation.Leaf;
			break;
		case AnimationType.Mosaic:
			DefaultAnimation = Animation.Mosaic;
			break;
		case AnimationType.Particles:
			DefaultAnimation = Animation.Particles;
			break;
		case AnimationType.VertBlind:
			DefaultAnimation = Animation.VertBlind;
			break;
		case AnimationType.HorizBlind:
			DefaultAnimation = Animation.HorizBlind;
			break;
		}
	}

	public void Show(Control control, bool parallel = false, Animation animation = null)
	{
		AddToQueue(control, AnimateMode.Show, parallel, animation);
	}

	public void ShowSync(Control control, bool parallel = false, Animation animation = null)
	{
		Show(control, parallel, animation);
		WaitAnimation(control);
	}

	public void Hide(Control control, bool parallel = false, Animation animation = null)
	{
		AddToQueue(control, AnimateMode.Hide, parallel, animation);
	}

	public void HideSync(Control control, bool parallel = false, Animation animation = null)
	{
		Hide(control, parallel, animation);
		WaitAnimation(control);
	}

	public void BeginUpdate(Control control, bool parallel = false, Animation animation = null, Rectangle clipRectangle = default(Rectangle))
	{
		AddToQueue(control, AnimateMode.BeginUpdate, parallel, animation, clipRectangle);
		bool flag = false;
		do
		{
			flag = false;
			lock (queue)
			{
				foreach (QueueItem item in queue)
				{
					if (item.control == control && item.mode == AnimateMode.BeginUpdate && item.controller == null)
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				Application.DoEvents();
			}
		}
		while (flag);
	}

	public void EndUpdate(Control control)
	{
		lock (queue)
		{
			foreach (QueueItem item in queue)
			{
				if (item.control == control && item.mode == AnimateMode.BeginUpdate)
				{
					item.controller.EndUpdate();
					item.mode = AnimateMode.Update;
				}
			}
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	public void EndUpdateSync(Control control)
	{
		EndUpdate(control);
		WaitAnimation(control);
	}

	public void WaitAllAnimations()
	{
		while (!IsCompleted)
		{
			Application.DoEvents();
		}
	}

	public void WaitAnimation(Control animatedControl)
	{
		while (true)
		{
			bool flag = false;
			lock (queue)
			{
				foreach (QueueItem item in queue)
				{
					if (item.control == animatedControl)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				Application.DoEvents();
				continue;
			}
			break;
		}
	}

	private void method_7(QueueItem queueItem_0)
	{
		if (queueItem_0.controller != null)
		{
			queueItem_0.controller.Dispose();
		}
		lock (queue)
		{
			queue.Remove(queueItem_0);
		}
		OnAnimationCompleted(new AnimationCompletedEventArg
		{
			Animation = queueItem_0.animation,
			Control = queueItem_0.control,
			Mode = queueItem_0.mode
		});
	}

	public void AddToQueue(Control control, AnimateMode mode, bool parallel = true, Animation animation = null, Rectangle clipRectangle = default(Rectangle))
	{
		if (animation == null)
		{
			animation = DefaultAnimation;
		}
		if (control is IFakeControl)
		{
			control.Visible = false;
			return;
		}
		QueueItem item = new QueueItem
		{
			animation = animation,
			control = control,
			IsActive = parallel,
			mode = mode,
			clipRectangle = clipRectangle
		};
		switch (mode)
		{
		case AnimateMode.Hide:
			if (!control.Visible)
			{
				method_7(new QueueItem
				{
					control = control,
					mode = mode
				});
				return;
			}
			break;
		case AnimateMode.Show:
			if (control.Visible)
			{
				method_7(new QueueItem
				{
					control = control,
					mode = mode
				});
				return;
			}
			break;
		}
		lock (queue)
		{
			queue.Add(item);
		}
		lock (list_0)
		{
			list_0.Add(item);
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	private Controller method_8(Control control_1, AnimateMode animateMode_0, Animation animation_1, Rectangle rectangle_0)
	{
		Controller controller = new Controller(control_1, animateMode_0, animation_1, TimeStep, rectangle_0);
		controller.TransfromNeeded += OnTransformNeeded;
		if (eventHandler_3 != null)
		{
			controller.NonLinearTransfromNeeded += OnNonLinearTransfromNeeded;
		}
		controller.MouseDown += OnMouseDown;
		controller.DoubleBitmap.Cursor = Cursor;
		controller.FramePainted += method_9;
		return controller;
	}

	private void method_9(object sender, PaintEventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(sender, e);
			return;
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	protected virtual void OnMouseDown(object sender, MouseEventArgs e)
	{
		try
		{
			Controller controller = (Controller)sender;
			Point location = e.Location;
			location.Offset(controller.DoubleBitmap.Left - controller.AnimatedControl.Left, controller.DoubleBitmap.Top - controller.AnimatedControl.Top);
			if (eventHandler_4 != null)
			{
				eventHandler_4(sender, new MouseEventArgs(e.Button, e.Clicks, location.X, location.Y, e.Delta));
			}
		}
		catch
		{
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	protected virtual void OnNonLinearTransfromNeeded(object sender, NonLinearTransfromNeededEventArg e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
		}
		else
		{
			e.UseDefaultTransform = true;
		}
	}

	protected virtual void OnTransformNeeded(object sender, TransfromNeededEventArg e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, e);
		}
		else
		{
			e.UseDefaultMatrix = true;
		}
	}

	public void ClearQueue()
	{
		List<QueueItem> list = null;
		lock (queue)
		{
			list = new List<QueueItem>(queue);
			queue.Clear();
		}
		foreach (QueueItem item in list)
		{
			if (item.control != null)
			{
				item.control.BeginInvoke((MethodInvoker)delegate
				{
					switch (item.mode)
					{
					case AnimateMode.Hide:
						item.control.Visible = false;
						break;
					default:
					{
						int num4 = default(int);
						int num5 = default(int);
						while (num4 == num5)
						{
							num5 = 1;
							int num6 = num4;
							num4 = 1;
							if (1 > num6)
							{
								break;
							}
						}
						break;
					}
					case AnimateMode.Show:
						item.control.Visible = true;
						break;
					}
				});
			}
			OnAnimationCompleted(new AnimationCompletedEventArg
			{
				Animation = item.animation,
				Control = item.control,
				Mode = item.mode
			});
		}
		if (list.Count > 0)
		{
			OnAllAnimationsCompleted();
			return;
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	protected virtual void OnAnimationCompleted(AnimationCompletedEventArg e)
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, e);
			return;
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	protected virtual void OnAllAnimationsCompleted()
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, EventArgs.Empty);
			return;
		}
		int num = default(int);
		int num2 = default(int);
		while (num == num2)
		{
			num2 = 1;
			int num3 = num;
			num = 1;
			if (1 > num3)
			{
				break;
			}
		}
	}

	public DecorationType GetDecoration(Control control)
	{
		if (dictionary_0.ContainsKey(control))
		{
			return dictionary_0[control].DecorationType;
		}
		return DecorationType.None;
	}

	public void SetDecoration(Control control, DecorationType decoration)
	{
		DecorationControl decorationControl = (dictionary_0.ContainsKey(control) ? dictionary_0[control] : null);
		if (decoration == DecorationType.None)
		{
			decorationControl?.Dispose();
			dictionary_0.Remove(control);
			return;
		}
		if (decorationControl == null)
		{
			decorationControl = new DecorationControl(decoration, control);
		}
		decorationControl.DecorationType = decoration;
		dictionary_0[control] = decorationControl;
	}

	public bool CanExtend(object extendee)
	{
		return extendee is Control;
	}

	private void method_10()
	{
	}
}
