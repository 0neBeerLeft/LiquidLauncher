using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DebuggerStepThrough]
[DefaultEvent("Click")]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuImageButton : PictureBox
{
	private int int_0 = 10;

	private Image image_0;

	private Image image_1;

	private IContainer icontainer_0;

	public int Zoom
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public Image ImageActive
	{
		get
		{
			return image_0;
		}
		set
		{
			image_0 = value;
		}
	}

	public BunifuImageButton()
	{
		method_0();
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		if (image_0 != null)
		{
			image_1 = base.Image;
			base.Image = image_0;
		}
		Styles.ZoomIn(this, int_0);
		base.OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		if (image_0 != null)
		{
			base.Image = image_1;
		}
		Styles.ZoomOut(this);
		base.OnMouseLeave(e);
	}

	protected override void OnClick(EventArgs e)
	{
		if (image_0 != null)
		{
			base.Image = image_1;
		}
		Styles.ZoomOut(this);
		base.OnClick(e);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_0()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(BunifuImageButton));
		((ISupportInitialize)this).BeginInit();
		SuspendLayout();
		BackColor = Color.SeaGreen;
		base.Image = (Image)componentResourceManager.GetObject("$this.Image");
		base.Size = new Size(71, 71);
		base.SizeMode = PictureBoxSizeMode.Zoom;
		((ISupportInitialize)this).EndInit();
		ResumeLayout(performLayout: false);
	}
}
