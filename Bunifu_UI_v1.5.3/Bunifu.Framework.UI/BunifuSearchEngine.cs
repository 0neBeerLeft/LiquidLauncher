using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

[DebuggerStepThrough]
[ProvideProperty("BunifuFramework", typeof(Control))]
[DefaultEvent("onScanComlete")]
public class BunifuSearchEngine : UserControl
{
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	[CompilerGenerated]
	private EventHandler eventHandler_2;

	[CompilerGenerated]
	private EventHandler eventHandler_3;

	[CompilerGenerated]
	private EventHandler eventHandler_4;

	[CompilerGenerated]
	private EventHandler eventHandler_5;

	public string lastError = "";

	public int Passentage;

	public string path;

	public string curFile;

	public string curFolder = "";

	public bool pause;

	public List<FileInfo> Files = new List<FileInfo>();

	public List<DirectoryInfo> Folders = new List<DirectoryInfo>();

	private IContainer icontainer_0;

	private BackgroundWorker backgroundWorker_0;

	public event EventHandler onFileScan
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

	public event EventHandler onScanError
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

	public event EventHandler onFolderScan
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

	public event EventHandler onFailed
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

	public event EventHandler onAborted
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_4;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_4, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler onScanComplete
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_5;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_5, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public void startScan(string _path)
	{
		path = _path;
		if (!backgroundWorker_0.IsBusy)
		{
			backgroundWorker_0.RunWorkerAsync();
		}
		else
		{
			MessageBox.Show("Scan Engine Busy");
		}
	}

	public void abortScan()
	{
	}

	public void restartScan()
	{
	}

	public BunifuSearchEngine()
	{
		InitializeComponent();
		_ = LicenseManager.UsageMode;
		BunifuCustomControl.initializeComponent(this);
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		List<string> list = new List<string>();
		list.Add(path);
		Folders.Add(new DirectoryInfo(path));
		while (list.Count > 0)
		{
			curFolder = list[0];
			if (eventHandler_2 != null)
			{
				Invoke((Action)delegate
				{
					eventHandler_2(this, null);
				});
			}
			try
			{
				string[] directories = Directory.GetDirectories(curFolder);
				foreach (string item in directories)
				{
					list.Add(item);
				}
			}
			catch (Exception ex)
			{
				lastError = ex.Message;
				if (eventHandler_1 != null)
				{
					Invoke((Action)delegate
					{
						eventHandler_1(this, null);
					});
				}
			}
			try
			{
				string[] directories = Directory.GetFiles(curFolder);
				foreach (string text in directories)
				{
					curFile = text;
					Files.Add(new FileInfo(curFile));
					if (eventHandler_0 != null)
					{
						Invoke((Action)delegate
						{
							eventHandler_0(this, null);
						});
					}
				}
			}
			catch (Exception ex2)
			{
				lastError = ex2.Message;
				if (eventHandler_1 != null)
				{
					Invoke((Action)delegate
					{
						eventHandler_1(this, null);
					});
				}
			}
			list.RemoveAt(0);
		}
	}

	private void BunifuSearchEngine_Load(object sender, EventArgs e)
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

	private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		if (eventHandler_5 != null)
		{
			eventHandler_5(this, null);
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
		this.backgroundWorker_0 = new System.ComponentModel.BackgroundWorker();
		base.SuspendLayout();
		this.backgroundWorker_0.WorkerReportsProgress = true;
		this.backgroundWorker_0.WorkerSupportsCancellation = true;
		this.backgroundWorker_0.DoWork += new System.ComponentModel.DoWorkEventHandler(backgroundWorker_0_DoWork);
		this.backgroundWorker_0.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(backgroundWorker_0_ProgressChanged);
		this.backgroundWorker_0.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(backgroundWorker_0_RunWorkerCompleted);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.DoubleBuffered = true;
		base.Name = "BunifuSearchEngine";
		base.Size = new System.Drawing.Size(43, 44);
		base.Load += new System.EventHandler(BunifuSearchEngine_Load);
		base.ResumeLayout(false);
	}
}
