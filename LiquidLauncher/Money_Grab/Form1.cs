using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using DLLInjection;
using Money_Grab.Properties;

namespace Money_Grab;

public class Form1 : Form
{
	private WebClient wc = new WebClient();

	public string DLLDOWNLOAD = "";

	public string ytd1 = "";

	public string ytd2 = "";

	public string ytd3 = "";

	private bool hasAdminPerms;

	public string trans = "";

	private IContainer components;

	private BunifuDragControl bunifuDragControl1;

	private System.Windows.Forms.Timer timer1;

	private Label label3;

	private Button button5;

	private Label label1;

	private PictureBox pictureBox1;

	public string YTD_DOWNLOAD { get; private set; }

	public Form1()
	{
		InitializeComponent();
	}

	public void EditText(string text, string path)
	{
		File.WriteAllText(path, text);
	}

	public static string GetWindowsServiceStatus(string SERVICENAME)
	{
		return new ServiceController(SERVICENAME).Status switch
		{
			ServiceControllerStatus.Running => "Running", 
			ServiceControllerStatus.Stopped => "Stopped", 
			ServiceControllerStatus.Paused => "Paused", 
			ServiceControllerStatus.StopPending => "Stopping", 
			ServiceControllerStatus.StartPending => "Starting", 
			_ => "Status Changing", 
		};
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void label1_Click_1(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Very nice man!", "Hertz");
	}

	private void label3_Click(object sender, EventArgs e)
	{
		try
		{
			Application.ExitThread();
			Close();
		}
		catch (Exception)
		{
			Environment.Exit(0);
			Close();
		}
	}

	private void button5_Click_1(object sender, EventArgs e)
	{
		Directory.CreateDirectory("C:\\Liquid");
		Directory.CreateDirectory("C:\\Liquid\\DLL");
		WebClient webClient = new WebClient();
		File.Delete("C:\\Liquid\\DLL\\Liquid.dll");
		if (File.Exists("C:\\Liquid\\DLL\\Liquid.dll"))
		{
			Close();
		}
		File.Delete("C:\\Liquid\\DLL\\quid.dll");
		if (File.Exists("C:\\Liquid\\DLL\\quid.dll"))
		{
			Close();
		}
		DLLDOWNLOAD = wc.DownloadString("https://pastebin.com/raw/vuPLTiwA");
		ytd1 = "https://cdn.discordapp.com/attachments/891365380797378610/966381617088192582/Liquid.ytd";
		ytd2 = "https://cdn.discordapp.com/attachments/891365380797378610/1013483275123179550/Textures.ytd";
		string fileName = "C:\\Liquid\\DLL\\quid.dll";
		string fileName2 = "C:\\Liquid\\Textures.ytd";
		string fileName3 = "C:\\Liquid\\elonmusk.ytd";
		webClient.DownloadFile(DLLDOWNLOAD, fileName);
		webClient.DownloadFile(ytd2, fileName2);
		webClient.DownloadFile(ytd1, fileName3);
		Process.Start("https://skeygithub.github.io/liquid/");
		string text = "C:\\Liquid\\DLL\\quid.dll";
		File.Exists(text);
		using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
		{
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(ntIdentity);
			hasAdminPerms = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		Process process;
		string s;
		try
		{
			process = Process.GetProcessesByName("GTA5")[0];
			s = process.Id.ToString();
		}
		catch (IndexOutOfRangeException)
		{
			Close();
			return;
		}
		try
		{
			if (int.TryParse(s, out var result))
			{
				InjectionMethod injectionMethod = InjectionMethod.CREATE_REMOTE_THREAD;
				try
				{
					Thread.Sleep(2000);
					new DLLInjector(injectionMethod).Inject(result, text);
					Thread.Sleep(2000);
					return;
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message, ex2.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
		}
		catch (WebException)
		{
			process.Kill();
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Process.Start("https://rivermod.github.io/river/");
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		Process.Start("https://rivermod.github.io/river/");
	}

	private void timer1_Tick_1(object sender, EventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Money_Grab.Form1));
		this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.button5 = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.bunifuDragControl1.Fixed = true;
		this.bunifuDragControl1.Horizontal = true;
		this.bunifuDragControl1.TargetControl = this;
		this.bunifuDragControl1.Vertical = true;
		this.timer1.Enabled = true;
		this.timer1.Tick += new System.EventHandler(timer1_Tick_1);
		this.button5.BackColor = System.Drawing.Color.Transparent;
		this.button5.FlatAppearance.BorderSize = 3;
		this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
		this.button5.ForeColor = System.Drawing.Color.Blue;
		this.button5.Location = new System.Drawing.Point(68, 158);
		this.button5.Name = "button5";
		this.button5.Size = new System.Drawing.Size(247, 68);
		this.button5.TabIndex = 29;
		this.button5.Text = "Inject";
		this.button5.UseVisualStyleBackColor = false;
		this.button5.Click += new System.EventHandler(button5_Click_1);
		this.label3.AutoSize = true;
		this.label3.BackColor = System.Drawing.Color.Transparent;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.Red;
		this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
		this.label3.Location = new System.Drawing.Point(356, -3);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(28, 31);
		this.label3.TabIndex = 33;
		this.label3.Text = "x";
		this.label3.Click += new System.EventHandler(label3_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.Blue;
		this.label1.Location = new System.Drawing.Point(65, 142);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(235, 13);
		this.label1.TabIndex = 40;
		this.label1.Text = "Press Inject while in Singleplayer w game loaded";
		this.pictureBox1.Image = Money_Grab.Properties.Resources.liquidlogopink;
		this.pictureBox1.Location = new System.Drawing.Point(121, 12);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(139, 119);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.pictureBox1.TabIndex = 41;
		this.pictureBox1.TabStop = false;
		this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.ClientSize = new System.Drawing.Size(384, 289);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.button5);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Form1";
		this.RightToLeftLayout = true;
		this.Text = "LiquidLauncher";
		base.Load += new System.EventHandler(Form1_Load);
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
