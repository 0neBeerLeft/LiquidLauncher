using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

public class BunifuGauge : UserControl
{
	private Color color_0 = Color.Gray;

	private Color color_1 = Color.SeaGreen;

	private int int_0;

	private int int_1 = 30;

	private Color color_2 = Color.SeaGreen;

	private Color color_3 = Color.Tomato;

	private string string_0 = "";

	private IContainer icontainer_0;

	private Label lblpass;

	private Label lblmin;

	private Label lblmax;

	private BunifuColorTransition bunifuColorTransition_0;

	public Color ProgressColor1
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			bunifuColorTransition_0.Color1 = color_2;
			method_0(int_0);
		}
	}

	public Color ProgressColor2
	{
		get
		{
			return color_3;
		}
		set
		{
			color_3 = value;
			bunifuColorTransition_0.Color2 = color_3;
			method_0(int_0);
		}
	}

	public Color ProgressBgColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			method_0(int_0);
		}
	}

	public int Value
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value <= 100)
			{
				int_0 = value;
				bunifuColorTransition_0.ProgessValue = int_0;
				method_0(int_0);
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

	public string Suffix
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			lblpass.Text = Value + string_0;
		}
	}

	public int Thickness
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			method_0(int_0);
		}
	}

	public BunifuGauge()
	{
		InitializeComponent();
		GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(this, true, null);
		BunifuGauge_Resize(this, new EventArgs());
		method_0(int_0);
	}

	private void method_0(int int_2)
	{
		Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height);
		Graphics graphics = Graphics.FromImage(bitmap);
		graphics.SmoothingMode = SmoothingMode.HighQuality;
		graphics.Clear(Color.Transparent);
		Pen pen = new Pen(color_0, int_1);
		int num = base.Size.Width - int_1 * 2;
		Rectangle rect = new Rectangle(int_1, base.Size.Height / 4, num, num);
		Pen pen2 = new Pen(color_1, int_1);
		Graphics graphics2 = Graphics.FromImage(bitmap);
		graphics2.SmoothingMode = SmoothingMode.HighQuality;
		graphics2.DrawArc(pen, rect, 180f, 180f);
		lblpass.Text = int_2 + Suffix;
		graphics2.DrawArc(pen2, rect, 180f, method_1(int_2));
		BackgroundImage = bitmap;
	}

	private int method_1(int int_2)
	{
		return int.Parse(Math.Round((double)int_2 * 180.0 / 100.0, 0).ToString());
	}

	private void BunifuGauge_Resize(object sender, EventArgs e)
	{
		method_0(int_0);
		lblpass.Top = base.Height - lblpass.Height - 30;
		Label label = lblmin;
		int top = (lblmax.Top = base.Height - lblmax.Height - 10);
		label.Top = top;
		lblmin.Left = 20;
		lblmax.Left = base.Size.Width - lblmax.Width - 20;
		lblpass.Left = base.Width / 2 - lblpass.Width / 2;
	}

	private void BunifuGauge_ForeColorChanged(object sender, EventArgs e)
	{
		Label label = lblpass;
		Label label2 = lblmin;
		Color color = (lblmax.ForeColor = ForeColor);
		Color foreColor2 = (label2.ForeColor = color);
		label.ForeColor = foreColor2;
		method_0(int_0);
	}

	private void BunifuGauge_FontChanged(object sender, EventArgs e)
	{
		lblpass.Font = Font;
		method_0(int_0);
	}

	private void bunifuColorTransition_0_OnValueChange(object sender, EventArgs e)
	{
		color_1 = bunifuColorTransition_0.Value;
	}

	private void BunifuGauge_Load(object sender, EventArgs e)
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
		this.icontainer_0 = new System.ComponentModel.Container();
		this.lblpass = new System.Windows.Forms.Label();
		this.lblmin = new System.Windows.Forms.Label();
		this.lblmax = new System.Windows.Forms.Label();
		this.bunifuColorTransition_0 = new Bunifu.Framework.UI.BunifuColorTransition(this.icontainer_0);
		base.SuspendLayout();
		this.lblpass.AutoSize = true;
		this.lblpass.Font = new System.Drawing.Font("Century Gothic", 15.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblpass.Location = new System.Drawing.Point(83, 34);
		this.lblpass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
		this.lblpass.Name = "lblpass";
		this.lblpass.Size = new System.Drawing.Size(22, 24);
		this.lblpass.TabIndex = 1;
		this.lblpass.Text = "0";
		this.lblmin.AutoSize = true;
		this.lblmin.Font = new System.Drawing.Font("Century Gothic", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblmin.Location = new System.Drawing.Point(26, 86);
		this.lblmin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
		this.lblmin.Name = "lblmin";
		this.lblmin.Size = new System.Drawing.Size(15, 17);
		this.lblmin.TabIndex = 2;
		this.lblmin.Text = "0";
		this.lblmax.AutoSize = true;
		this.lblmax.Font = new System.Drawing.Font("Century Gothic", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.lblmax.Location = new System.Drawing.Point(145, 86);
		this.lblmax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
		this.lblmax.Name = "lblmax";
		this.lblmax.Size = new System.Drawing.Size(29, 17);
		this.lblmax.TabIndex = 3;
		this.lblmax.Text = "100";
		this.bunifuColorTransition_0.Color1 = System.Drawing.Color.SeaGreen;
		this.bunifuColorTransition_0.Color2 = System.Drawing.Color.Tomato;
		this.bunifuColorTransition_0.ProgessValue = 0;
		this.bunifuColorTransition_0.OnValueChange += new System.EventHandler(bunifuColorTransition_0_OnValueChange);
		base.AutoScaleDimensions = new System.Drawing.SizeF(12f, 24f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.lblmax);
		base.Controls.Add(this.lblmin);
		base.Controls.Add(this.lblpass);
		this.Font = new System.Drawing.Font("Century Gothic", 15.75f);
		base.Margin = new System.Windows.Forms.Padding(6);
		base.Name = "BunifuGauge";
		base.Size = new System.Drawing.Size(174, 117);
		base.Load += new System.EventHandler(BunifuGauge_Load);
		base.FontChanged += new System.EventHandler(BunifuGauge_FontChanged);
		base.ForeColorChanged += new System.EventHandler(BunifuGauge_ForeColorChanged);
		base.Resize += new System.EventHandler(BunifuGauge_Resize);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
