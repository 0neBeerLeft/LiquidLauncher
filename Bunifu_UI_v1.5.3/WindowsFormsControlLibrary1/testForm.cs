using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace WindowsFormsControlLibrary1;

public class testForm : Form
{
	private bool bool_0;

	private int int_0 = 1;

	private Drag drag_0 = new Drag();

	private IContainer icontainer_0;

	private BunifuMetroTextbox bunifuMetroTextbox_0;

	private BunifuTrackbar bunifuTrackbar_0;

	private BunifuVTrackbar bunifuVTrackbar_0;

	private Label label1;

	private BunifuGauge bunifuGauge1;

	private Button button1;

	private Timer timer_0;

	private BackgroundWorker backgroundWorker_0;

	private BunifuFormFadeTransition bunifuFormFadeTransition_0;

	private BunifuFlatButton bunifuFlatButton3;

	private BunifuFlatButton bunifuFlatButton2;

	private BunifuFlatButton bunifuFlatButton4;

	private BunifuiOSSwitch bunifuiOSSwitch1;

	private BunifuTrackbar bunifuTrackbar2;

	private Label label2;

	public testForm()
	{
		InitializeComponent();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void testForm_Paint(object sender, PaintEventArgs e)
	{
	}

	private void method_1(object sender, PaintEventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
		Close();
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
	}

	private void method_8(object sender, EventArgs e)
	{
	}

	private void method_9(object sender, EventArgs e)
	{
	}

	private void method_10(object sender, EventArgs e)
	{
	}

	private void testForm_Load(object sender, EventArgs e)
	{
	}

	private void method_11(object sender, EventArgs e)
	{
	}

	private void method_12(object sender, EventArgs e)
	{
		MessageBox.Show("Hello World");
	}

	private void method_13(object sender, EventArgs e)
	{
	}

	private void method_14(object sender, EventArgs e)
	{
	}

	private void method_15(object sender, EventArgs e)
	{
		MessageBox.Show("Yeeeeah");
	}

	private void method_16(object sender, EventArgs e)
	{
	}

	private void method_17(object sender, MouseEventArgs e)
	{
		drag_0.Grab((Control)sender);
	}

	private void method_18(object sender, MouseEventArgs e)
	{
		drag_0.Release();
	}

	private void method_19(object sender, EventArgs e)
	{
	}

	private void bunifuGauge1_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
	}

