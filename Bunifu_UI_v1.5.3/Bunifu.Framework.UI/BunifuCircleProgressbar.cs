using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DefaultEvent("ProgessChanged")]
[ProvideProperty("BunifuFramework", typeof(Control))]
[DebuggerStepThrough]
public class BunifuCircleProgressbar : UserControl
{
	private int int_0 = 5;

	private int int_1 = 8;

	private Color color_0 = Color.SeaGreen;

	private Color color_1 = Color.Gainsboro;

	private int int_2;

	private int int_3 = 100;

	private int int_4;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private bool bool_0;

	private int int_5 = -90;

	private int int_6 = 5;

	private IContainer icontainer_0;

	private Label lblpass;

	private System.Windows.Forms.Timer timer_0;

	public int GetPassentage => int.Parse(lblpass.Text.Replace("%", ""));

	public Color ProgressColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Invalidate();
			method_2(int_2);
		}
	}

	public bool LabelVisible
	{
		get
		{
			return lblpass.Visible;
		}
		set
		{
			lblpass.Visible = value;
		}
	}

	public Color ProgressBackColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			Invalidate();
			method_2(int_2);
		}
	}

	public int Value
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value <= int_3)
			{
				int_2 = value;
				lblpass.Text = (int)((double)int_2 / (double)int_3 * 100.0) + "%";
				method_2(int_2);
			}
			else
			{
				MessageBox.Show("Maximum Value Exceeded");
			}
		}
	}

	public int LineThickness
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			Invalidate();
			method_2(int_2);
		}
	}

	public int LineProgressThickness
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			Invalidate();
			method_2(int_2);
		}
	}

	public int MaxValue
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			Invalidate();
			method_2(int_2);
		}
	}

	public int animationIterval
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
		}
	}

	public bool animated
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			if (bool_0)
			{
				timer_0.Start();
				return;
			}
			timer_0.Stop();
			int_5 = -90;
			method_2(int_2);
		}
	}

	public int animationSpeed
	{
		get
		{
			return timer_0.Interval;
		}
		set
		{
			timer_0.Interval = value;
		}
	}

	public event EventHandler ProgressChanged
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

	private int method_0(int int_7)
	{
		return 360 * int_7 / int_3;
	}

	private void method_1()
	{
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, null);
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

	private void method_2(int int_7)
	{
		Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
		System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.Clear(Color.Transparent);
		Rectangle rect = new Rectangle(10, 10, base.Width - 20, base.Width - 20);
		Pen pen = new Pen(color_1);
		pen.Width = int_0;
		graphics.DrawArc(pen, rect, 0f, 360f);
		System.Drawing.Graphics graphics2 = System.Drawing.Graphics.FromImage(bitmap);
		graphics2.SmoothingMode = graphics.SmoothingMode;
		graphics2.DrawArc(rect: new Rectangle(10, 10, base.Width - 20, base.Width - 20), pen: new Pen(color_0)
		{
			Width = int_1
		}, startAngle: int_5, sweepAngle: method_0(int_7));
		BackgroundImage = bitmap;
		method_1();
	}

	public BunifuCircleProgressbar()
	{
		InitializeComponent();
		lblpass.Font = Font;
		lblpass.ForeColor = ForeColor;
		lblpass.Top = base.Height / 2 - lblpass.Height / 2;
		lblpass.Left = base.Width / 2 - lblpass.Width / 2;
		base.Width = base.Height;
		_ = LicenseManager.UsageMode;
		BunifuCustomControl.initializeComponent(this);
		GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(this, true, null);
	}

	private void method_3(object sender, PaintEventArgs e)
	{
	}

	private void BunifuCircleProgressbar_Resize(object sender, EventArgs e)
	{
		Invalidate();
		lblpass.Top = base.Height / 2 - lblpass.Height / 2;
		lblpass.Left = base.Width / 2 - lblpass.Width / 2;
		base.Width = base.Height;
		method_2(int_2);
	}

	private void BunifuCircleProgressbar_FontChanged(object sender, EventArgs e)
	{
		lblpass.Font = Font;
		lblpass.ForeColor = ForeColor;
		lblpass.Top = base.Height / 2 - lblpass.Height / 2;
		lblpass.Left = base.Width / 2 - lblpass.Width / 2;
	}

	private void BunifuCircleProgressbar_ForeColorChanged(object sender, EventArgs e)
	{
		lblpass.Font = Font;
		lblpass.ForeColor = ForeColor;
		lblpass.Top = base.Height / 2 - lblpass.Height / 2;
		lblpass.Left = base.Width / 2 - lblpass.Width / 2;
	}

	private void method_4(object sender, EventArgs e)
	{
		Elipse.Apply(lblpass, lblpass.Height);
		lblpass.Top = base.Height / 2 - lblpass.Height / 2;
		lblpass.Left = base.Width / 2 - lblpass.Width / 2;
	}

	private void BunifuCircleProgressbar_Load(object sender, EventArgs e)
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

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Value != MaxValue && Value > 0)
		{
			int_5 += animationIterval;
			method_2(int_2);
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
		this.icontainer_0 = new System.ComponentModel.Container();
		this.lblpass = new System.Windows.Forms.Label();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		base.SuspendLayout();
		this.lblpass.AutoSize = true;
		this.lblpass.BackColor = System.Drawing.Color.Transparent;
		this.lblpass.Location = new System.Drawing.Point(76, 72);
		this.lblpass.Name = "lblpass";
		this.lblpass.Size = new System.Drawing.Size(67, 39);
		this.lblpass.TabIndex = 0;
		this.lblpass.Text = "0%";
		this.timer_0.Interval = 300;
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		base.AutoScaleDimensions = new System.Drawing.SizeF(20f, 39f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.Controls.Add(this.lblpass);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25f);
		this.ForeColor = System.Drawing.Color.SeaGreen;
		base.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
		base.Name = "BunifuCircleProgressbar";
		base.Size = new System.Drawing.Size(205, 201);
		base.Load += new System.EventHandler(BunifuCircleProgressbar_Load);
		base.FontChanged += new System.EventHandler(BunifuCircleProgressbar_FontChanged);
		base.ForeColorChanged += new System.EventHandler(BunifuCircleProgressbar_ForeColorChanged);
		base.Resize += new System.EventHandler(BunifuCircleProgressbar_Resize);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
