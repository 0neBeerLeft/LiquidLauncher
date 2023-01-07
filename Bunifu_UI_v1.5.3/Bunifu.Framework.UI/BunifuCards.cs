using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[ProvideProperty("BunifuFramework", typeof(Control))]
[DebuggerStepThrough]
public class BunifuCards : Panel
{
	private int int_0 = 5;

	private int int_1 = 20;

	private IContainer icontainer_0;

	private PictureBox topLine;

	private PictureBox BottomLine;

	private PictureBox leftLine;

	private PictureBox rightLine;

	public Color color
	{
		get
		{
			return topLine.BackColor;
		}
		set
		{
			topLine.BackColor = value;
		}
	}

	public int BorderRadius
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			Elipse.Apply(this, int_0);
		}
	}

	public bool RightSahddow
	{
		get
		{
			return rightLine.Visible;
		}
		set
		{
			rightLine.Visible = value;
		}
	}

	public bool LeftSahddow
	{
		get
		{
			return leftLine.Visible;
		}
		set
		{
			leftLine.Visible = value;
		}
	}

	public bool BottomSahddow
	{
		get
		{
			return BottomLine.Visible;
		}
		set
		{
			BottomLine.Visible = value;
		}
	}

	public int ShadowDepth
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			method_0();
		}
	}

	public BunifuCards()
	{
		InitializeComponent();
		base.Controls.Add(topLine);
		topLine.Dock = DockStyle.Top;
		topLine.Height = 5;
		topLine.BackColor = Color.Tomato;
		base.Controls.Add(BottomLine);
		BottomLine.Dock = DockStyle.Bottom;
		BottomLine.Height = 3;
		base.Controls.Add(leftLine);
		leftLine.Dock = DockStyle.Left;
		leftLine.Width = 2;
		base.Controls.Add(rightLine);
		rightLine.Dock = DockStyle.Right;
		rightLine.Width = 2;
		topLine.BringToFront();
		Elipse.Apply(this, BorderRadius);
		method_0();
	}

	private void BunifuCards_BackColorChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		int r = BackColor.R;
		r = ((r - int_1 >= 0) ? (r - int_1) : 0);
		int g = BackColor.G;
		g = ((g - int_1 >= 0) ? (g - int_1) : 0);
		int b = BackColor.B;
		b = ((b - int_1 >= 0) ? (b - int_1) : 0);
		BottomLine.BackColor = Color.FromArgb(r, g, b);
	}

	private void BunifuCards_Resize(object sender, EventArgs e)
	{
		Elipse.Apply(this, int_0);
	}

	private void BottomLine_BackColorChanged(object sender, EventArgs e)
	{
		PictureBox pictureBox = leftLine;
		Color backColor2 = (rightLine.BackColor = BottomLine.BackColor);
		pictureBox.BackColor = backColor2;
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
		this.topLine = new System.Windows.Forms.PictureBox();
		this.BottomLine = new System.Windows.Forms.PictureBox();
		this.leftLine = new System.Windows.Forms.PictureBox();
		this.rightLine = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.topLine).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.BottomLine).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.leftLine).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.rightLine).BeginInit();
		base.SuspendLayout();
		this.topLine.Location = new System.Drawing.Point(0, 0);
		this.topLine.Name = "topLine";
		this.topLine.Size = new System.Drawing.Size(100, 50);
		this.topLine.TabIndex = 0;
		this.topLine.TabStop = false;
		this.BottomLine.Location = new System.Drawing.Point(0, 0);
		this.BottomLine.Name = "BottomLine";
		this.BottomLine.Size = new System.Drawing.Size(100, 50);
		this.BottomLine.TabIndex = 0;
		this.BottomLine.TabStop = false;
		this.BottomLine.BackColorChanged += new System.EventHandler(BottomLine_BackColorChanged);
		this.leftLine.Location = new System.Drawing.Point(0, 0);
		this.leftLine.Name = "leftLine";
		this.leftLine.Size = new System.Drawing.Size(100, 50);
		this.leftLine.TabIndex = 0;
		this.leftLine.TabStop = false;
		this.leftLine.Visible = false;
		this.rightLine.Location = new System.Drawing.Point(0, 0);
		this.rightLine.Name = "rightLine";
		this.rightLine.Size = new System.Drawing.Size(100, 50);
		this.rightLine.TabIndex = 0;
		this.rightLine.TabStop = false;
		this.BackColor = System.Drawing.Color.White;
		base.Name = "BunifuPaperPanel";
		base.Size = new System.Drawing.Size(605, 397);
		base.BackColorChanged += new System.EventHandler(BunifuCards_BackColorChanged);
		base.Resize += new System.EventHandler(BunifuCards_Resize);
		((System.ComponentModel.ISupportInitialize)this.topLine).EndInit();
		((System.ComponentModel.ISupportInitialize)this.BottomLine).EndInit();
		((System.ComponentModel.ISupportInitialize)this.leftLine).EndInit();
		((System.ComponentModel.ISupportInitialize)this.rightLine).EndInit();
		base.ResumeLayout(false);
	}
}
