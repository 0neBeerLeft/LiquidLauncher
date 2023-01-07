using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DefaultEvent("RangeChanged")]
[DebuggerStepThrough]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuRange : UserControl
{
	private int int_0 = 100;

	private int int_1;

	private int int_2;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	[CompilerGenerated]
	private EventHandler eventHandler_2;

	private int int_3;

	private IContainer icontainer_0;

	private Panel bg;

	private Panel slider;

	private Panel slider2;

	private Panel FILL;

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
			Elipse.Apply(slider, int_3);
			Elipse.Apply(slider2, int_3);
		}
	}

	public int RangeMax
	{
		get
		{
			return int_2;
		}
		set
		{
			int left = slider2.Left;
			if (value <= int_0)
			{
				int_2 = value;
				slider2.Left = (base.Width - 15) * int_2 / int_0;
				if (slider2.Left < slider.Left)
				{
					slider2.Left = left;
					throw new Exception("Minium Value Reached");
				}
				FILL.Left = slider.Left + slider.Width / 2;
				FILL.Width = slider2.Left + slider2.Width / 2 - FILL.Left;
				return;
			}
			throw new Exception("Maximum Value Reached");
		}
	}

	public int RangeMin
	{
		get
		{
			return int_1;
		}
		set
		{
			int left = slider.Left;
			if (value <= int_0)
			{
				int_1 = value;
				slider.Left = (base.Width - 15) * int_1 / int_0;
				if (slider.Left > slider2.Left)
				{
					slider.Left = left;
					throw new Exception("Minium Value Reached");
				}
				FILL.Left = slider.Left + slider.Width / 2;
				FILL.Width = slider2.Left + slider2.Width / 2 - FILL.Left;
				return;
			}
			throw new Exception("Minium Value Reached");
		}
	}

	public int MaximumRange
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			RangeMax = int_0 * slider2.Left / (base.Width - 15);
			RangeMin = int_0 * slider.Left / (base.Width - 15);
			FILL.Left = slider.Left + slider.Width / 2;
			FILL.Width = slider2.Left + slider2.Width / 2 - FILL.Left;
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
			Panel panel = slider;
			Panel fILL = FILL;
			Color color2 = (slider2.BackColor = value);
			Color backColor = (fILL.BackColor = color2);
			panel.BackColor = backColor;
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

	public event EventHandler RangeChanged
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

	public event EventHandler RangeMaxChanged
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

	public event EventHandler RangeMinChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BunifuRange()
	{
		InitializeComponent();
		RangeMax = int_0 * slider2.Left / (base.Width - 15);
		RangeMin = int_0 * slider.Left / (base.Width - 15);
		FILL.Left = slider.Left + slider.Width / 2;
		FILL.Width = slider2.Left + slider2.Width / 2 - FILL.Left;
		BunifuCustomControl.initializeComponent(this);
	}

	private void BunifuRange_Load(object sender, EventArgs e)
	{
		if (base.DesignMode)
		{
			BunifuCustomControl.initializeComponent(this);
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

	private void slider_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int num = e.X + slider.Left;
			if (num < slider2.Left && num > 0 && num + slider.Width < base.Width)
			{
				slider.Left = num;
				FILL.Left = slider.Left + slider.Width / 2;
				FILL.Width = slider2.Left + slider2.Width / 2 - FILL.Left;
				RangeMin = int_0 * slider.Left / (base.Width - 15);
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				if (eventHandler_2 != null)
				{
					eventHandler_2(this, new EventArgs());
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

	private void slider2_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			int num = e.X + slider2.Left;
			if (num > slider.Left && num + slider2.Width < base.Width)
			{
				slider2.Left = num;
				FILL.Left = slider.Left + slider.Width / 2;
				FILL.Width = slider2.Left + slider2.Width / 2 - FILL.Left;
				RangeMax = int_0 * slider2.Left / (base.Width - 15);
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
				if (eventHandler_1 != null)
				{
					eventHandler_1(this, new EventArgs());
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

	private void bg_Paint(object sender, PaintEventArgs e)
	{
	}

	private void BunifuRange_Resize(object sender, EventArgs e)
	{
		base.Height = slider.Height + 10;
		bg.Width = base.Width;
		bg.Left = 0;
		Elipse.Apply(bg, int_3);
		Elipse.Apply(slider, int_3);
		Elipse.Apply(slider2, int_3);
	}

	private void bg_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void bg_Resize(object sender, EventArgs e)
	{
		FILL.Height = bg.Height + 1;
		FILL.Top = -1;
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
		this.FILL = new System.Windows.Forms.Panel();
		this.slider = new System.Windows.Forms.Panel();
		this.slider2 = new System.Windows.Forms.Panel();
		this.bg.SuspendLayout();
		base.SuspendLayout();
		this.bg.BackColor = System.Drawing.Color.DarkGray;
		this.bg.Controls.Add(this.FILL);
		this.bg.Location = new System.Drawing.Point(3, 8);
		this.bg.Name = "bg";
		this.bg.Size = new System.Drawing.Size(408, 10);
		this.bg.TabIndex = 0;
		this.bg.Paint += new System.Windows.Forms.PaintEventHandler(bg_Paint);
		this.bg.MouseDown += new System.Windows.Forms.MouseEventHandler(bg_MouseDown);
		this.bg.Resize += new System.EventHandler(bg_Resize);
		this.FILL.BackColor = System.Drawing.Color.SeaGreen;
		this.FILL.Cursor = System.Windows.Forms.Cursors.Hand;
		this.FILL.Location = new System.Drawing.Point(18, -5);
		this.FILL.Name = "FILL";
		this.FILL.Size = new System.Drawing.Size(183, 20);
		this.FILL.TabIndex = 3;
		this.slider.BackColor = System.Drawing.Color.SeaGreen;
		this.slider.Cursor = System.Windows.Forms.Cursors.Hand;
		this.slider.Location = new System.Drawing.Point(0, 3);
		this.slider.Name = "slider";
		this.slider.Size = new System.Drawing.Size(20, 20);
		this.slider.TabIndex = 1;
		this.slider.MouseMove += new System.Windows.Forms.MouseEventHandler(slider_MouseMove);
		this.slider2.BackColor = System.Drawing.Color.SeaGreen;
		this.slider2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.slider2.Location = new System.Drawing.Point(197, 3);
		this.slider2.Name = "slider2";
		this.slider2.Size = new System.Drawing.Size(20, 20);
		this.slider2.TabIndex = 2;
		this.slider2.MouseMove += new System.Windows.Forms.MouseEventHandler(slider2_MouseMove);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		base.Controls.Add(this.slider2);
		base.Controls.Add(this.slider);
		base.Controls.Add(this.bg);
		base.Name = "BunifuRange";
		base.Size = new System.Drawing.Size(415, 28);
		base.Load += new System.EventHandler(BunifuRange_Load);
		base.Resize += new System.EventHandler(BunifuRange_Resize);
		this.bg.ResumeLayout(false);
		base.ResumeLayout(false);
	}
}
