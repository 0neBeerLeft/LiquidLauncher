using System.ComponentModel;
using System.Net;

namespace Bunifu.Framework.UI;

public class BunifuWebClient : WebClient
{
	private IContainer icontainer_0;

	[Browsable(false)]
	public new bool AllowWriteStreamBuffering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Browsable(false)]
	public new bool AllowReadStreamBuffering
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BunifuWebClient()
	{
		method_0();
	}

	public BunifuWebClient(IContainer container)
	{
		container.Add(this);
		method_0();
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
	}
}
