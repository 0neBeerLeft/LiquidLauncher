using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace Bunifu.Framework.Lib;

[DebuggerStepThrough]
internal class HTTP
{
	public string URL = "";

	public string Responce = "";

	public Exception LastError = new Exception();

	public HTTP(string Url)
	{
		URL = Url;
	}

	public bool executesend(string data)
	{
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(URL);
			obj.Method = "POST";
			byte[] bytes = Encoding.ASCII.GetBytes(data);
			obj.ContentType = "application/x-www-form-urlencoded";
			obj.ContentLength = bytes.Length;
			Stream requestStream = obj.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse obj2 = (HttpWebResponse)obj.GetResponse();
			obj2.GetResponseStream();
			string responce = new StreamReader(obj2.GetResponseStream()).ReadToEnd();
			Responce = responce;
			return true;
		}
		catch (Exception lastError)
		{
			Responce = "";
			LastError = lastError;
			return false;
		}
	}
}
