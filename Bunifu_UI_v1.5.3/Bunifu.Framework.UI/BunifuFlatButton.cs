using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DefaultEvent("Click")]
[ProvideProperty("BunifuFramework", typeof(Control))]
[DebuggerStepThrough]
public class BunifuFlatButton : UserControl
{
	private Image image_0;

	public Color colbackground = Color.FromArgb(46, 139, 87);

	public Color colhover = Color.FromArgb(36, 129, 77);

	public Color colselected = Color.FromArgb(46, 139, 87);

	private bool bool_0;

	private int int_0;

	private bool bool_1 = true;

	private Color color_0 = Color.Gray;

	private Color color_1 = Color.Transparent;

	private int int_1;

	private int int_2;

	private double double_0 = 90.0;

	private double double_1;

	private Color color_2 = Color.White;

	private Color color_3 = Color.White;

	private bool bool_2;

	private Image image_1;

	private Image image_2;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	private IContainer icontainer_0;

	private ImageList imageList_0;

	public PictureBox limage;

	public PictureBox rimage;

	private BunifuCustomLabel txttext;

	[EditorBrowsable(EditorBrowsableState.Never)]
	public string ButtonText
	{
		get
		{
			return txttext.Text;
		}
		set
		{
			txttext.Text = value;
		}
	}

	[Bindable(true)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public override string Text
	{
		get
		{
			return ButtonText;
		}
		set
		{
			ButtonText = value;
		}
	}

	[Bindable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public new bool Enabled
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			if (value)
			{
				BackColor = Normalcolor;
			}
			else
			{
				BackColor = color_0;
			}
		}
	}

