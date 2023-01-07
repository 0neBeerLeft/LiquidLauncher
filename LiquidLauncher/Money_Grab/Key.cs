using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DiscordRpcDemo;
using Money_Grab.Properties;

namespace Money_Grab;

public class Key : Form
{
	private DiscordRpc.EventHandlers handlers;

	private DiscordRpc.RichPresence presence;

	public string LauncherKey = "";

	private WebClient wc = new WebClient();

	private IContainer components;

	private Timer timer1;

	private BunifuDragControl bunifuDragControl1;

	private BunifuElipse bunifuElipse1;

	private BunifuElipse bunifuElipse2;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Button button2;

	private Button button1;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

	private Button button3;

	private Label label3;

	public Key()
	{
		InitializeComponent();
	}

	private void label1_Click(object sender, EventArgs e)
	{
		try
		{
			Application.ExitThread();
		}
		catch (Exception)
		{
			Environment.Exit(0);
		}
	}

	private void Key_Load(object sender, EventArgs e)
	{
		label3.Text = wc.DownloadString("https://pastebin.com/raw/Xmi0Ktq4");
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		handlers = default(DiscordRpc.EventHandlers);
		DiscordRpc.Initialize("933094634903728200", ref handlers, autoRegister: true, null);
		handlers = default(DiscordRpc.EventHandlers);
		DiscordRpc.Initialize("933094634903728200", ref handlers, autoRegister: true, null);
		presence.details = "Hertz Menu for GTA 5 Online";
		presence.largeImageKey = "1";
		DiscordRpc.UpdatePresence(ref presence);
	}

	private void button3_Click(object sender, EventArgs e)
	{
		LauncherKey = wc.DownloadString("https://pastebin.com/raw/fjyPzznU");
		if (textBox1.Text == LauncherKey)
		{
			new Form1().Show();
			Hide();
		}
		else
		{
			MessageBox.Show("Key Is Invalid. Press GET KEY to get the newest one", "Liquid");
		}
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void bunifuCustomLabel1_Click(object sender, EventArgs e)
	{
	}

	private void bunifuCustomLabel2_Click(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click_1(object sender, EventArgs e)
	{
	}

	private void button2_Click_1(object sender, EventArgs e)
	{
		Process.Start("https://skeygithub.github.io/liquid/");
	}

	private void label2_Click_2(object sender, EventArgs e)
	{
		Application.Exit();
		Environment.Exit(1);
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		LauncherKey = wc.DownloadString("https://pastebin.com/raw/8zjgNjpM");
		if (textBox1.Text == LauncherKey)
		{
			new Form1().Show();
			Hide();
		}
		else
		{
			MessageBox.Show("Key Is Invalid. Press GET KEY to get the newest one", "Liquid");
		}
	}

	private void label3_Click_1(object sender, EventArgs e)
	{
	}

	private void button3_Click_1(object sender, EventArgs e)
	{
		Process.Start("https://discord.gg/3pc3Wpja6V");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Money_Grab.Key));
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
		this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
		this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.pictureBox2 = new System.Windows.Forms.PictureBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.button1 = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.button3 = new System.Windows.Forms.Button();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
		base.SuspendLayout();
		this.timer1.Enabled = true;
		this.timer1.Interval = 1;
		this.bunifuDragControl1.Fixed = true;
		this.bunifuDragControl1.Horizontal = true;
		this.bunifuDragControl1.TargetControl = this;
		this.bunifuDragControl1.Vertical = true;
		this.bunifuElipse1.ElipseRadius = 8;
		this.bunifuElipse1.TargetControl = this;
		this.bunifuElipse2.ElipseRadius = 7;
		this.bunifuElipse2.TargetControl = this;
		this.pictureBox1.Image = Money_Grab.Properties.Resources.liquidlogopink;
		this.pictureBox1.Location = new System.Drawing.Point(104, 12);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(144, 117);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		this.pictureBox2.Image = Money_Grab.Properties.Resources.lock_2;
		this.pictureBox2.Location = new System.Drawing.Point(21, 205);
		this.pictureBox2.Name = "pictureBox2";
		this.pictureBox2.Size = new System.Drawing.Size(21, 20);
		this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox2.TabIndex = 1;
		this.pictureBox2.TabStop = false;
		this.textBox1.Location = new System.Drawing.Point(57, 205);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new System.Drawing.Size(288, 20);
		this.textBox1.TabIndex = 2;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(18, 186);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(126, 16);
		this.label1.TabIndex = 3;
		this.label1.Text = "Enter the Key Below";
		this.button1.BackColor = System.Drawing.Color.Blue;
		this.button1.Font = new System.Drawing.Font("Virgo 01", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button1.ForeColor = System.Drawing.Color.White;
		this.button1.Location = new System.Drawing.Point(21, 231);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(173, 46);
		this.button1.TabIndex = 4;
		this.button1.Text = "Log In";
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click_1);
		this.button2.BackColor = System.Drawing.Color.Blue;
		this.button2.Font = new System.Drawing.Font("Virgo 01", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button2.ForeColor = System.Drawing.Color.White;
		this.button2.Location = new System.Drawing.Point(21, 308);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(173, 46);
		this.button2.TabIndex = 5;
		this.button2.Text = "Get Key ";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new System.EventHandler(button2_Click_1);
		this.button3.BackColor = System.Drawing.Color.Blue;
		this.button3.Font = new System.Drawing.Font("Virgo 01", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.button3.ForeColor = System.Drawing.Color.White;
		this.button3.Location = new System.Drawing.Point(21, 387);
		this.button3.Name = "button3";
		this.button3.Size = new System.Drawing.Size(173, 46);
		this.button3.TabIndex = 6;
		this.button3.Text = "Join Discord";
		this.button3.UseVisualStyleBackColor = false;
		this.button3.Click += new System.EventHandler(button3_Click_1);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.Location = new System.Drawing.Point(331, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(25, 24);
		this.label2.TabIndex = 7;
		this.label2.Text = "X";
		this.label2.Click += new System.EventHandler(label2_Click_2);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(3, 8);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(48, 13);
		this.label3.TabIndex = 8;
		this.label3.Text = "Version: ";
		this.label3.Click += new System.EventHandler(label3_Click_1);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(358, 456);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.button3);
		base.Controls.Add(this.button2);
		base.Controls.Add(this.button1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.pictureBox2);
		base.Controls.Add(this.pictureBox1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Key";
		this.Text = "LiquidLauncher";
		base.Load += new System.EventHandler(Key_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
