using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

[ProvideProperty("BunifuFramework", typeof(Control))]
[DebuggerStepThrough]
public class BunifuSeparator : UserControl
{
	private bool bool_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	public bool Vertical
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (value != bool_0)
			{
				bool_0 = value;
				int num = pictureBox1.Height;
				int num2 = pictureBox1.Width;
				pictureBox1.Height = num2;
				pictureBox1.Width = num;
				OnResize(new EventArgs());
				return;
			}
			int num3 = default(int);
			int num4 = default(int);
			while (num3 == num4)
			{
				num4 = 1;
				int num5 = num3;
				num3 = 1;
				if (1 > num5)
				{
					break;
				}
			}
		}
	}

	public Color LineColor
	{
		get
		{
			return pictureBox1.BackColor;
		}
		set
		{
			pictureBox1.BackColor = value;
		}
	}

	public int Transparency
	{
		get
		{
			return pictureBox1.BackColor.A;
		}
		set
		{
			pictureBox1.BackColor = Color.FromArgb(value, pictureBox1.BackColor.R, pictureBox1.BackColor.G, pictureBox1.BackColor.B);
		}
	}

	public int LineThickness
	{
		get
		{
			if (Vertical)
			{
				return pictureBox1.Width;
			}
			return pictureBox1.Height;
		}
		set
		{
			if (Vertical)
			{
				pictureBox1.Width = value;
			}
			else
			{
				pictureBox1.Height = value;
			}
		}
	}

	public BunifuSeparator()
	{
		InitializeComponent();
		OnResize(new EventArgs());
		_ = LicenseManager.UsageMode;
		BunifuCustomControl.initializeComponent(this);
	}

	private void BunifuSeparator_BackColorChanged(object sender, EventArgs e)
	{
		if (BackColor != Color.Transparent)
		{
			throw new Exception("Invalid Value");
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

	private void BunifuSeparator_Resize(object sender, EventArgs e)
	{
		if (Vertical)
		{
			pictureBox1.Top = 0;
			pictureBox1.Height = base.Height;
			pictureBox1.Left = base.Width / 2 - pictureBox1.Width / 2;
		}
		else
		{
			pictureBox1.Left = 0;
			pictureBox1.Width = base.Width;
			pictureBox1.Top = base.Height / 2 - pictureBox1.Height / 2;
		}
	}

	private void BunifuSeparator_Load(object sender, EventArgs e)
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
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
		this.pictureBox1.Location = new System.Drawing.Point(0, 15);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(639, 1);
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		base.Controls.Add(this.pictureBox1);
		base.Name = "BunifuSeparator";
		base.Size = new System.Drawing.Size(639, 35);
		base.Load += new System.EventHandler(BunifuSeparator_Load);
		base.BackColorChanged += new System.EventHandler(BunifuSeparator_BackColorChanged);
		base.Resize += new System.EventHandler(BunifuSeparator_Resize);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
	}
}
