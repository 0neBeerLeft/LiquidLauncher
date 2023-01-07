using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

public class BunifuCustomDataGrid : DataGridView
{
	private bool bool_0 = true;

	public Color Hcolor = Color.SeaGreen;

	public Color HBgcolor = Color.SeaGreen;

	private IContainer icontainer_0;

	public new bool DoubleBuffered
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			ApplyDoubleBuffer(this, bool_0);
		}
	}

	public Color HeaderBgColor
	{
		get
		{
			return Hcolor;
		}
		set
		{
			Hcolor = value;
			base.ColumnHeadersDefaultCellStyle.BackColor = Hcolor;
			base.ColumnHeadersDefaultCellStyle.ForeColor = HBgcolor;
			base.BorderStyle = BorderStyle.None;
		}
	}

	public Color HeaderForeColor
	{
		get
		{
			return HBgcolor;
		}
		set
		{
			HBgcolor = value;
			base.ColumnHeadersDefaultCellStyle.BackColor = Hcolor;
			base.ColumnHeadersDefaultCellStyle.ForeColor = HBgcolor;
			base.BorderStyle = BorderStyle.None;
		}
	}

	public BunifuCustomDataGrid()
	{
		method_0();
		base.ColumnHeadersDefaultCellStyle.BackColor = Hcolor;
		base.ColumnHeadersDefaultCellStyle.ForeColor = HBgcolor;
		base.BorderStyle = BorderStyle.None;
		base.EnableHeadersVisualStyles = false;
	}

	public void ApplyDoubleBuffer(DataGridView dgv, bool setting)
	{
		try
		{
			dgv.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(dgv, setting, null);
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
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		((ISupportInitialize)this).BeginInit();
		SuspendLayout();
		dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
		base.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
		base.BackgroundColor = Color.Gainsboro;
		base.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle2.BackColor = Color.SeaGreen;
		dataGridViewCellStyle2.Font = new Font("Century Gothic", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle2.ForeColor = Color.White;
		dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
		dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
		base.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
		base.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
		((ISupportInitialize)this).EndInit();
		ResumeLayout(performLayout: false);
	}
}
