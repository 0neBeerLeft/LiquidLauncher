using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bunifu.Framework.Lib;

[DebuggerStepThrough]
internal static class Styles
{
	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	private static bool bool_0 = true;

	public static void ZoomIn(Control pic, int by)
	{
		if (bool_0)
		{
			int_0 = pic.Height;
			int_1 = pic.Width;
			int num = Convert.ToInt32(Math.Round((double)by * 0.01 * (double)int_0) * 0.5);
			int num2 = Convert.ToInt32(Math.Round((double)by * 0.01 * (double)int_1) * 0.5);
			int height = int_0 + num * 2;
			int width = int_1 + num2 * 2;
			int_2 = num;
			int_3 = num2;
			pic.Width = width;
			pic.Height = height;
			pic.Top -= int_2;
			pic.Left -= int_3;
			bool_0 = false;
			return;
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

	public static void ZoomOut(Control pic)
	{
		if (!bool_0)
		{
			pic.SuspendLayout();
			pic.Width = int_1;
			pic.Left += int_3;
			pic.Height = int_0;
			pic.Top += int_2;
			pic.ResumeLayout();
			bool_0 = true;
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

	public static void onclick(Control pic)
	{
		ZoomOut(pic);
	}

	public static void unclick(Control pic)
	{
	}
}
