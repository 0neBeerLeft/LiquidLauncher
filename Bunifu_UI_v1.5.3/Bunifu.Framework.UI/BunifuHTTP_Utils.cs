using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DebuggerStepThrough]
[DefaultEvent("OnJobDone")]
public class BunifuHTTP_Utils : Component
{
	private string string_0 = "";

	private Exception exception_0;

	private string string_1 = "";

	private string string_2 = "";

	private string string_3 = "";

	private bool bool_0;

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

	[CompilerGenerated]
	private EventHandler eventHandler_6;

	private IContainer icontainer_0;

	private BackgroundWorker backgroundWorker_0;

	public string Value => string_0;

	public Exception LastError => exception_0;

	public string JobName
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
		}
	}

	public string Url
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
		}
	}

	public bool IsBusy => bool_0;

	public event EventHandler OnJobDone
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

	public event EventHandler OnError
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

	public event EventHandler onAborted
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

	public event EventHandler onFileDownloadComplete
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

	public event EventHandler onFileDownloadFail
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

	public event EventHandler onBusyStateChanged
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

	public event EventHandler OnDownloadProgressChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_6;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_6, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BunifuHTTP_Utils()
	{
		method_0();
	}

	public BunifuHTTP_Utils(IContainer container)
	{
		container.Add(this);
		method_0();
	}

	public void PostString()
	{
		try
		{
			backgroundWorker_0.RunWorkerAsync();
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
		}
		catch (Exception)
		{
			throw new Exception("Http Job already running.");
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

	public void PostString(string Data)
	{
		try
		{
			string_3 = Data;
			backgroundWorker_0.RunWorkerAsync();
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
		}
		catch (Exception)
		{
			throw new Exception("Http Job already running.");
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

	public void PostString(Dictionary<string, string> Data)
	{
		string text = "";
		try
		{
			for (int i = 0; i < Data.Keys.Count; i++)
			{
				string text2 = Data.Keys.ElementAt(i).ToString();
				string text3 = Data[text2];
				text = text + "&" + text2 + "=" + text3;
			}
			string_3 = text;
			backgroundWorker_0.RunWorkerAsync();
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
		}
		catch (Exception)
		{
			throw new Exception("Http Job already running.");
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

	public void PostString(string Data, string jobname)
	{
		string_3 = Data;
		JobName = jobname;
		try
		{
			backgroundWorker_0.RunWorkerAsync();
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
		}
		catch (Exception)
		{
			throw new Exception("Http Job already running.");
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

	public void PostString(string Data, string jobname, string url)
	{
		string_3 = Data;
		JobName = jobname;
		Url = url;
		try
		{
			backgroundWorker_0.RunWorkerAsync();
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
		}
		catch (Exception)
		{
			throw new Exception("Http Job already running.");
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

	public void AbortJob()
	{
		try
		{
			if (backgroundWorker_0.IsBusy)
			{
				backgroundWorker_0.CancelAsync();
			}
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
			if (eventHandler_2 != null)
			{
				eventHandler_2(this, new EventArgs());
			}
		}
		catch (Exception)
		{
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

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		bool_0 = true;
		HTTP hTTP = new HTTP(string_2);
		if (hTTP.executesend(string_3))
		{
			string_0 = hTTP.Responce;
			exception_0 = null;
		}
		else
		{
			string_0 = "";
			exception_0 = hTTP.LastError;
		}
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		bool_0 = false;
		try
		{
			if (LastError == null)
			{
				if (eventHandler_0 != null)
				{
					eventHandler_0(this, new EventArgs());
				}
			}
			else if (eventHandler_1 != null)
			{
				eventHandler_1(this, new EventArgs());
			}
			if (eventHandler_5 != null)
			{
				eventHandler_5(this, new EventArgs());
			}
		}
		catch (Exception)
		{
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

	public long getFileSize(string url)
	{
		HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(url);
		obj.Method = "HEAD";
		return ((HttpWebResponse)obj.GetResponse()).ContentLength;
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
		icontainer_0 = new Container();
		backgroundWorker_0 = new BackgroundWorker();
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
	}
}
