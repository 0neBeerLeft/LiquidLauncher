using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;

internal class FileDownloader
{
	private readonly string string_0;

	private readonly string string_1;

	private bool bool_0;

	private readonly SemaphoreSlim semaphoreSlim_0 = new SemaphoreSlim(0);

	public int ProgressPassentage;

	public FileDownloader(string url, string fullPathWhereToSave)
	{
		if (string.IsNullOrEmpty(url))
		{
			throw new ArgumentNullException("url");
		}
		if (string.IsNullOrEmpty(fullPathWhereToSave))
		{
			throw new ArgumentNullException("fullPathWhereToSave");
		}
		string_0 = url;
		string_1 = fullPathWhereToSave;
	}

	public bool StartDownload(int timeout)
	{
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(string_1));
			if (File.Exists(string_1))
			{
				File.Delete(string_1);
			}
			using WebClient webClient = new WebClient();
			Uri address = new Uri(string_0);
			webClient.DownloadProgressChanged += method_0;
			webClient.DownloadFileCompleted += method_1;
			Console.WriteLine("Downloading file:");
			webClient.DownloadFileAsync(address, string_1);
			semaphoreSlim_0.Wait(timeout);
			return bool_0 && File.Exists(string_1);
		}
		catch (Exception value)
		{
			Console.WriteLine("Was not able to download file!");
			Console.Write(value);
			return false;
		}
		finally
		{
			semaphoreSlim_0.Dispose();
		}
	}

	private void method_0(object sender, DownloadProgressChangedEventArgs e)
	{
		Console.Write("\r     -->    {0}%.", e.ProgressPercentage);
		ProgressPassentage = e.ProgressPercentage;
	}

	private void method_1(object sender, AsyncCompletedEventArgs e)
	{
		ProgressPassentage = 0;
		bool_0 = !e.Cancelled;
		if (!bool_0)
		{
			Console.Write(e.Error.ToString());
		}
		Console.WriteLine(Environment.NewLine + "Download finished!");
		semaphoreSlim_0.Release();
	}

	public static bool DownloadFile(string url, string fullPathWhereToSave, int timeoutInMilliSec)
	{
		return new FileDownloader(url, fullPathWhereToSave).StartDownload(timeoutInMilliSec);
	}
}
