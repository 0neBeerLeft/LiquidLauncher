using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

[DefaultEvent("Click")]
[DebuggerStepThrough]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuTileButton : UserControl
{
	private int int_0 = 50;

	private Color color_0 = Color.SeaGreen;

	private Color color_1 = Color.MediumSeaGreen;

	private IContainer icontainer_0;

	private PictureBox img;

	private Label lbl;

	public Image Image
	{
		get
		{
			return img.Image;
		}
		set
		{
			img.Image = value;
		}
	}

	public string LabelText
	{
		get
		{
			return lbl.Text;
		}
		set
		{
			lbl.Text = value;
		}
	}

	public int LabelPosition
	{
		get
		{
			return lbl.Height;
		}
		set
		{
			lbl.Height = value;
		}
	}

	public int ImageZoom
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			method_0();
		}
	}

	public int ImagePosition
	{
		get
		{
			return img.Top;
		}
		set
		{
			img.Top = value;
			method_0();
		}
	}

	public Color color
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

	public Color colorActive
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

	public BunifuTileButton()
	{
		InitializeComponent();
		BunifuCustomControl.initializeComponent(this);
		method_0();
	}

	private void BunifuTileButton_Resize(object sender, EventArgs e)
	{
		method_0();
	}

	protected override void OnClick(EventArgs e)
	{
		BackColor = color_0;
		base.OnClick(e);
	}

	private void lbl_Click(object sender, EventArgs e)
	{
		BackColor = color_0;
		base.OnClick(e);
	}

	private void BunifuTileButton_MouseEnter(object sender, EventArgs e)
	{
		BackColor = color_1;
	}

	private void BunifuTileButton_MouseLeave(object sender, EventArgs e)
	{
		BackColor = color_0;
	}

	private void lbl_MouseLeave(object sender, EventArgs e)
	{
		BackColor = color_0;
	}

	private void lbl_MouseEnter(object sender, EventArgs e)
	{
		BackColor = color_1;
	}

	private void img_SizeChanged(object sender, EventArgs e)
	{
		method_0();
	}

	private void BunifuTileButton_FontChanged(object sender, EventArgs e)
	{
		lbl.Font = Font;
		method_0();
	}

	private void BunifuTileButton_ForeColorChanged(object sender, EventArgs e)
	{
		lbl.ForeColor = ForeColor;
	}

	private void method_0()
	{
		double num = base.Width;
		double num2 = 100.0;
		double value = num / num2 * (double)int_0;
		img.Width = int.Parse(Math.Round(value, 0).ToString());
		img.Height = img.Width;
		img.Left = base.Width / 2 - img.Width / 2;
	}

	private void BunifuTileButton_Load(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuTileButton));
		this.img = new System.Windows.Forms.PictureBox();
		this.lbl = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.img).BeginInit();
		base.SuspendLayout();
		this.img.Cursor = System.Windows.Forms.Cursors.Hand;
		this.img.Enabled = false;
		this.img.Image = (System.Drawing.Image)resources.GetObject("img.Image");
		this.img.Location = new System.Drawing.Point(33, 20);
		this.img.Margin = new System.Windows.Forms.Padding(6);
		this.img.Name = "img";
		this.img.Size = new System.Drawing.Size(64, 56);
		this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.img.TabIndex = 0;
		this.img.TabStop = false;
		this.img.SizeChanged += new System.EventHandler(img_SizeChanged);
		this.lbl.Cursor = System.Windows.Forms.Cursors.Hand;
		this.lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.lbl.Font = new System.Drawing.Font("Century Gothic", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lbl.ForeColor = System.Drawing.Color.White;
		this.lbl.Location = new System.Drawing.Point(0, 88);
		this.lbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
		this.lbl.Name = "lbl";
		this.lbl.Size = new System.Drawing.Size(128, 41);
		this.lbl.TabIndex = 1;
		this.lbl.Text = "Tile 1";
		this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.lbl.Click += new System.EventHandler(lbl_Click);
		this.lbl.MouseEnter += new System.EventHandler(lbl_MouseEnter);
		this.lbl.MouseLeave += new System.EventHandler(lbl_MouseLeave);
		base.AutoScaleDimensions = new System.Drawing.SizeF(12f, 24f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.SeaGreen;
		base.Controls.Add(this.lbl);
		base.Controls.Add(this.img);
		this.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Font = new System.Drawing.Font("Century Gothic", 15.75f);
		this.ForeColor = System.Drawing.Color.White;
		base.Margin = new System.Windows.Forms.Padding(6);
		base.Name = "BunifuTileButton";
		base.Size = new System.Drawing.Size(128, 129);
		base.Load += new System.EventHandler(BunifuTileButton_Load);
		base.FontChanged += new System.EventHandler(BunifuTileButton_FontChanged);
		base.ForeColorChanged += new System.EventHandler(BunifuTileButton_ForeColorChanged);
		base.MouseEnter += new System.EventHandler(BunifuTileButton_MouseEnter);
		base.MouseLeave += new System.EventHandler(BunifuTileButton_MouseLeave);
		base.Resize += new System.EventHandler(BunifuTileButton_Resize);
		((System.ComponentModel.ISupportInitialize)this.img).EndInit();
		base.ResumeLayout(false);
	}
}
