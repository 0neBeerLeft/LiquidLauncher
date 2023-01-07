using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DefaultEvent("OnTextChange")]
[DebuggerStepThrough]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuTextbox : UserControl
{
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	[CompilerGenerated]
	private EventHandler eventHandler_2;

	[CompilerGenerated]
	private EventHandler eventHandler_3;

	private IContainer icontainer_0;

	private PictureBox _Picture;

	public TextBox _TextBox;

	public Image Icon
	{
		get
		{
			return _Picture.Image;
		}
		set
		{
			_Picture.Image = value;
			_Picture.Image = Bunifu.Framework.Lib.Graphics.OverlayColor(_Picture.Image, ForeColor);
		}
	}

	public string text
	{
		get
		{
			return _TextBox.Text;
		}
		set
		{
			_TextBox.Text = value;
		}
	}

	public event EventHandler OnTextChange
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

	public new event EventHandler KeyDown
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

	public new event EventHandler KeyPress
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

	public new event EventHandler KeyUp
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

	public BunifuTextbox()
	{
		InitializeComponent();
		_Picture.Top = base.Height / 2 - _Picture.Height / 2;
		_TextBox.Top = base.Height / 2 - _TextBox.Height / 2;
		_TextBox.Width = base.Width - _TextBox.Left - 10;
		BackgroundImage = Bunifu.Framework.Lib.Graphics.OverlayColor(BackgroundImage, ForeColor);
		_Picture.Image = Bunifu.Framework.Lib.Graphics.OverlayColor(_Picture.Image, ForeColor);
		BunifuCustomControl.initializeComponent(this);
	}

	private void BunifuTextbox_ForeColorChanged(object sender, EventArgs e)
	{
		_TextBox.ForeColor = ForeColor;
		BackgroundImage = Bunifu.Framework.Lib.Graphics.OverlayColor(BackgroundImage, ForeColor);
		_Picture.Image = Bunifu.Framework.Lib.Graphics.OverlayColor(_Picture.Image, ForeColor);
	}

	private void BunifuTextbox_Resize(object sender, EventArgs e)
	{
		_Picture.Top = base.Height / 2 - _Picture.Height / 2;
		_TextBox.Top = base.Height / 2 - _TextBox.Height / 2;
		_TextBox.Width = base.Width - _TextBox.Left - 10;
	}

	private void BunifuTextbox_BackColorChanged(object sender, EventArgs e)
	{
		_TextBox.BackColor = BackColor;
	}

	private void _TextBox_TextChanged(object sender, EventArgs e)
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

	private void BunifuTextbox_Load(object sender, EventArgs e)
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

	private void _TextBox_KeyDown(object sender, KeyEventArgs e)
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

	private void _TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

	private void _TextBox_KeyUp(object sender, KeyEventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuTextbox));
		this._TextBox = new System.Windows.Forms.TextBox();
		this._Picture = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this._Picture).BeginInit();
		base.SuspendLayout();
		this._TextBox.BackColor = System.Drawing.Color.Silver;
		this._TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this._TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11f);
		this._TextBox.ForeColor = System.Drawing.Color.SeaGreen;
		this._TextBox.Location = new System.Drawing.Point(40, 13);
		this._TextBox.Multiline = true;
		this._TextBox.Name = "_TextBox";
		this._TextBox.Size = new System.Drawing.Size(195, 20);
		this._TextBox.TabIndex = 0;
		this._TextBox.Text = "Bunifu TextBox";
		this._TextBox.TextChanged += new System.EventHandler(_TextBox_TextChanged);
		this._TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(_TextBox_KeyDown);
		this._TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_TextBox_KeyPress);
		this._TextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(_TextBox_KeyUp);
		this._Picture.BackColor = System.Drawing.Color.Transparent;
		this._Picture.Image = (System.Drawing.Image)resources.GetObject("_Picture.Image");
		this._Picture.Location = new System.Drawing.Point(9, 7);
		this._Picture.Name = "_Picture";
		this._Picture.Size = new System.Drawing.Size(23, 25);
		this._Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this._Picture.TabIndex = 1;
		this._Picture.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Silver;
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.Controls.Add(this._Picture);
		base.Controls.Add(this._TextBox);
		this.DoubleBuffered = true;
		this.ForeColor = System.Drawing.Color.SeaGreen;
		base.Name = "BunifuTextbox";
		base.Size = new System.Drawing.Size(250, 42);
		base.Load += new System.EventHandler(BunifuTextbox_Load);
		base.BackColorChanged += new System.EventHandler(BunifuTextbox_BackColorChanged);
		base.ForeColorChanged += new System.EventHandler(BunifuTextbox_ForeColorChanged);
		base.Resize += new System.EventHandler(BunifuTextbox_Resize);
		((System.ComponentModel.ISupportInitialize)this._Picture).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
