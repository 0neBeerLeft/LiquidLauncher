using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace Bunifu.Framework.Lib;

[DebuggerStepThrough]
internal class Graphics
{
	public static Image OverlayColor(Image _Image, Color Find, Color Replace)
	{
		Bitmap bitmap = new Bitmap(_Image);
		for (int i = 0; i < bitmap.Height; i++)
		{
			for (int j = 0; j < bitmap.Width; j++)
			{
				if (!smethod_0(bitmap.GetPixel(j, i)))
				{
					bitmap.SetPixel(j, i, Replace);
				}
			}
		}
		return bitmap;
	}

	public static Image OverlayColor(Image _Image, Color Replace)
	{
		Bitmap bitmap = new Bitmap(_Image);
		for (int i = 0; i < bitmap.Height; i++)
		{
			for (int j = 0; j < bitmap.Width; j++)
			{
				if (!smethod_0(bitmap.GetPixel(j, i)))
				{
					bitmap.SetPixel(j, i, Replace);
				}
			}
		}
		return bitmap;
	}

	public static Image Smoothen(Image _img)
	{
		Bitmap bitmap = new Bitmap(_img);
		List<int[]> list = new List<int[]>();
		for (int i = 0; i < bitmap.Height - 1; i++)
		{
			for (int j = 0; j < bitmap.Width - 1; j++)
			{
				Color[] array = new Color[4];
				array[0] = bitmap.GetPixel(j, i);
				array[2] = bitmap.GetPixel(j, i + 1);
				array[1] = bitmap.GetPixel(j + 1, i);
				array[3] = bitmap.GetPixel(j + 1, i + 1);
				if (array[1] == array[2] && !smethod_0(array[1]) && smethod_0(array[0]))
				{
					list.Add(new int[2] { j, i });
				}
				if (array[0] == array[3] && !smethod_0(array[0]) && smethod_0(array[2]))
				{
					list.Add(new int[2]
					{
						j,
						i + 1
					});
				}
				if (array[0] == array[3] && !smethod_0(array[0]) && smethod_0(array[1]))
				{
					list.Add(new int[2]
					{
						j + 1,
						i
					});
				}
				if (array[1] == array[2] && !smethod_0(array[1]) && smethod_0(array[3]))
				{
					list.Add(new int[2]
					{
						j + 1,
						i + 1
					});
				}
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			bitmap.SetPixel(list[k][0], list[k][1], AddColor(Color.Yellow, Color.FromArgb(211, 211, 211)));
		}
		return bitmap;
	}

	public static Color AddColor(Color col1, Color col2)
	{
		return Color.FromArgb((col1.R + col2.R) / 2, (col1.G + col2.G) / 2, (col1.B + col2.B) / 2);
	}

	private static bool smethod_0(Color color_0)
	{
		if (color_0.R == 0 && color_0.G == 0)
		{
			return color_0.B == 0;
		}
		return false;
	}

	public static Color getColorScale(int Passentage, Color startColor, Color endColor)
	{
		int red = int.Parse(Math.Round((double)(int)startColor.R + (double)((endColor.R - startColor.R) * Passentage) * 0.01, 0).ToString());
		int green = int.Parse(Math.Round((double)(int)startColor.G + (double)((endColor.G - startColor.G) * Passentage) * 0.01, 0).ToString());
		int blue = int.Parse(Math.Round((double)(int)startColor.B + (double)((endColor.B - startColor.B) * Passentage) * 0.01, 0).ToString());
		return Color.FromArgb(255, red, green, blue);
	}
}