	public Color DisabledColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	public ContentAlignment TextAlign
	{
		get
		{
			return txttext.TextAlign;
		}
		set
		{
			txttext.TextAlign = value;
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
			if (value < 8)
			{
				int_0 = value;
				Elipse.Apply(this, int_0);
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

	public Color Iconcolor
	{
		get
		{
			return limage.BackColor;
		}
		set
		{
			color_1 = value;
			limage.BackColor = value;
		}
	}

	public bool IsTab
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public Image Iconimage
	{
		get
		{
			return limage.Image;
		}
		set
		{
			limage.Image = value;
			image_1 = value;
			OnResize(new EventArgs());
		}
	}

	public bool IconVisible
	{
		get
		{
			return limage.Visible;
		}
		set
		{
			limage.Visible = value;
			method_0();
		}
	}

	public bool IconRightVisible
	{
		get
		{
			return rimage.Visible;
		}
		set
		{
			rimage.Visible = value;
			method_0();
		}
	}

	public int IconMarginLeft
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			BunifuFlatButton_Resize(this, new EventArgs());
		}
	}

	public int IconMarginRight
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			BunifuFlatButton_Resize(this, new EventArgs());
		}
	}

	public Image Iconimage_Selected
	{
		get
		{
			return (Image)limage.Tag;
		}
		set
		{
			limage.Tag = value;
			OnResize(new EventArgs());
		}
	}

	public Image Iconimage_right
	{
		get
		{
			return rimage.Image;
		}
		set
		{
			rimage.Image = value;
			image_2 = value;
			OnResize(new EventArgs());
		}
	}

	public Image Iconimage_right_Selected
	{
		get
		{
			return (Image)rimage.Tag;
		}
		set
		{
			rimage.Tag = value;
			OnResize(new EventArgs());
		}
	}

	public Font TextFont
	{
		get
		{
			return txttext.Font;
		}
		set
		{
			txttext.Font = value;
			method_0();
		}
	}

	public Color Textcolor
	{
		get
		{
			return txttext.ForeColor;
		}
		set
		{
			color_3 = value;
			txttext.ForeColor = value;
		}
	}

	public Color Normalcolor
	{
		get
		{
			return colbackground;
		}
		set
		{
			BackColor = value;
			colbackground = value;
		}
	}

	public double IconZoom
	{
		get
		{
			return double_0;
		}
		set
		{
			double_0 = value;
			method_1();
		}
	}

	public double IconRightZoom
	{
		get
		{
			return double_1;
		}
		set
		{
			double_1 = value;
			method_2();
		}
	}

	public Color OnHovercolor
	{
		get
		{
			return colhover;
		}
		set
		{
			colhover = value;
		}
	}

	public Color Activecolor
	{
		get
		{
			return colselected;
		}
		set
		{
			colselected = value;
		}
	}

	public bool selected
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			if (bool_2)
			{
				BackColor = colselected;
				if (Iconimage_Selected != null)
				{
					limage.Image = Iconimage_Selected;
				}
				if (Iconimage_right_Selected != null)
				{
					rimage.Image = Iconimage_right_Selected;
					return;
				}
			}
			else
			{
				BackColor = colbackground;
				if (Iconimage_Selected != null)
				{
					limage.Image = image_1;
				}
				if (Iconimage_right_Selected != null)
				{
					rimage.Image = image_2;
					return;
				}
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

	public Color OnHoverTextColor
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
		}
	}

	public new event EventHandler MouseDown
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

	public new event EventHandler MouseUp
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

	private void method_0()
	{
		if (limage.Visible)
		{
			txttext.Left = limage.Right;
		}
		else
		{
			txttext.Left = 0;
		}
		if (rimage.Visible)
		{
			txttext.Width = rimage.Left - txttext.Left;
		}
		else
		{
			txttext.Width = base.Width - txttext.Left;
		}
	}

	private void method_1()
	{
		double num = base.Height;
		double num2 = Math.Round(double_0 / 100.0 * num, 0);
		PictureBox pictureBox = limage;
		int num4 = (rimage.Height = int.Parse(num2.ToString()));
		pictureBox.Height = num4;
		OnResize(new EventArgs());
	}

	private void method_2()
	{
		double num = base.Height;
		double num2 = Math.Round(double_1 / 100.0 * num, 0);
		PictureBox pictureBox = rimage;
		int num4 = (rimage.Height = int.Parse(num2.ToString()));
		pictureBox.Height = num4;
		OnResize(new EventArgs());
	}

	public BunifuFlatButton()
	{
		InitializeComponent();
		if (selected)
		{
			selected = true;
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

	public void reset()
	{
		bool_2 = false;
		BackColor = colbackground;
	}

	private void BunifuFlatButton_Load(object sender, EventArgs e)
	{
		BunifuCustomControl.initializeComponent(this);
		if (bool_1)
		{
			BackColor = Normalcolor;
		}
		else
		{
			BackColor = DisabledColor;
		}
		if (IsTab && selected)
		{
			selected = true;
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

	private void BunifuFlatButton_MouseEnter(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			BackColor = DisabledColor;
			return;
		}
		txttext.ForeColor = color_2;
		limage.BackColor = Color.Transparent;
		BackColor = colhover;
	}

	private void BunifuFlatButton_MouseLeave(object sender, EventArgs e)
	{
		if (!bool_1)
		{
			BackColor = DisabledColor;
			return;
		}
		if (bool_0)
		{
			if (bool_2)
			{
				BackColor = colselected;
				if (Iconimage_Selected != null)
				{
					limage.Image = Iconimage_Selected;
				}
				if (Iconimage_right_Selected != null)
				{
					rimage.Image = Iconimage_right_Selected;
				}
			}
			else
			{
				BackColor = colbackground;
				if (Iconimage_Selected != null)
				{
					limage.Image = image_1;
				}
				if (Iconimage_right_Selected != null)
				{
					rimage.Image = image_2;
				}
			}
		}
		else
		{
			BackColor = colbackground;
		}
		txttext.ForeColor = color_3;
		limage.BackColor = color_1;
	}

	private void BunifuFlatButton_MouseClick(object sender, MouseEventArgs e)
	{
		if (bool_1)
		{
			bool_2 = true;
			BackColor = colselected;
			method_5();
		}
	}

	private void method_3(object sender, PaintEventArgs e)
	{
	}

	private void BunifuFlatButton_Resize(object sender, EventArgs e)
	{
		if (limage.Image == null)
		{
			limage.Width = 0;
		}
		else
		{
			limage.Width = limage.Height;
		}
		if (rimage.Image == null)
		{
			rimage.Width = 0;
		}
		else
		{
			rimage.Width = rimage.Height;
		}
		rimage.Top = base.Height / 2 - rimage.Height / 2;
		limage.Top = rimage.Top;
		if (IconMarginLeft > 0)
		{
			limage.Left = IconMarginLeft;
		}
		else
		{
			limage.Left = limage.Top;
		}
		if (IconMarginRight > 0)
		{
			rimage.Left = IconMarginRight;
		}
		else
		{
			rimage.Left = base.Width - rimage.Width - rimage.Top;
		}
		txttext.Top = base.Height / 2 - txttext.Height / 2;
		method_0();
		Elipse.Apply(this, int_0);
	}

	private void txttext_Click(object sender, EventArgs e)
	{
		if (bool_1)
		{
			base.OnClick(e);
		}
	}

	private void txttext_MouseDown(object sender, MouseEventArgs e)
	{
		if (!bool_1)
		{
			return;
		}
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

	private void txttext_MouseUp(object sender, MouseEventArgs e)
	{
		if (!bool_1)
		{
			return;
		}
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

	private void txttext_DoubleClick(object sender, EventArgs e)
	{
		if (bool_1)
		{
			base.OnDoubleClick(e);
		}
	}

	private void BunifuFlatButton_DoubleClick(object sender, EventArgs e)
	{
	}

	private void limage_MouseDoubleClick(object sender, MouseEventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5()
	{
		foreach (Control control in base.Parent.Controls)
		{
			if (control.GetType() == typeof(BunifuFlatButton) && ((BunifuFlatButton)control).IsTab && ((BunifuFlatButton)control).Name != base.Name && base.Parent == ((BunifuFlatButton)control).Parent && ((BunifuFlatButton)control).Enabled)
			{
				((BunifuFlatButton)control).selected = false;
			}
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuFlatButton));
		this.imageList_0 = new System.Windows.Forms.ImageList(this.icontainer_0);
		this.limage = new System.Windows.Forms.PictureBox();
		this.rimage = new System.Windows.Forms.PictureBox();
		this.txttext = new Bunifu.Framework.UI.BunifuCustomLabel();
		((System.ComponentModel.ISupportInitialize)this.limage).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.rimage).BeginInit();
		base.SuspendLayout();
		this.imageList_0.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		this.imageList_0.ImageSize = new System.Drawing.Size(16, 16);
		this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
		this.limage.BackColor = System.Drawing.Color.Transparent;
		this.limage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.limage.Image = (System.Drawing.Image)resources.GetObject("limage.Image");
		this.limage.Location = new System.Drawing.Point(0, 0);
		this.limage.Name = "limage";
		this.limage.Size = new System.Drawing.Size(50, 48);
		this.limage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.limage.TabIndex = 1;
		this.limage.TabStop = false;
		this.limage.Click += new System.EventHandler(txttext_Click);
		this.limage.MouseClick += new System.Windows.Forms.MouseEventHandler(BunifuFlatButton_MouseClick);
		this.limage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(limage_MouseDoubleClick);
		this.limage.MouseDown += new System.Windows.Forms.MouseEventHandler(txttext_MouseDown);
		this.limage.MouseEnter += new System.EventHandler(BunifuFlatButton_MouseEnter);
		this.limage.MouseLeave += new System.EventHandler(BunifuFlatButton_MouseLeave);
		this.limage.MouseUp += new System.Windows.Forms.MouseEventHandler(txttext_MouseUp);
		this.rimage.BackColor = System.Drawing.Color.Transparent;
		this.rimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.rimage.Location = new System.Drawing.Point(191, 0);
		this.rimage.Name = "rimage";
		this.rimage.Size = new System.Drawing.Size(50, 48);
		this.rimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.rimage.TabIndex = 3;
		this.rimage.TabStop = false;
		this.rimage.Click += new System.EventHandler(txttext_Click);
		this.rimage.MouseDown += new System.Windows.Forms.MouseEventHandler(txttext_MouseDown);
		this.rimage.MouseUp += new System.Windows.Forms.MouseEventHandler(txttext_MouseUp);
		this.txttext.AutoEllipsis = true;
		this.txttext.BackColor = System.Drawing.Color.Transparent;
		this.txttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.txttext.ForeColor = System.Drawing.Color.White;
		this.txttext.Location = new System.Drawing.Point(50, 0);
		this.txttext.Name = "txttext";
		this.txttext.Size = new System.Drawing.Size(188, 48);
		this.txttext.TabIndex = 4;
		this.txttext.Text = "     Bunifu Flat Button";
		this.txttext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.txttext.Click += new System.EventHandler(txttext_Click);
		this.txttext.DoubleClick += new System.EventHandler(txttext_DoubleClick);
		this.txttext.MouseClick += new System.Windows.Forms.MouseEventHandler(BunifuFlatButton_MouseClick);
		this.txttext.MouseDown += new System.Windows.Forms.MouseEventHandler(txttext_MouseDown);
		this.txttext.MouseEnter += new System.EventHandler(BunifuFlatButton_MouseEnter);
		this.txttext.MouseLeave += new System.EventHandler(BunifuFlatButton_MouseLeave);
		this.txttext.MouseUp += new System.Windows.Forms.MouseEventHandler(txttext_MouseUp);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.SeaGreen;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.Controls.Add(this.limage);
		base.Controls.Add(this.rimage);
		base.Controls.Add(this.txttext);
		this.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DoubleBuffered = true;
		base.Name = "BunifuFlatButton";
		base.Size = new System.Drawing.Size(241, 48);
		base.Load += new System.EventHandler(BunifuFlatButton_Load);
		base.DoubleClick += new System.EventHandler(BunifuFlatButton_DoubleClick);
		base.MouseClick += new System.Windows.Forms.MouseEventHandler(BunifuFlatButton_MouseClick);
		base.MouseEnter += new System.EventHandler(BunifuFlatButton_MouseEnter);
		base.MouseLeave += new System.EventHandler(BunifuFlatButton_MouseLeave);
		base.Resize += new System.EventHandler(BunifuFlatButton_Resize);
		((System.ComponentModel.ISupportInitialize)this.limage).EndInit();
		((System.ComponentModel.ISupportInitialize)this.rimage).EndInit();
		base.ResumeLayout(false);
	}
}