	private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
	}

	private void bunifuTrackbar2_ValueChanged(object sender, EventArgs e)
	{
		label1.Text = bunifuTrackbar2.Value.ToString();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormsControlLibrary1.testForm));
		this.label1 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
		this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
		this.label2 = new System.Windows.Forms.Label();
		this.bunifuTrackbar2 = new Bunifu.Framework.UI.BunifuTrackbar();
		this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
		this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
		this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
		this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
		this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
		this.bunifuFormFadeTransition_0 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.icontainer_0);
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(171, 275);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(35, 13);
		this.label1.TabIndex = 1;
		this.label1.Text = "label1";
		this.button1.Location = new System.Drawing.Point(43, 145);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 4;
		this.button1.Text = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.timer_0.Tick += new System.EventHandler(timer_0_Tick);
		this.backgroundWorker_0.WorkerReportsProgress = true;
		this.backgroundWorker_0.WorkerSupportsCancellation = true;
		this.backgroundWorker_0.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_0_DoWork);
		this.backgroundWorker_0.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(backgroundWorker_0_ProgressChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(624, 275);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(35, 13);
		this.label2.TabIndex = 17;
		this.label2.Text = "label2";
		this.bunifuTrackbar2.BackColor = System.Drawing.Color.Transparent;
		this.bunifuTrackbar2.BackgroudColor = System.Drawing.Color.DarkGray;
		this.bunifuTrackbar2.BorderRadius = 0;
		this.bunifuTrackbar2.IndicatorColor = System.Drawing.Color.SeaGreen;
		this.bunifuTrackbar2.Location = new System.Drawing.Point(211, 197);
		this.bunifuTrackbar2.MaximumValue = 100;
		this.bunifuTrackbar2.MinimumValue = 10;
		this.bunifuTrackbar2.Name = "bunifuTrackbar2";
		this.bunifuTrackbar2.Size = new System.Drawing.Size(415, 28);
		this.bunifuTrackbar2.SliderRadius = 0;
		this.bunifuTrackbar2.TabIndex = 16;
		this.bunifuTrackbar2.Value = 10;
		this.bunifuTrackbar2.ValueChanged += new System.EventHandler(bunifuTrackbar2_ValueChanged);
		this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
		this.bunifuiOSSwitch1.BackgroundImage = (System.Drawing.Image)resources.GetObject("bunifuiOSSwitch1.BackgroundImage");
		this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuiOSSwitch1.Location = new System.Drawing.Point(357, 89);
		this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
		this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
		this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(71, 202, 94);
		this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
		this.bunifuiOSSwitch1.TabIndex = 15;
		this.bunifuiOSSwitch1.Value = true;
		this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Red;
		this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.bunifuFlatButton3.BorderRadius = 0;
		this.bunifuFlatButton3.ButtonText = "bunifuFlatButton3";
		this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
		this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
		this.bunifuFlatButton3.Iconimage = (System.Drawing.Image)resources.GetObject("bunifuFlatButton3.Iconimage");
		this.bunifuFlatButton3.Iconimage_right = null;
		this.bunifuFlatButton3.Iconimage_right_Selected = null;
		this.bunifuFlatButton3.Iconimage_Selected = null;
		this.bunifuFlatButton3.IconMarginLeft = 0;
		this.bunifuFlatButton3.IconMarginRight = 0;
		this.bunifuFlatButton3.IconRightVisible = true;
		this.bunifuFlatButton3.IconRightZoom = 0.0;
		this.bunifuFlatButton3.IconVisible = true;
		this.bunifuFlatButton3.IconZoom = 90.0;
		this.bunifuFlatButton3.IsTab = true;
		this.bunifuFlatButton3.Location = new System.Drawing.Point(447, 22);
		this.bunifuFlatButton3.Name = "bunifuFlatButton3";
		this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
		this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
		this.bunifuFlatButton3.selected = false;
		this.bunifuFlatButton3.Size = new System.Drawing.Size(195, 42);
		this.bunifuFlatButton3.TabIndex = 14;
		this.bunifuFlatButton3.Text = "bunifuFlatButton3";
		this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
		this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Red;
		this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.bunifuFlatButton2.BorderRadius = 0;
		this.bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
		this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
		this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
		this.bunifuFlatButton2.Iconimage = (System.Drawing.Image)resources.GetObject("bunifuFlatButton2.Iconimage");
		this.bunifuFlatButton2.Iconimage_right = null;
		this.bunifuFlatButton2.Iconimage_right_Selected = null;
		this.bunifuFlatButton2.Iconimage_Selected = null;
		this.bunifuFlatButton2.IconMarginLeft = 0;
		this.bunifuFlatButton2.IconMarginRight = 0;
		this.bunifuFlatButton2.IconRightVisible = true;
		this.bunifuFlatButton2.IconRightZoom = 0.0;
		this.bunifuFlatButton2.IconVisible = true;
		this.bunifuFlatButton2.IconZoom = 90.0;
		this.bunifuFlatButton2.IsTab = true;
		this.bunifuFlatButton2.Location = new System.Drawing.Point(246, 22);
		this.bunifuFlatButton2.Name = "bunifuFlatButton2";
		this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
		this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
		this.bunifuFlatButton2.selected = false;
		this.bunifuFlatButton2.Size = new System.Drawing.Size(195, 42);
		this.bunifuFlatButton2.TabIndex = 13;
		this.bunifuFlatButton2.Text = "bunifuFlatButton2";
		this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
		this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuFlatButton4.Activecolor = System.Drawing.Color.Red;
		this.bunifuFlatButton4.BackColor = System.Drawing.Color.Red;
		this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.bunifuFlatButton4.BorderRadius = 0;
		this.bunifuFlatButton4.ButtonText = "bunifuFlatButton4";
		this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
		this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
		this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
		this.bunifuFlatButton4.Iconimage = (System.Drawing.Image)resources.GetObject("bunifuFlatButton4.Iconimage");
		this.bunifuFlatButton4.Iconimage_right = null;
		this.bunifuFlatButton4.Iconimage_right_Selected = null;
		this.bunifuFlatButton4.Iconimage_Selected = null;
		this.bunifuFlatButton4.IconMarginLeft = 0;
		this.bunifuFlatButton4.IconMarginRight = 0;
		this.bunifuFlatButton4.IconRightVisible = true;
		this.bunifuFlatButton4.IconRightZoom = 0.0;
		this.bunifuFlatButton4.IconVisible = true;
		this.bunifuFlatButton4.IconZoom = 90.0;
		this.bunifuFlatButton4.IsTab = true;
		this.bunifuFlatButton4.Location = new System.Drawing.Point(52, 22);
		this.bunifuFlatButton4.Name = "bunifuFlatButton4";
		this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
		this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
		this.bunifuFlatButton4.selected = true;
		this.bunifuFlatButton4.Size = new System.Drawing.Size(188, 42);
		this.bunifuFlatButton4.TabIndex = 12;
		this.bunifuFlatButton4.Text = "bunifuFlatButton4";
		this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
		this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.bunifuGauge1.BackgroundImage = (System.Drawing.Image)resources.GetObject("bunifuGauge1.BackgroundImage");
		this.bunifuGauge1.Font = new System.Drawing.Font("Century Gothic", 15.75f);
		this.bunifuGauge1.Location = new System.Drawing.Point(736, 15);
		this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
		this.bunifuGauge1.Name = "bunifuGauge1";
		this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.Gray;
		this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.SeaGreen;
		this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.Tomato;
		this.bunifuGauge1.Size = new System.Drawing.Size(174, 117);
		this.bunifuGauge1.Suffix = "k";
		this.bunifuGauge1.TabIndex = 3;
		this.bunifuGauge1.Thickness = 30;
		this.bunifuGauge1.Value = 0;
		this.bunifuGauge1.Load += new System.EventHandler(bunifuGauge1_Load);
		this.bunifuFormFadeTransition_0.Delay = 1;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(1079, 579);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.bunifuTrackbar2);
		base.Controls.Add(this.bunifuiOSSwitch1);
		base.Controls.Add(this.bunifuFlatButton3);
		base.Controls.Add(this.bunifuFlatButton2);
		base.Controls.Add(this.bunifuFlatButton4);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.bunifuGauge1);
		base.Controls.Add(this.label1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Name = "testForm";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		base.Load += new System.EventHandler(testForm_Load);
		base.Paint += new System.Windows.Forms.PaintEventHandler(testForm_Paint);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
