using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1;

public class aaa : UserControl
{
	private IContainer icontainer_0;

	private Button button1;

	public aaa()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		new testForm().ShowDialog();
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
		this.button1 = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.button1.Location = new System.Drawing.Point(49, 57);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 0;
		this.button1.Text = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Click += new System.EventHandler(button1_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.button1);
		base.Name = "aaa";
		base.Size = new System.Drawing.Size(201, 131);
		base.ResumeLayout(false);
	}
}
