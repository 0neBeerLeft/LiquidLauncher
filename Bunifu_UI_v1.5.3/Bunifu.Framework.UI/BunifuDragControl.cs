using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

[DebuggerStepThrough]
[ProvideProperty("BunifuFramework", typeof(Control))]
public class BunifuDragControl : Component
{
	private Drag drag_0 = new Drag();

	private Control control_0;

	private ContainerControl containerControl_0;

	private bool bool_0 = true;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private IContainer icontainer_0;

	private Timer timer_0;

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

	private ContainerControl containerControl
	{
		get
		{
			return containerControl_0;
		}
		set
		{
			containerControl_0 = value;
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
					containerControl = rootComponent as ContainerControl;
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

	public bool Fixed
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public bool Vertical
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public bool Horizontal
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
		}
	}

	public BunifuDragControl()
	{
		method_3();
		_ = LicenseManager.UsageMode;
	}

	public BunifuDragControl(IContainer container)
	{
		container.Add(this);
		method_3();
	}

	public void Grab(Control _control)
	{
		drag_0.Grab(_control);
	}

	public void Grab()
	{
		Control a = containerControl_0;
		drag_0.Grab(a);
	}

	public void Release()
	{
		drag_0.Release();
	}

	public void Drag(bool horixontal = true, bool Vertical = true)
	{
		drag_0.MoveObject(Vertical, horixontal);
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		try
		{
			timer_0.Stop();
			Control control = containerControl;
			if (control_0 != null)
			{
				control = control_0;
			}
			control.MouseDown += method_2;
			control.MouseMove += method_0;
			control.MouseUp += method_1;
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

	private void method_0(object sender, MouseEventArgs e)
	{
		Drag(Vertical, Horizontal);
	}

	private void method_1(object sender, MouseEventArgs e)
	{
		Release();
	}

	private void method_2(object sender, MouseEventArgs e)
	{
		if (bool_0)
		{
			Control control = (Control)sender;
			while (control.Parent != null)
			{
				control = control.Parent;
			}
			Grab(control);
		}
		else
		{
			Grab((Control)sender);
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

	private void method_3()
	{
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		timer_0.Enabled = true;
		timer_0.Interval = 1;
		timer_0.Tick += timer_0_Tick;
	}
}
