using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[ProvideProperty("BunifuFramework", typeof(Control))]
[DefaultEvent("ValueChanged")]
[DebuggerStepThrough]
public class BunifuTrackbar : UserControl
{
	private int int_0 = 100;

	private int int_1;

	private int int_2;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private int int_3;

	private int int_4;

	private Drag drag_0 = new Drag();

	private IContainer icontainer_0;

	private Panel bg;

	private Panel slider;

	public int Value
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value <= int_0)
			{
				int_2 = value;
				slider.Left = (int_0 - int_1) * int_2 / (base.Width - 15);
			}
			else
			{
				MessageBox.Show("Cannot exceed maximum Value");
			}
		}
	}

	public int BorderRadius
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			Elipse.Apply(bg, int_3);
		}
	}

	public int SliderRadius
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			Elipse.Apply(slider, int_4);
		}
	}

	public int MaximumValue
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			slider.Left = (base.Width - slider.Width) * int_2 / (int_0 - int_1);
		}
	}

	public int MinimumValue
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			slider.Left = (base.Width - slider.Width) * int_2 / (int_0 - int_1);
		}
	}

	public Color IndicatorColor
	{
		get
		{
			return slider.BackColor;
		}
		set
		{
			slider.BackColor = value;
		}
	}

	public Color BackgroudColor
	{
		get
		{
			return bg.BackColor;
		}
		set
		{
			bg.BackColor = value;
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BunifuTrackbar()
	{
		InitializeComponent();
	}

	private void BunifuTrackbar_Load(object sender, EventArgs e)
	{
		BunifuCustomControl.initializeComponent(this);
	}

	private void slider_MouseMove(object sender, MouseEventArgs e)
	{
		int left = slider.Left;
		if (left >= 0 && left + slider.Width <= base.Width)
		{
			drag_0.MoveObject(Horizontal: true, Vertical: false);
			int num = (int_2 = int_0 * slider.Left / (base.Width - slider.Width));
			if (num < 0)
			{
				Value = 0;
			}
			else if (num > int_0)
			{
				Value = MaximumValue;
			}
			if (eventHandler_0 != null)
			{
				eventHandler_0(this, new EventArgs());
				return;
			}
		}
		int num2 = default(int);
		int num3 = default(int);
		while (num2 == num3)
		{
			num3 = 1;
			int num4 = num2;
			num2 = 1;
			if (1 > num4)
			{
				break;
			}
		}
	}

	private void bg_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BunifuTrackbar_Resize(object sender, EventArgs e)
	{
		base.Height = slider.Height + 10;
		bg.Width = base.Width;
		bg.Left = 0;
		Elipse.Apply(bg, int_3);
		Elipse.Apply(slider, int_4);
	}

	private void bg_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int num = e.X;
			if (num > 0 && num + slider.Width < base.Width)
			{
				slider.Left = num;
				Value = int_0 * slider.Left / (base.Width - 15);
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
					return;
				}
			}
		}
		int num2 = default(int);
		int num3 = default(int);
		while (num2 == num3)
		{
			num3 = 1;
			int num4 = num2;
			num2 = 1;
			if (1 > num4)
			{
				break;
			}
		}
	}

	private void slider_MouseUp(object sender, MouseEventArgs e)
	{
		drag_0.Release();
	}

	private void slider_MouseDown(object sender, MouseEventArgs e)
	{
		drag_0.Grab(slider);
	}

	private void bg_MouseMove(object sender, MouseEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.bg = new System.Windows.Forms.Panel();
		this.slider = new System.Windows.Forms.Panel();
		base.SuspendLayout();
		this.bg.BackColor = System.Drawing.Color.DarkGray;
		this.bg.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bg.Location = new System.Drawing.Point(0, 8);
		this.bg.Name = "bg";
		this.bg.Size = new System.Drawing.Size(415, 10);
		this.bg.TabIndex = 0;
		this.bg.Paint += new System.Windows.Forms.PaintEventHandler(bg_Paint);
		this.bg.MouseDown += new System.Windows.Forms.MouseEventHandler(bg_MouseDown);
		this.bg.MouseMove += new System.Windows.Forms.MouseEventHandler(bg_MouseMove);
		this.slider.BackColor = System.Drawing.Color.SeaGreen;
		this.slider.Cursor = System.Windows.Forms.Cursors.Hand;
		this.slider.Location = new System.Drawing.Point(0, 3);
		this.slider.Name = "slider";
		this.slider.Size = new System.Drawing.Size(20, 20);
		this.slider.TabIndex = 1;
		this.slider.MouseDown += new System.Windows.Forms.MouseEventHandler(slider_MouseDown);
		this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(slider_MouseMove);
		this.slider.MouseUp += new System.Windows.Forms.MouseEventHandler(slider_MouseUp);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		base.Controls.Add(this.slider);
		base.Controls.Add(this.bg);
		base.Name = "BunifuTrackbar";
		base.Size = new System.Drawing.Size(415, 28);
		base.Load += new System.EventHandler(BunifuTrackbar_Load);
		base.Resize += new System.EventHandler(BunifuTrackbar_Resize);
		base.ResumeLayout(false);
	}
}
