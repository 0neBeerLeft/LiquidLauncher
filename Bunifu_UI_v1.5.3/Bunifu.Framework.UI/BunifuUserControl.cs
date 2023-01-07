using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Bunifu.Framework.UI;

public static class BunifuUserControl
{
	private class Class2
	{
		private struct Struct6
		{
			public int Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct6(int String1)
			{
				this = default(Struct6);
				Text = String1;
			}

			public Acura Lexus(int String1)
			{
				Text = String1;
				return new Acura(Conversions.ToString(Text));
			}

			private void method_0(int int_0, int int_1)
			{
				Text = Conversions.ToInteger(Conversion.Str(checked(Strings.Len(int_0) + int_1)));
				this._0004_0006_0006_0006_0002(Conversions.ToInteger(SystemInformation.UserName));
			}
		}

		public struct Acura
		{
			public string Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Acura(string String1)
			{
				this = default(Acura);
				Text = String1;
			}

			public Acura Lexus(int String1)
			{
				Text = Conversions.ToString(String1);
				return new Acura(Text);
			}

			private void method_0(int int_0, int int_1)
			{
				Text = Conversion.Str(checked(Strings.Len(int_0) + int_1));
				this._0004_0006_0006_0006_0002(Conversions.ToInteger(SystemInformation.UserName));
			}

