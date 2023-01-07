using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DebuggerStepThrough]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuElipse : Component
{
	private ContainerControl containerControl_0;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	private Control control_0;

	private int int_0 = 5;

	private IContainer icontainer_0;

	private System.Windows.Forms.Timer timer_0;

	private ContainerControl ContainerControl
	{
		get
		{
			return containerControl_0;
		}
		set
		{
			containerControl_0 = value;
			ApplyElipse();
		}
	}

	public override ISite Site
	{
		get
		{
			return base.Site;
		}
		set
		{
			base.Site = value;
			if (value == null)
			{
				return;
			}
			if (value.GetService(typeof(IDesignerHost)) is IDesignerHost designerHost)
			{
				IComponent rootComponent = designerHost.RootComponent;
				if (rootComponent is ContainerControl)
				{
					ContainerControl = rootComponent as ContainerControl;
					return;
				}
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
	}

	public Control TargetControl
	{
		get
		{
			return control_0;
		}
		set
		{
			control_0 = value;
		}
	}

	public int ElipseRadius
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			ApplyElipse();
		}
	}

	public event EventHandler TargetControlResized
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

	public BunifuElipse()
	{
		method_0();
		if (TargetControl == null)
		{
			TargetControl = ContainerControl;
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

	private void control_0_Resize(object sender, EventArgs e)
	{
		Elipse.Apply(control_0, int_0);
		if (eventHandler_0 != null)
		{
			eventHandler_0(sender, e);
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

	public BunifuElipse(IContainer container)
	{
		container.Add(this);
		method_0();
	}

	public void ApplyElipse(int Radius)
	{
		if (control_0 != null)
		{
			Elipse.Apply(control_0, Radius);
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

	public void ApplyElipse()
	{
		try
		{
			if (control_0 != null)
			{
				Elipse.Apply(control_0, int_0);
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

	public void ApplyElipse(Control control, int Radius)
	{
		if (control != null)
		{
			Elipse.Apply(control, Radius);
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

	public void ApplyElipse(Control control)
	{
		if (control != null)
		{
			Elipse.Apply(control, int_0);
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

	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			timer_0.Stop();
			if (control_0 != null)
			{
				control_0.Resize += control_0_Resize;
			}
			else
			{
				control_0 = ContainerControl;
				control_0.Resize += control_0_Resize;
			}
			if (control_0.GetType() == typeof(Form))
			{
				((Form)control_0).FormBorderStyle = FormBorderStyle.None;
			}
			ApplyElipse();
		}
		catch (Exception)
		{
			timer_0.Start();
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

	private void method_0()
	{
		icontainer_0 = new Container();
		timer_0 = new System.Windows.Forms.Timer(icontainer_0);
		timer_0.Enabled = true;
		timer_0.Tick += timer_0_Tick;
	}
}
