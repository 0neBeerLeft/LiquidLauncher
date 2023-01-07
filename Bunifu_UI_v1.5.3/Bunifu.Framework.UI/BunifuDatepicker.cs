using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DebuggerStepThrough]
[DefaultEvent("onValueChanged")]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuDatepicker : UserControl
{
	private DateTime dateTime_0;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private int int_0;

	private IContainer icontainer_0;

	public BunifuFlatButton Style;

	private DateTimePicker datp;

	public DateTime Value
	{
		get
		{
			return dateTime_0;
		}
		set
		{
			dateTime_0 = value;
			datp.Value = dateTime_0;
			Style.ButtonText = datp.Text;
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

	public DateTimePickerFormat Format
	{
		get
		{
			return datp.Format;
		}
		set
		{
			datp.Format = value;
			Style.ButtonText = datp.Text;
			dateTime_0 = datp.Value;
		}
	}

	public string FormatCustom
	{
		get
		{
			return datp.CustomFormat;
		}
		set
		{
			datp.CustomFormat = value;
			Style.ButtonText = datp.Text;
			dateTime_0 = datp.Value;
		}
	}

	public event EventHandler onValueChanged
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

	public BunifuDatepicker()
	{
		InitializeComponent();
		if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
		{
			datp.Visible = false;
		}
		else
		{
			datp.Visible = true;
		}
		Style.Text = datp.Value.ToLongDateString();
		OnResize(null);
		dateTime_0 = datp.Value;
		Style.ButtonText = datp.Text;
		dateTime_0 = datp.Value;
		BunifuCustomControl.initializeComponent(this);
	}

	private void BunifuDatepicker_Resize(object sender, EventArgs e)
	{
		datp.Width = base.Width - datp.Left - 50;
		datp.Left = 0;
		datp.Top = Style.Top + Style.Height - datp.Height;
		Elipse.Apply(this, int_0);
	}

	private void Style_Click(object sender, EventArgs e)
	{
		datp.Select();
		SendKeys.Send("%{DOWN}");
	}

	private void BunifuDatepicker_FontChanged(object sender, EventArgs e)
	{
		Style.Font = Font;
	}

	private void BunifuDatepicker_ForeColorChanged(object sender, EventArgs e)
	{
		Style.Textcolor = ForeColor;
		Style.OnHoverTextColor = ForeColor;
		Style.Iconimage_right = Bunifu.Framework.Lib.Graphics.OverlayColor(Style.Iconimage_right, ForeColor);
		Style.Iconimage = Bunifu.Framework.Lib.Graphics.OverlayColor(Style.Iconimage, ForeColor);
	}

	private void datp_ValueChanged(object sender, EventArgs e)
	{
		Style.ButtonText = datp.Text;
		dateTime_0 = datp.Value;
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

	private void BunifuDatepicker_BackColorChanged(object sender, EventArgs e)
	{
		Style.Activecolor = BackColor;
		Style.Normalcolor = BackColor;
		int r = BackColor.R;
		r = ((r + 10 <= 255) ? (r + 10) : 255);
		int g = BackColor.G;
		g = ((g + 10 <= 255) ? (g + 10) : 255);
		int b = BackColor.B;
		b = ((b + 10 <= 255) ? (b + 10) : 255);
		Style.OnHovercolor = Color.FromArgb(r, g, b);
	}

	private void BunifuDatepicker_Load(object sender, EventArgs e)
	{
		Style.Text = datp.Text;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuDatepicker));
		this.datp = new System.Windows.Forms.DateTimePicker();
		this.Style = new Bunifu.Framework.UI.BunifuFlatButton();
		base.SuspendLayout();
		this.datp.Location = new System.Drawing.Point(3, 13);
		this.datp.Name = "datp";
		this.datp.Size = new System.Drawing.Size(241, 20);
		this.datp.TabIndex = 3;
		this.datp.ValueChanged += new System.EventHandler(datp_ValueChanged);
		this.Style.Activecolor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.Style.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.Style.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Style.BorderRadius = 0;
		this.Style.ButtonText = "BunifuCalendar";
		this.Style.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Style.DisabledColor = System.Drawing.Color.Gray;
		this.Style.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Style.Iconcolor = System.Drawing.Color.Transparent;
		this.Style.Iconimage = (System.Drawing.Image)resources.GetObject("Style.Iconimage");
		this.Style.Iconimage_right = (System.Drawing.Image)resources.GetObject("Style.Iconimage_right");
		this.Style.Iconimage_right_Selected = null;
		this.Style.Iconimage_Selected = null;
		this.Style.IconRightVisible = true;
		this.Style.IconRightZoom = 0.0;
		this.Style.IconVisible = true;
		this.Style.IconZoom = 100.0;
		this.Style.IsTab = false;
		this.Style.Location = new System.Drawing.Point(0, 0);
		this.Style.Name = "Style";
		this.Style.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.Style.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
		this.Style.OnHoverTextColor = System.Drawing.Color.White;
		this.Style.selected = false;
		this.Style.Size = new System.Drawing.Size(303, 36);
		this.Style.TabIndex = 2;
		this.Style.Text = "BunifuCalendar";
		this.Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Style.Textcolor = System.Drawing.Color.White;
		this.Style.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Style.Click += new System.EventHandler(Style_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.SeaGreen;
		base.Controls.Add(this.Style);
		base.Controls.Add(this.datp);
		this.ForeColor = System.Drawing.Color.White;
		base.Name = "BunifuDatepicker";
		base.Size = new System.Drawing.Size(303, 36);
		base.Load += new System.EventHandler(BunifuDatepicker_Load);
		base.BackColorChanged += new System.EventHandler(BunifuDatepicker_BackColorChanged);
		base.FontChanged += new System.EventHandler(BunifuDatepicker_FontChanged);
		base.ForeColorChanged += new System.EventHandler(BunifuDatepicker_ForeColorChanged);
		base.Resize += new System.EventHandler(BunifuDatepicker_Resize);
		base.ResumeLayout(false);
	}
}
