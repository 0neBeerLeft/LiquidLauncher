using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

[ProvideProperty("BunifuFramework", typeof(Control))]
[DefaultEvent("Click")]
public class BunifuThinButton2 : UserControl
{
	private Color color_0 = Color.SeaGreen;

	private Color color_1 = Color.White;

	private Color color_2 = Color.SeaGreen;

	private int int_0 = 20;

	private int int_1 = 1;

	private Color color_3 = Color.SeaGreen;

	private Color color_4 = Color.SeaGreen;

	private Color color_5 = Color.White;

	private int int_2 = 20;

	private int int_3 = 1;

	public bool Onfocus;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	[CompilerGenerated]
	private EventHandler eventHandler_2;

	[CompilerGenerated]
	private EventHandler eventHandler_3;

	[CompilerGenerated]
	private EventHandler eventHandler_4;

	[CompilerGenerated]
	private EventHandler eventHandler_5;

	private IContainer icontainer_0;

	private BunifuCustomLabel label1;

	public Color ActiveLineColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			Refresh();
		}
	}

	public Color ActiveForecolor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			Refresh();
		}
	}

	public Color ActiveFillColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			Refresh();
		}
	}

	public int ActiveCornerRadius
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			Refresh();
		}
	}

	public int ActiveBorderThickness
	{
		get
		{
			return int_1;
		}
		set
		{
			if (value > 0)
			{
				int_1 = value;
				Refresh();
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

	public Color IdleLineColor
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			Refresh();
		}
	}

	public Color IdleForecolor
	{
		get
		{
			return color_4;
		}
		set
		{
			color_4 = value;
			Refresh();
		}
	}

	public Color IdleFillColor
	{
		get
		{
			return color_5;
		}
		set
		{
			color_5 = value;
			Refresh();
		}
	}

	public int IdleCornerRadius
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			Refresh();
		}
	}

	public int IdleBorderThickness
	{
		get
		{
			return int_3;
		}
		set
		{
			if (value > 0)
			{
				int_3 = value;
				Refresh();
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

	public ContentAlignment TextAlign
	{
		get
		{
			return label1.TextAlign;
		}
		set
		{
			label1.TextAlign = label1.TextAlign;
		}
	}

	public string ButtonText
	{
		get
		{
			return label1.Text;
		}
		set
		{
			label1.Text = value;
			OnResize(new EventArgs());
		}
	}

	public new event EventHandler Click
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

	public new event EventHandler MouseDown
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

	public new event EventHandler MouseEnter
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

	public new event EventHandler MouseHover
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_3;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_3, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public new event EventHandler MouseLeave
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public new event EventHandler MouseMove
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BunifuThinButton2()
	{
		InitializeComponent();
		GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(this, true, null);
	}

	private void method_0(Graphics graphics_0, Rectangle rectangle_0, int int_4, Pen pen_0, Color color_6)
	{
		graphics_0.Clear(BackColor);
		GraphicsPath graphicsPath = new GraphicsPath();
		pen_0.StartCap = LineCap.Round;
		pen_0.EndCap = LineCap.Round;
		graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y, int_4, int_4, 180f, 90f);
		graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_4, rectangle_0.Y, int_4, int_4, 270f, 90f);
		graphicsPath.AddArc(rectangle_0.X + rectangle_0.Width - int_4, rectangle_0.Y + rectangle_0.Height - int_4, int_4, int_4, 0f, 90f);
		graphicsPath.AddArc(rectangle_0.X, rectangle_0.Y + rectangle_0.Height - int_4, int_4, int_4, 90f, 90f);
		graphicsPath.CloseAllFigures();
		graphics_0.FillPath(new SolidBrush(color_6), graphicsPath);
		graphics_0.SmoothingMode = SmoothingMode.HighQuality;
		graphics_0.DrawPath(pen_0, graphicsPath);
		graphics_0.SmoothingMode = SmoothingMode.AntiAlias;
	}

	public new void Refresh()
	{
		Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.Clear(Color.Transparent);
		if (Onfocus)
		{
			Rectangle rectangle_ = new Rectangle(int_1, int_1 + 5, base.Width - int_1 * 2, base.Height - int_1 * 2 - 10);
			label1.ForeColor = color_1;
			if (!base.DesignMode)
			{
				Application.DoEvents();
			}
			method_0(graphics, rectangle_, int_0, new Pen(color_0, int_1), color_2);
		}
		else
		{
			Rectangle rectangle_2 = new Rectangle(int_3, int_3 + 5, base.Width - int_3 * 2, base.Height - int_3 * 2 - 10);
			label1.ForeColor = color_4;
			if (!base.DesignMode)
			{
				Application.DoEvents();
			}
			method_0(graphics, rectangle_2, int_2, new Pen(color_3, int_3), color_5);
		}
		BackgroundImage = bitmap;
	}

	private void BunifuThinButton2_MouseEnter(object sender, EventArgs e)
	{
		Onfocus = true;
		Refresh();
	}

	private void BunifuThinButton2_MouseLeave(object sender, EventArgs e)
	{
		Onfocus = false;
		Refresh();
	}

	private void BunifuThinButton2_Resize(object sender, EventArgs e)
	{
		label1.Left = base.Width / 2 - label1.Width / 2;
		label1.Top = base.Height / 2 - label1.Height / 2 + 2;
		Refresh();
	}

	private void BunifuThinButton2_FontChanged(object sender, EventArgs e)
	{
		label1.Font = Font;
	}

	private void BunifuThinButton2_ForeColorChanged(object sender, EventArgs e)
	{
		label1.ForeColor = ForeColor;
	}

	protected override void OnParentChanged(EventArgs e)
	{
		if (base.Parent != null)
		{
			BackColor = base.Parent.BackColor;
		}
		base.OnParentChanged(e);
	}

	protected override void OnParentBackColorChanged(EventArgs e)
	{
		BackColor = base.Parent.BackColor;
		base.OnParentBackColorChanged(e);
	}

	private void BunifuThinButton2_Load(object sender, EventArgs e)
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

	private void label1_Click(object sender, EventArgs e)
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

	private void label1_MouseDown(object sender, MouseEventArgs e)
	{
		if (eventHandler_1 != null)
		{
			eventHandler_1(this, e);
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

	private void label1_MouseEnter(object sender, EventArgs e)
	{
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, e);
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

	private void label1_MouseHover(object sender, EventArgs e)
	{
		if (eventHandler_3 != null)
		{
			eventHandler_3(this, e);
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

	private void label1_MouseLeave(object sender, EventArgs e)
	{
		if (eventHandler_4 != null)
		{
			eventHandler_4(this, e);
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

	private void label1_MouseMove(object sender, MouseEventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, e);
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
		this.label1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		base.SuspendLayout();
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.label1.Location = new System.Drawing.Point(0, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(181, 41);
		this.label1.TabIndex = 0;
		this.label1.Text = "ThinButton";
		this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label1.Click += new System.EventHandler(label1_Click);
		this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(label1_MouseDown);
		this.label1.MouseEnter += new System.EventHandler(label1_MouseEnter);
		this.label1.MouseLeave += new System.EventHandler(label1_MouseLeave);
		this.label1.MouseHover += new System.EventHandler(label1_MouseHover);
		this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(label1_MouseMove);
		base.AutoScaleDimensions = new System.Drawing.SizeF(10f, 21f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.Controls.Add(this.label1);
		this.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Font = new System.Drawing.Font("Century Gothic", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ForeColor = System.Drawing.Color.SeaGreen;
		base.Margin = new System.Windows.Forms.Padding(5);
		base.Name = "BunifuThinButton2";
		base.Size = new System.Drawing.Size(181, 41);
		base.Load += new System.EventHandler(BunifuThinButton2_Load);
		base.FontChanged += new System.EventHandler(BunifuThinButton2_FontChanged);
		base.ForeColorChanged += new System.EventHandler(BunifuThinButton2_ForeColorChanged);
		this.MouseEnter += new System.EventHandler(BunifuThinButton2_MouseEnter);
		this.MouseLeave += new System.EventHandler(BunifuThinButton2_MouseLeave);
		base.Resize += new System.EventHandler(BunifuThinButton2_Resize);
		base.ResumeLayout(false);
	}
}
