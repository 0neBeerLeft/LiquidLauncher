using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[ProvideProperty("BunifuFramework", typeof(Control))]
[DefaultEvent("Click")]
[DebuggerStepThrough]
public class BunifuSwitch : UserControl
{
	private bool bool_0 = true;

	private Color color_0 = Color.SeaGreen;

	private Color color_1 = Color.DarkGray;

	private int int_0;

	private int int_1;

	private int int_2;

	private IContainer icontainer_0;

	private Panel panel1;

	private BunifuCustomLabel customLabel1;

	public int BorderRadius
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			Elipse.Apply(this, int_2);
		}
	}

	public bool Value
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (value)
			{
				panel1.Dock = DockStyle.Left;
				panel1.BackColor = color_0;
				customLabel1.Dock = DockStyle.Right;
				customLabel1.Text = "On";
			}
			else
			{
				panel1.Dock = DockStyle.Right;
				panel1.BackColor = color_1;
				customLabel1.Dock = DockStyle.Left;
				customLabel1.Text = "Off";
			}
			bool_0 = value;
		}
	}

	public Color Textcolor
	{
		get
		{
			return customLabel1.ForeColor;
		}
		set
		{
			customLabel1.ForeColor = value;
		}
	}

	public Color Oncolor
	{
		get
		{
			return color_0;
		}
		set
		{
			if (bool_0)
			{
				panel1.BackColor = value;
			}
			color_0 = value;
		}
	}

	public Color Onoffcolor
	{
		get
		{
			return color_1;
		}
		set
		{
			if (!bool_0)
			{
				panel1.BackColor = value;
			}
			color_1 = value;
		}
	}

	public BunifuSwitch()
	{
		InitializeComponent();
		int_0 = base.Width;
		int_1 = base.Height;
		BunifuCustomControl.initializeComponent(this);
	}

	private void BunifuSwitch_Click(object sender, EventArgs e)
	{
		Value = !Value;
	}

	private void BunifuSwitch_Resize(object sender, EventArgs e)
	{
		Elipse.Apply(this, int_2);
		base.Width = int_0;
		base.Height = int_1;
	}

	private void BunifuSwitch_ForeColorChanged(object sender, EventArgs e)
	{
		customLabel1.ForeColor = ForeColor;
	}

	private void BunifuSwitch_Load(object sender, EventArgs e)
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
		this.panel1 = new System.Windows.Forms.Panel();
		this.customLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		base.SuspendLayout();
		this.panel1.BackColor = System.Drawing.Color.SeaGreen;
		this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
		this.panel1.Enabled = false;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(37, 19);
		this.panel1.TabIndex = 0;
		this.panel1.Click += new System.EventHandler(BunifuSwitch_Click);
		this.customLabel1.Dock = System.Windows.Forms.DockStyle.Right;
		this.customLabel1.Enabled = false;
		this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		this.customLabel1.Location = new System.Drawing.Point(26, 0);
		this.customLabel1.Name = "customLabel1";
		this.customLabel1.Size = new System.Drawing.Size(25, 19);
		this.customLabel1.TabIndex = 1;
		this.customLabel1.Text = "On";
		this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
		base.Controls.Add(this.customLabel1);
		base.Controls.Add(this.panel1);
		this.Cursor = System.Windows.Forms.Cursors.Hand;
		this.ForeColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.Name = "BunifuSwitch";
		base.Size = new System.Drawing.Size(51, 19);
		base.Load += new System.EventHandler(BunifuSwitch_Load);
		base.ForeColorChanged += new System.EventHandler(BunifuSwitch_ForeColorChanged);
		base.Click += new System.EventHandler(BunifuSwitch_Click);
		base.Resize += new System.EventHandler(BunifuSwitch_Resize);
		base.ResumeLayout(false);
	}
}
