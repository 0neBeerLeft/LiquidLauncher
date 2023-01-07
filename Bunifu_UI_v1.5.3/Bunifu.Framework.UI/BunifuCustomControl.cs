using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.Lib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Bunifu.Framework.UI;

public static class BunifuCustomControl
{
	private class Class1
	{
		private struct Struct3
		{
			public int Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct3(int String1)
			{
				this = default(Struct3);
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

		private struct Struct4
		{
			public DataTable Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct4(string String1)
			{
				this = default(Struct4);
			}
		}

		private struct Struct5
		{
			public double Text;

			public bool Enabled;

			public int Width;

			public int Height;

			public bool Visible;

			public Struct5(double String1)
			{
				this = default(Struct5);
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

		private Struct3 method_1(string string_0)
		{
			Struct3 result = default(Struct3);
			result.Text = checked((DateTime.DaysInMonth(DateAndTime.Year(DateAndTime.Now), DateAndTime.Month(DateAndTime.Now)) + Strings.Len("1234567890")) * Strings.Len("0123456789"));
			Environment.GetFolderPath(Environment.SpecialFolder.Recent);
			result.Enabled = true;
			result.Width = Strings.Len("12345678901234567890");
			result.Height = Strings.Len("ABCDEFGH0ABCDEFGH1ABCDEFGH2ABCDEFGH");
			result.Visible = true;
			return result;
		}
	}

	public static string myidentity;

	static BunifuCustomControl()
	{
		myidentity = "";
		if (Paint_())
		{
			initializeComponent(firstTime: true);
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

	public static void initializeComponent(Control sender)
	{
	}

	public static void initializeComponent(bool firstTime)
	{
		if (firstTime)
		{
			MessageBox.Show("Bunifu UI cracked by COOL_LEMUR", "Bunifu UI License", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		if (!Paint_())
		{
			return;
		}
		string text = RenderComplete();
		while (text.ToLower().Trim() != "true")
		{
			DialogResult dialogResult = MessageBox.Show(text + "\n \n Design Time License Locked (Your project wont be affected)", "Bunifu UI License Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
			if (dialogResult != DialogResult.Retry)
			{
				if (dialogResult == DialogResult.Abort)
				{
					cmd.EXECUTECMD("taskkill /im devenv.exe /f");
				}
				if (dialogResult == DialogResult.Ignore && firstTime)
				{
					Timer timer = new Timer();
					timer.Interval = 5000;
					timer.Tick += smethod_0;
					timer.Start();
				}
				break;
			}
		}
	}

	private static void smethod_0(object sender, EventArgs e)
	{
		((Timer)sender).Enabled = false;
		initializeComponent(firstTime: false);
		((Timer)sender).Enabled = true;
	}

	public static string RenderComplete()
	{
		if (myidentity.Trim().Length == 0)
		{
			myidentity = BunifuUserControl.Value().ToString();
		}
		return true.ToString();
	}

	public static bool Paint_()
	{
		if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
		{
			return true;
		}
		return false;
	}
}
