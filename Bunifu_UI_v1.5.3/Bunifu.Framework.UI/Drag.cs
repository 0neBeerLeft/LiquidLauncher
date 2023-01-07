using System;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

public class Drag : Form
{
	private bool bool_0;

	private int int_0;

	private int int_1;

	private Control control_0;

	public void Grab(Control a)
	{
		try
		{
			control_0 = a;
			bool_0 = true;
			int_0 = Control.MousePosition.X - control_0.Left;
			int_1 = Control.MousePosition.Y - control_0.Top;
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

	public void Release()
	{
		bool_0 = false;
	}

	public void MoveObject(bool Horizontal = true, bool Vertical = true)
	{
		try
		{
			if (bool_0)
			{
				int num = Control.MousePosition.X;
				int num2 = Control.MousePosition.Y;
				if (Vertical)
				{
					control_0.Top = num2 - int_1;
				}
				if (Horizontal)
				{
					control_0.Left = num - int_0;
				}
			}
		}
		catch (Exception)
		{
		}
		int num3 = default(int);
		int num4 = default(int);
		while (num3 == num4)
		{
			num4 = 1;
			int num5 = num3;
			num3 = 1;
			if (1 > num5)
			{
				break;
			}
		}
	}
}
