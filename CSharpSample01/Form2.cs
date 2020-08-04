using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSample01
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();

			// ウインドウサイズ
			this.Size = new Size(300, 200);

			// タイトルバーを消す
			this.ControlBox = false;
            this.Text = String.Empty;

		}
	}
}
