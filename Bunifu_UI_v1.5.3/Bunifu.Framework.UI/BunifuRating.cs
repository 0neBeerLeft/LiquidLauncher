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
[DefaultEvent("onValueChanged")]
[DebuggerStepThrough]
public class BunifuRating : UserControl
{
	private int int_0;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private IContainer icontainer_0;

	private PictureBox star1;

	private PictureBox star2;

	private PictureBox star3;

	private PictureBox star4;

	private PictureBox star5;

	private PictureBox off;

	private PictureBox on;

	private PictureBox offOrig;

	private PictureBox onOrig;

	public int Value
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value < 0 && value > 5)
			{
				throw new Exception("Invalid Value ( >=0 || <=5)");
			}
			int_0 = value;
			method_0();
			method_1();
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

	public BunifuRating()
	{
		InitializeComponent();
		OnForeColorChanged(null);
		_ = LicenseManager.UsageMode;
		BunifuCustomControl.initializeComponent(this);
	}

	private void BunifuRating_Resize(object sender, EventArgs e)
	{
		PictureBox pictureBox = star1;
		PictureBox pictureBox2 = star2;
		PictureBox pictureBox3 = star3;
		PictureBox pictureBox4 = star4;
		int num2 = (star5.Height = base.Height);
		int num4 = (pictureBox4.Height = num2);
		int num6 = (pictureBox3.Height = num4);
		int num8 = (pictureBox2.Height = num6);
		pictureBox.Height = num8;
		PictureBox pictureBox5 = star1;
		PictureBox pictureBox6 = star2;
		PictureBox pictureBox7 = star3;
		PictureBox pictureBox8 = star4;
		num2 = (star5.Width = base.Height);
		num4 = (pictureBox8.Width = num2);
		num6 = (pictureBox7.Width = num4);
		num8 = (pictureBox6.Width = num6);
		pictureBox5.Width = num8;
		int num13 = (base.Width - base.Height * 5) / 4;
		star2.Left = star1.Right + num13;
		star3.Left = star2.Right + num13;
		star4.Left = star3.Right + num13;
		star5.Left = star4.Right + num13;
	}

	private void BunifuRating_ForeColorChanged(object sender, EventArgs e)
	{
		on.Image = onOrig.Image;
		off.Image = offOrig.Image;
		on.Image = Bunifu.Framework.Lib.Graphics.OverlayColor(on.Image, ForeColor);
		off.Image = Bunifu.Framework.Lib.Graphics.OverlayColor(off.Image, ForeColor);
		if (star1.Tag.ToString() == "on")
		{
			star1.Image = on.Image;
		}
		else
		{
			star1.Image = off.Image;
		}
		if (star2.Tag.ToString() == "on")
		{
			star2.Image = on.Image;
		}
		else
		{
			star2.Image = off.Image;
		}
		if (star3.Tag.ToString() == "on")
		{
			star3.Image = on.Image;
		}
		else
		{
			star3.Image = off.Image;
		}
		if (star4.Tag.ToString() == "on")
		{
			star4.Image = on.Image;
		}
		else
		{
			star4.Image = off.Image;
		}
		if (star5.Tag.ToString() == "on")
		{
			star5.Image = on.Image;
		}
		else
		{
			star5.Image = off.Image;
		}
	}

	private void method_0()
	{
		switch (int_0)
		{
		case 0:
			star1.Image = off.Image;
			star2.Image = off.Image;
			star3.Image = off.Image;
			star4.Image = off.Image;
			star5.Image = off.Image;
			break;
		case 1:
			star1.Image = on.Image;
			star2.Image = off.Image;
			star3.Image = off.Image;
			star4.Image = off.Image;
			star5.Image = off.Image;
			break;
		case 2:
			star1.Image = on.Image;
			star2.Image = on.Image;
			star3.Image = off.Image;
			star4.Image = off.Image;
			star5.Image = off.Image;
			break;
		case 3:
			star1.Image = on.Image;
			star2.Image = on.Image;
			star3.Image = on.Image;
			star4.Image = off.Image;
			star5.Image = off.Image;
			break;
		case 4:
			star1.Image = on.Image;
			star2.Image = on.Image;
			star3.Image = on.Image;
			star4.Image = on.Image;
			star5.Image = off.Image;
			break;
		case 5:
			star1.Image = on.Image;
			star2.Image = on.Image;
			star3.Image = on.Image;
			star4.Image = on.Image;
			star5.Image = on.Image;
			break;
		}
	}

	private void star5_Click(object sender, EventArgs e)
	{
		int num = int.Parse(((PictureBox)sender).Tag.ToString());
		if (((PictureBox)sender).Image == on.Image)
		{
			int_0 = num - 1;
			method_0();
			method_1();
		}
		else
		{
			int_0 = num;
			method_0();
			method_1();
		}
	}

	private void method_1()
	{
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

	private void BunifuRating_Load(object sender, EventArgs e)
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuRating));
		this.star1 = new System.Windows.Forms.PictureBox();
		this.star2 = new System.Windows.Forms.PictureBox();
		this.star3 = new System.Windows.Forms.PictureBox();
		this.star4 = new System.Windows.Forms.PictureBox();
		this.star5 = new System.Windows.Forms.PictureBox();
		this.off = new System.Windows.Forms.PictureBox();
		this.on = new System.Windows.Forms.PictureBox();
		this.offOrig = new System.Windows.Forms.PictureBox();
		this.onOrig = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.star1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.star2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.star3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.star4).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.star5).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.off).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.on).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.offOrig).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.onOrig).BeginInit();
		base.SuspendLayout();
		this.star1.BackColor = System.Drawing.Color.Transparent;
		this.star1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.star1.Image = (System.Drawing.Image)resources.GetObject("star1.Image");
		this.star1.Location = new System.Drawing.Point(0, 1);
		this.star1.Name = "star1";
		this.star1.Size = new System.Drawing.Size(50, 46);
		this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.star1.TabIndex = 0;
		this.star1.TabStop = false;
		this.star1.Tag = "1";
		this.star1.Click += new System.EventHandler(star5_Click);
		this.star2.BackColor = System.Drawing.Color.Transparent;
		this.star2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.star2.Image = (System.Drawing.Image)resources.GetObject("star2.Image");
		this.star2.Location = new System.Drawing.Point(66, 1);
		this.star2.Name = "star2";
		this.star2.Size = new System.Drawing.Size(50, 46);
		this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.star2.TabIndex = 1;
		this.star2.TabStop = false;
		this.star2.Tag = "2";
		this.star2.Click += new System.EventHandler(star5_Click);
		this.star3.BackColor = System.Drawing.Color.Transparent;
		this.star3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.star3.Image = (System.Drawing.Image)resources.GetObject("star3.Image");
		this.star3.Location = new System.Drawing.Point(132, 1);
		this.star3.Name = "star3";
		this.star3.Size = new System.Drawing.Size(50, 46);
		this.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.star3.TabIndex = 2;
		this.star3.TabStop = false;
		this.star3.Tag = "3";
		this.star3.Click += new System.EventHandler(star5_Click);
		this.star4.BackColor = System.Drawing.Color.Transparent;
		this.star4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.star4.Image = (System.Drawing.Image)resources.GetObject("star4.Image");
		this.star4.Location = new System.Drawing.Point(198, 1);
		this.star4.Name = "star4";
		this.star4.Size = new System.Drawing.Size(50, 46);
		this.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.star4.TabIndex = 3;
		this.star4.TabStop = false;
		this.star4.Tag = "4";
		this.star4.Click += new System.EventHandler(star5_Click);
		this.star5.BackColor = System.Drawing.Color.Transparent;
		this.star5.Cursor = System.Windows.Forms.Cursors.Hand;
		this.star5.Image = (System.Drawing.Image)resources.GetObject("star5.Image");
		this.star5.Location = new System.Drawing.Point(264, 1);
		this.star5.Name = "star5";
		this.star5.Size = new System.Drawing.Size(50, 46);
		this.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.star5.TabIndex = 4;
		this.star5.TabStop = false;
		this.star5.Tag = "5";
		this.star5.Click += new System.EventHandler(star5_Click);
		this.off.Cursor = System.Windows.Forms.Cursors.Hand;
		this.off.Image = (System.Drawing.Image)resources.GetObject("off.Image");
		this.off.Location = new System.Drawing.Point(44, 46);
		this.off.Name = "off";
		this.off.Size = new System.Drawing.Size(82, 36);
		this.off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.off.TabIndex = 6;
		this.off.TabStop = false;
		this.off.Tag = "false";
		this.off.Visible = false;
		this.on.Cursor = System.Windows.Forms.Cursors.Hand;
		this.on.Image = (System.Drawing.Image)resources.GetObject("on.Image");
		this.on.Location = new System.Drawing.Point(-22, 46);
		this.on.Name = "on";
		this.on.Size = new System.Drawing.Size(82, 36);
		this.on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.on.TabIndex = 5;
		this.on.TabStop = false;
		this.on.Tag = "false";
		this.on.Visible = false;
		this.offOrig.Cursor = System.Windows.Forms.Cursors.Hand;
		this.offOrig.Image = (System.Drawing.Image)resources.GetObject("offOrig.Image");
		this.offOrig.Location = new System.Drawing.Point(122, 51);
		this.offOrig.Name = "offOrig";
		this.offOrig.Size = new System.Drawing.Size(82, 36);
		this.offOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.offOrig.TabIndex = 8;
		this.offOrig.TabStop = false;
		this.offOrig.Tag = "false";
		this.offOrig.Visible = false;
		this.onOrig.Cursor = System.Windows.Forms.Cursors.Hand;
		this.onOrig.Image = (System.Drawing.Image)resources.GetObject("onOrig.Image");
		this.onOrig.Location = new System.Drawing.Point(44, 58);
		this.onOrig.Name = "onOrig";
		this.onOrig.Size = new System.Drawing.Size(82, 36);
		this.onOrig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.onOrig.TabIndex = 7;
		this.onOrig.TabStop = false;
		this.onOrig.Tag = "false";
		this.onOrig.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		base.Controls.Add(this.offOrig);
		base.Controls.Add(this.onOrig);
		base.Controls.Add(this.off);
		base.Controls.Add(this.on);
		base.Controls.Add(this.star5);
		base.Controls.Add(this.star4);
		base.Controls.Add(this.star3);
		base.Controls.Add(this.star2);
		base.Controls.Add(this.star1);
		this.ForeColor = System.Drawing.Color.SeaGreen;
		base.Name = "BunifuRating";
		base.Size = new System.Drawing.Size(316, 50);
		base.Load += new System.EventHandler(BunifuRating_Load);
		base.ForeColorChanged += new System.EventHandler(BunifuRating_ForeColorChanged);
		base.Resize += new System.EventHandler(BunifuRating_Resize);
		((System.ComponentModel.ISupportInitialize)this.star1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.star2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.star3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.star4).EndInit();
		((System.ComponentModel.ISupportInitialize)this.star5).EndInit();
		((System.ComponentModel.ISupportInitialize)this.off).EndInit();
		((System.ComponentModel.ISupportInitialize)this.on).EndInit();
		((System.ComponentModel.ISupportInitialize)this.offOrig).EndInit();
		((System.ComponentModel.ISupportInitialize)this.onOrig).EndInit();
		base.ResumeLayout(false);
	}
}