			public void SortTree(TreeView ctree, SortOrder so)
			{
				checked
				{
					try
					{
						TreeView treeView = new TreeView();
						string[] array = new string[ctree.GetNodeCount(includeSubTrees: false) - 1 + 1];
						int num = 0;
						int num2 = 0;
						int num3 = array.Length - 1;
						for (num = 0; num <= num3; num++)
						{
							array[num] = ctree.Nodes[num].Text;
							NewLateBinding.LateCall(treeView.Nodes, null, "Add", new object[1] { RuntimeHelpers.GetObjectValue(ctree.Nodes[num].Clone()) }, null, null, null, IgnoreReturn: true);
						}
						if (so == SortOrder.Ascending)
						{
							Array.Sort(array);
						}
						else
						{
							Array.Reverse(array);
						}
						for (num = ctree.GetNodeCount(includeSubTrees: false) - 1; num >= 0; num += -1)
						{
							ctree.Nodes[num].Remove();
						}
						int num4 = array.Length - 1;
						for (num2 = 0; num2 <= num4; num2++)
						{
							int num5 = treeView.GetNodeCount(includeSubTrees: false) - 1;
							for (num = 0; num <= num5; num++)
							{
								if (Operators.CompareString(array[num2].Trim(), treeView.Nodes[num].Text, TextCompare: false) == 0)
								{
									NewLateBinding.LateCall(ctree.Nodes, null, "Add", new object[1] { RuntimeHelpers.GetObjectValue(treeView.Nodes[num].Clone()) }, null, null, null, IgnoreReturn: true);
								}
							}
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		private struct Struct7
		{
			public DataTable Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct7(string String1)
			{
				this = default(Struct7);
			}
		}

		private struct Struct8
		{
			public double Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct8(double String1)
			{
				this = default(Struct8);
				Text = String1;
			}
		}

		private Acura method_0(string string_0)
		{
			Acura result = new Acura(string_0);
			result.Text = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
			result.Enabled = true;
			result.Width = Strings.Len("12345678901234567890");
			result.Height = Strings.Len("ABCDEFGH0ABCDEFGH1ABCDEFGH2ABCDEFGH");
			result.Visible = true;
			return result;
		}

		private Struct6 method_1(string string_0)
		{
			Struct6 result = default(Struct6);
			result.Text = checked((DateTime.DaysInMonth(DateAndTime.Year(DateAndTime.Now), DateAndTime.Month(DateAndTime.Now)) + Strings.Len("1234567890")) * Strings.Len("0123456789"));
			Environment.GetFolderPath(Environment.SpecialFolder.Recent);
			result.Enabled = true;
			result.Width = Strings.Len("12345678901234567890");
			result.Height = Strings.Len("ABCDEFGH0ABCDEFGH1ABCDEFGH2ABCDEFGH");
			result.Visible = true;
			return result;
		}
	}

	private static string string_0 = "";

	private static string string_1 = string.Empty;

	public static string Value()
	{
		if (string.IsNullOrEmpty(string_1))
		{
			string_1 = smethod_5("CPU: " + smethod_7() + " BIOS: " + smethod_8() + " BASE: " + smethod_6() + " VIDEO: " + smethod_3());
		}
		return string_1;
	}

	private static string smethod_0(string string_2, string string_3, string string_4)
	{
		string text = "";
		foreach (ManagementBaseObject instance in new ManagementClass(string_2).GetInstances())
		{
			if (!(instance[string_4].ToString() != "True") && !(text != ""))
			{
				try
				{
					text = instance[string_3].ToString();
					return text;
				}
				catch
				{
				}
			}
		}
		return text;
	}

	private static string smethod_1(string string_2, string string_3)
	{
		string text = "";
		foreach (ManagementBaseObject instance in new ManagementClass(string_2).GetInstances())
		{
			if (!(text != ""))
			{
				try
				{
					text = instance[string_3].ToString();
					return text;
				}
				catch
				{
				}
			}
		}
		return text;
	}

	private static string smethod_2()
	{
		return smethod_1("Win32_DiskDrive", "Model") + smethod_1("Win32_DiskDrive", "Manufacturer") + smethod_1("Win32_DiskDrive", "Signature") + smethod_1("Win32_DiskDrive", "TotalHeads");
	}

	private static string smethod_3()
	{
		return smethod_1("Win32_VideoController", "DriverVersion") + smethod_1("Win32_VideoController", "Name");
	}

	private static string smethod_4()
	{
		return smethod_0("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
	}

	private static string smethod_5(string string_2)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(string_2);
		return GetHexString(mD5CryptoServiceProvider.ComputeHash(bytes));
	}

	private static string GetHexString(IList<byte> bt)
	{
		string text = string.Empty;
		for (int i = 0; i < bt.Count; i++)
		{
			byte num = bt[i];
			int num2 = num & 0xF;
			int num3 = (num >> 4) & 0xF;
			text = ((num3 <= 9) ? (text + num3.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num3 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
			text = ((num2 <= 9) ? (text + num2.ToString(CultureInfo.InvariantCulture)) : (text + ((char)(num2 - 10 + 65)).ToString(CultureInfo.InvariantCulture)));
			if (i + 1 != bt.Count && (i + 1) % 2 == 0)
			{
				text += "-";
			}
		}
		return text;
	}

	private static string smethod_6()
	{
		return smethod_1("Win32_BaseBoard", "Model") + smethod_1("Win32_BaseBoard", "Manufacturer") + smethod_1("Win32_BaseBoard", "Name") + smethod_1("Win32_BaseBoard", "SerialNumber");
	}

	private static string smethod_7()
	{
		string text = smethod_1("Win32_Processor", "UniqueId");
		if (text != "")
		{
			return text;
		}
		text = smethod_1("Win32_Processor", "ProcessorId");
		if (text != "")
		{
			return text;
		}
		text = smethod_1("Win32_Processor", "Name");
		if (text == "")
		{
			text = smethod_1("Win32_Processor", "Manufacturer");
		}
		return text + smethod_1("Win32_Processor", "MaxClockSpeed");
	}

	private static string smethod_8()
	{
		return smethod_1("Win32_BIOS", "Manufacturer") + smethod_1("Win32_BIOS", "SMBIOSBIOSVersion") + smethod_1("Win32_BIOS", "IdentificationCode") + smethod_1("Win32_BIOS", "SerialNumber") + smethod_1("Win32_BIOS", "ReleaseDate") + smethod_1("Win32_BIOS", "Version");
	}
}
