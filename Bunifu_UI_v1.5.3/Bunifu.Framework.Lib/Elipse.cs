using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bunifu.Framework.Lib;

[DebuggerStepThrough]
public static class Elipse
{
	[DllImport("Gdi32.dll")]
	private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

	public static void Apply(Form Form, int _Elipse)
	{
		try
		{
			Form.FormBorderStyle = FormBorderStyle.None;
			Form.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Form.Width, Form.Height, _Elipse, _Elipse));
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

	public static void Apply(Control ctrl, int Elipse)
	{
		try
		{
			ctrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, Elipse, Elipse));
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
}
