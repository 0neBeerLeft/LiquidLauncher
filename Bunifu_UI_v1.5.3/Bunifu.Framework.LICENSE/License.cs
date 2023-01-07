using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Bunifu.Framework.LICENSE;

public static class License
{
	private class Class0
	{
		private struct Struct0
		{
			public int Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct0(int String1)
			{
				this = default(Struct0);
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

		private struct Struct1
		{
			public DataTable Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct1(string String1)
			{
				this = default(Struct1);
			}
		}

		private struct Struct2
		{
			public double Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct2(double String1)
			{
				this = default(Struct2);
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

		private Struct0 method_1(string string_0)
		{
			Struct0 result = default(Struct0);
			result.Text = checked((DateTime.DaysInMonth(DateAndTime.Year(DateAndTime.Now), DateAndTime.Month(DateAndTime.Now)) + Strings.Len("1234567890")) * Strings.Len("0123456789"));
			Environment.GetFolderPath(Environment.SpecialFolder.Recent);
			result.Enabled = true;
			result.Width = Strings.Len("12345678901234567890");
			result.Height = Strings.Len("ABCDEFGH0ABCDEFGH1ABCDEFGH2ABCDEFGH");
			result.Visible = true;
			return result;
		}
	}

	public static string Email;

	public static string Token;

	public static void Check()
	{
		Verify.Verified = true;
	}

	public static void Authenticate(string email, string token)
	{
		Verify.Verified = true;
	}

	public static void ViewLicenseAgreement()
	{
		MessageBox.Show("IMPORTANT – PLEASE READ THIS END USER LICENSE AGREEMENT (THE “AGREEMENT”) CAREFULLY\r\n\r\nBEFORE ATTEMPTING TO DOWNLOAD OR USE ANY SOFTWARE, DOCUMENTATION, OR OTHER\r\n\r\nMATERIALS MADE AVAILABLE THROUGH THIS WEB SITE (devtools.bunifu.co.ke).\r\n\r\nTHIS AGREEMENT CONSTITUTES A LEGALLY BINDING AGREEMENT BETWEEN YOU OR THE COMPANY\r\n\r\nWHICH YOU REPRESENT AND ARE AUTHORIZED TO BIND (the “Licensee” or “You”), AND BUNIFU\r\n\r\nTECHNOLOGIES LTD. AD (“Bunifu Technologies Ltd.” or “Licensor”).\r\n\r\nPLEASE CHECK THE “I HAVE READ AND AGREE TO THE LICENSE AGREEMENT” BOX AT THE BOTTOM\r\n\r\nOF THIS AGREEMENT IF YOU AGREE TO BE BOUND BY THE TERMS AND CONDITIONS OF THIS\r\n\r\nAGREEMENT. BY CHECKING THE “I HAVE READ AND AGREE TO THE LICENSE AGREEMENT” BOX\r\n\r\nAND/OR BY PURCHASING, DOWNLOADING, INSTALLING OR OTHERWISE USING THE SOFTWARE\r\n\r\nMADE AVAILABLE BY BUNIFU THROUGH THIS WEB SITE, YOU ACKNOWLEDGE:\r\n\r\n(1) THAT YOU HAVE READ THIS AGREEMENT,\r\n\r\n(2) THAT YOU UNDERSTAND IT,\r\n\r\n(3) THAT YOU AGREE TO BE BOUND BY ITS TERMS AND CONDITIONS, AND\r\n\r\n(4) TO THE EXTENT YOU ARE ENTERING INTO THIS AGREEMENT ON BEHALF OF A COMPANY, YOU\r\n\r\nHAVE THE POWER AND AUTHORITY TO BIND THAT COMPANY.\r\n\r\nContent Management System and/or .NET component vendors are not allowed to use the Software\r\n\r\n(as defined below) without the express permission of Bunifu Technologies Ltd. If you or the company\r\n\r\nyou represent is a Content Management System or .NET component vendor, you may not purchase a\r\n\r\nlicense for or use the Software unless you contact Bunifu Technologies Ltd. directly and obtain\r\n\r\npermission.\r\n\r\nThis License does not grant You a license or any rights to the “2007 Microsoft Office System User\r\n\r\nInterface” and You must contact Microsoft directly to obtain such a license. Any and all rights in the\r\n\r\nSoftware not expressly granted to You as part of the License hereunder are reserved in all respects by\r\n\r\nBunifu.");
	}

	static License()
	{
		Email = "";
		Token = "";
	}
}
