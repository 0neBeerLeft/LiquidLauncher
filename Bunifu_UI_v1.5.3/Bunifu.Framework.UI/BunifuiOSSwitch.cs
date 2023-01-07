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
[DefaultEvent("OnValueChange")]
[DebuggerStepThrough]
public class BunifuiOSSwitch : UserControl
{
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private bool bool_0 = true;

	private Color color_0 = Color.FromArgb(71, 202, 94);

	private Color color_1 = Color.Gray;

	private Image image_0;

	private Image image_1;

	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	public bool Value
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			method_0();
		}
	}

	public Color OnColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			if (BackgroundImage != null)
			{
				image_0 = Bunifu.Framework.Lib.Graphics.OverlayColor(BackgroundImage, OnColor);
			}
			method_0();
		}
	}

	public Color OffColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			if (BackgroundImage != null)
			{
				image_1 = Bunifu.Framework.Lib.Graphics.OverlayColor(BackgroundImage, OffColor);
			}
			method_0();
		}
	}

	public event EventHandler OnValueChange
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

	public BunifuiOSSwitch()
	{
		InitializeComponent();
		image_0 = Bunifu.Framework.Lib.Graphics.OverlayColor(BackgroundImage, OnColor);
		image_1 = Bunifu.Framework.Lib.Graphics.OverlayColor(BackgroundImage, OffColor);
	}

	private void BunifuiOSSwitch_Resize(object sender, EventArgs e)
	{
		base.Size = new Size(35, 20);
	}

	private void BunifuiOSSwitch_Click(object sender, EventArgs e)
	{
		Value = !bool_0;
	}

	private void method_0()
	{
		if (Value)
		{
			BackgroundImage = image_0;
			pictureBox1.Left = base.Width - pictureBox1.Width;
		}
		else
		{
			BackgroundImage = image_1;
			pictureBox1.Left = 0;
		}
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, new EventArgs());
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

	private void BunifuiOSSwitch_Load(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuiOSSwitch));
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.pictureBox1.Enabled = false;
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(14, 1);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(21, 20);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.Controls.Add(this.pictureBox1);
		this.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DoubleBuffered = true;
		base.Name = "BunifuiOSSwitch";
		base.Size = new System.Drawing.Size(35, 20);
		base.Load += new System.EventHandler(BunifuiOSSwitch_Load);
		base.Click += new System.EventHandler(BunifuiOSSwitch_Click);
		base.Resize += new System.EventHandler(BunifuiOSSwitch_Resize);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
