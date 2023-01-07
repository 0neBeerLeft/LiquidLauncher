using System.Drawing;
using System.Windows.Forms;

namespace Bunifu.Framework.UI;

public class BunifuCustomLabel : Label
{
	public BunifuCustomLabel()
	{
		SetStyle(ControlStyles.UserPaint, value: true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		if (!base.Enabled)
		{
			SolidBrush brush = new SolidBrush(ForeColor);
			e.Graphics.DrawString(Text, Font, brush, 0f, 0f);
		}
		else
		{
			base.OnPaint(e);
		}
	}
}
