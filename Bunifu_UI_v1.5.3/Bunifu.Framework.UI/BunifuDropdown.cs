using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.Lib;

namespace Bunifu.Framework.UI;

[DefaultEvent("onItemSelected")]
[ProvideProperty("BunifuFramework", typeof(Control))]
[DebuggerStepThrough]
public class BunifuDropdown : UserControl
{
	public int _BorderRadius = 3;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private EventHandler eventHandler_1;

	[CompilerGenerated]
	private EventHandler eventHandler_2;

	private string[] string_0 = new string[0];

	private bool bool_0 = true;

	private IContainer icontainer_0;

	public BunifuFlatButton Style;

	private ComboBox Collections;

	public int BorderRadius
	{
		get
		{
			return _BorderRadius;
		}
		set
		{
			_BorderRadius = value;
			Style.BorderRadius = _BorderRadius;
		}
	}

	public int selectedIndex
	{
		get
		{
			return Collections.SelectedIndex;
		}
		set
		{
			if (Collections.Items.Count > value && value >= 0)
			{
				Collections.SelectedIndex = value;
				Style.ButtonText = "    " + Collections.Items[value].ToString();
				return;
			}
			if (value != -1)
			{
				throw new Exception("Out of index");
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

	public string selectedValue => Collections.Items[selectedIndex].ToString().Trim();

	public string[] Items
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			Collections.Items.Clear();
			for (int i = 0; i < string_0.Length; i++)
			{
				Collections.Items.Add(string_0[i]);
			}
		}
	}

	public Color onHoverColor
	{
		get
		{
			return Style.OnHovercolor;
		}
		set
		{
			Style.OnHovercolor = value;
		}
	}

	public Color NomalColor
	{
		get
		{
			return Style.Normalcolor;
		}
		set
		{
			Style.Normalcolor = value;
			Style.Activecolor = value;
		}
	}

	[Browsable(true)]
	[Bindable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public new bool Enabled
	{
		get
		{
			return bool_0;
		}
		set
		{
			Style.Enabled = value;
		}
	}

	public Color DisabledColor
	{
		get
		{
			return Style.DisabledColor;
		}
		set
		{
			Style.DisabledColor = value;
		}
	}

	public event EventHandler onItemSelected
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler onItemAdded
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler onItemRemoved
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_2;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_2, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public BunifuDropdown()
	{
		InitializeComponent();
		if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
		{
			Collections.Visible = false;
		}
		else
		{
			Collections.Visible = true;
		}
		if (Collections.Items.Count > 0)
		{
			Collections.SelectedIndex = 0;
		}
		Style.ButtonText = Collections.Text;
		OnResize(null);
		BunifuCustomControl.initializeComponent(this);
	}

	public void AddItem(string Item)
	{
		Collections.Items.Add(Item);
	}

	public void RemoveItem(string Item)
	{
		Collections.Items.Remove(Item);
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, null);
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

	public void RemoveAt(int index)
	{
		Collections.Items.RemoveAt(index);
		if (selectedIndex == index)
		{
			Style.Text = "";
		}
		if (eventHandler_2 != null)
		{
			eventHandler_2(this, null);
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

	public void Clear()
	{
		Collections.Items.Clear();
		string_0 = new string[0];
		Style.Text = "";
	}

	private void BunifuDropdown_Resize(object sender, EventArgs e)
	{
	}

	private void Style_Click(object sender, EventArgs e)
	{
		Collections.Select();
		SendKeys.Send("%{DOWN}");
	}

	private void BunifuDropdown_FontChanged(object sender, EventArgs e)
	{
		Style.Font = Font;
	}

	private void BunifuDropdown_ForeColorChanged(object sender, EventArgs e)
	{
		Style.Textcolor = ForeColor;
		Style.OnHoverTextColor = ForeColor;
		if (Style.Iconimage_right != null)
		{
			Style.Iconimage_right = Bunifu.Framework.Lib.Graphics.OverlayColor(Style.Iconimage_right, ForeColor);
		}
		if (Style.Iconimage != null)
		{
			Style.Iconimage = Bunifu.Framework.Lib.Graphics.OverlayColor(Style.Iconimage, ForeColor);
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

	private void Collections_SelectedIndexChanged(object sender, EventArgs e)
	{
		Style.ButtonText = "   " + Collections.Text;
		if (eventHandler_0 != null)
		{
			eventHandler_0(this, null);
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

	private void Collections_SelectionChangeCommitted(object sender, EventArgs e)
	{
	}

	private void BunifuDropdown_Load(object sender, EventArgs e)
	{
		if (base.DesignMode)
		{
			BunifuCustomControl.initializeComponent(this);
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

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bunifu.Framework.UI.BunifuDropdown));
		this.Collections = new System.Windows.Forms.ComboBox();
		this.Style = new Bunifu.Framework.UI.BunifuFlatButton();
		base.SuspendLayout();
		this.Collections.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.Collections.FormattingEnabled = true;
		this.Collections.Location = new System.Drawing.Point(7, 12);
		this.Collections.Name = "Collections";
		this.Collections.Size = new System.Drawing.Size(201, 21);
		this.Collections.TabIndex = 1;
		this.Collections.SelectedIndexChanged += new System.EventHandler(Collections_SelectedIndexChanged);
		this.Collections.SelectionChangeCommitted += new System.EventHandler(Collections_SelectionChangeCommitted);
		this.Style.Activecolor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.Style.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.Style.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Style.BorderRadius = 0;
		this.Style.ButtonText = "     DropDown";
		this.Style.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Style.DisabledColor = System.Drawing.Color.Gray;
		this.Style.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Style.Iconcolor = System.Drawing.Color.Transparent;
		this.Style.Iconimage = null;
		this.Style.Iconimage_right = (System.Drawing.Image)resources.GetObject("Style.Iconimage_right");
		this.Style.Iconimage_right_Selected = null;
		this.Style.Iconimage_Selected = null;
		this.Style.IconMarginLeft = 0;
		this.Style.IconMarginRight = 0;
		this.Style.IconRightVisible = true;
		this.Style.IconRightZoom = 0.0;
		this.Style.IconVisible = true;
		this.Style.IconZoom = 90.0;
		this.Style.IsTab = false;
		this.Style.Location = new System.Drawing.Point(0, 0);
		this.Style.Name = "Style";
		this.Style.Normalcolor = System.Drawing.Color.FromArgb(46, 139, 87);
		this.Style.OnHovercolor = System.Drawing.Color.FromArgb(36, 129, 77);
		this.Style.OnHoverTextColor = System.Drawing.Color.White;
		this.Style.selected = false;
		this.Style.Size = new System.Drawing.Size(217, 35);
		this.Style.TabIndex = 2;
		this.Style.Text = "     DropDown";
		this.Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.Style.Textcolor = System.Drawing.Color.White;
		this.Style.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Style.Click += new System.EventHandler(Style_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.Transparent;
		base.Controls.Add(this.Style);
		base.Controls.Add(this.Collections);
		this.ForeColor = System.Drawing.Color.White;
		base.Name = "BunifuDropdown";
		base.Size = new System.Drawing.Size(217, 35);
		base.Load += new System.EventHandler(BunifuDropdown_Load);
		base.FontChanged += new System.EventHandler(BunifuDropdown_FontChanged);
		base.ForeColorChanged += new System.EventHandler(BunifuDropdown_ForeColorChanged);
		base.Resize += new System.EventHandler(BunifuDropdown_Resize);
		base.ResumeLayout(false);
	}
}
