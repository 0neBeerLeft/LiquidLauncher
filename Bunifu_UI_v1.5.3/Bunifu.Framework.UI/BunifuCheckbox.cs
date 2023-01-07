using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DefaultEvent("OnChange")]
[DebuggerStepThrough]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuCheckbox : UserControl
{
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private bool bool_0 = true;

	private Color color_0 = Color.FromArgb(51, 205, 117);

	private Color color_1 = Color.FromArgb(132, 135, 140);

	private IContainer icontainer_0;

	private PictureBox check;

	public Color CheckedOnColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			BackColor = color_0;
		}
	}

	public Color ChechedOffColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
		}
	}

	public bool Checked
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			check.Visible = bool_0;
			if (bool_0)
			{
				BackColor = color_0;
			}
			else
			{
				BackColor = color_1;
			}
		}
	}

	public event EventHandler OnChange
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

	public BunifuCheckbox()
	{
		InitializeComponent();
		Elipse.Apply(this, 5);
	}

	private void BunifuCheckbox_Click(object sender, EventArgs e)
	{
		check.Visible = !check.Visible;
		Checked = check.Visible;
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

	private void BunifuCheckbox_Resize(object sender, EventArgs e)
	{
		base.Size = new Size(20, 20);
	}

	private void BunifuCheckbox_ForeColorChanged(object sender, EventArgs e)
	{
		check.Image = Bunifu.Framework.Lib.Graphics.OverlayColor(check.Image, ForeColor);
	}

	private void BunifuCheckbox_Load(object sender, EventArgs e)
	{
		if (bool_0)
		{
			BackColor = color_0;
		}
		else
		{
			BackColor = color_1;
		}
		BunifuCustomControl.initializeComponent(this);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuCheckbox));
		this.check = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.check).BeginInit();
		base.SuspendLayout();
		this.check.BackColor = System.Drawing.Color.Transparent;
		this.check.Dock = System.Windows.Forms.DockStyle.Fill;
		this.check.Image = (System.Drawing.Image)resources.GetObject("check.Image");
		this.check.Location = new System.Drawing.Point(0, 0);
		this.check.Name = "check";
		this.check.Size = new System.Drawing.Size(20, 20);
		this.check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.check.TabIndex = 0;
		this.check.TabStop = false;
		this.check.Click += new System.EventHandler(BunifuCheckbox_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.SeaGreen;
		base.Controls.Add(this.check);
		this.ForeColor = System.Drawing.Color.White;
		base.Name = "BunifuCheckbox";
		base.Size = new System.Drawing.Size(20, 20);
		base.Load += new System.EventHandler(BunifuCheckbox_Load);
		base.ForeColorChanged += new System.EventHandler(BunifuCheckbox_ForeColorChanged);
		base.Click += new System.EventHandler(BunifuCheckbox_Click);
		base.Resize += new System.EventHandler(BunifuCheckbox_Resize);
		((System.ComponentModel.ISupportInitialize)this.check).EndInit();
		base.ResumeLayout(false);
	}
}
