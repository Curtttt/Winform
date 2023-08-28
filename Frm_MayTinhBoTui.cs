using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Frm_MayTinhBoTui : Form
    {
        public Frm_MayTinhBoTui()
        {
            InitializeComponent();
        }

        string phep;
        private void num_click(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            txt.Text += num.Text;
        }

        private void del(object sender, EventArgs e)
        {
            txt.Clear();
        }

        private void tinh(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            phep = btn.Text;
            txt.Text += " " + phep + " ";
        }

        private void show(object sender, EventArgs e)
        {
            string[] lst = txt.Text.Split(' ');

            switch (lst[1])
            {
                case "+":
                    txt.Text = (int.Parse(lst[0]) + int.Parse(lst[2])).ToString();
                    break;
                case "-":
                    txt.Text = (int.Parse(lst[0]) - int.Parse(lst[2])).ToString();
                    break;
                case "x":
                    txt.Text = (int.Parse(lst[0]) * int.Parse(lst[2])).ToString();
                    break;
                case "/":
                    txt.Text = (float.Parse(lst[0]) / float.Parse(lst[2])).ToString();
                    break;
            }
        }
    }
}
