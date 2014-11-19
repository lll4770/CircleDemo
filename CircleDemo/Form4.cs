using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleDemo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txt_Save_Click(object sender, EventArgs e)
        {
            GetResult();
        }

        public void GetResult()
        {
            string d = txt_d.Text.Trim();
            string h = txt_h.Text.Trim();
            string intever = txt_inveter.Text.Trim();

            double dd = 0;// Convert.ToDouble(radius);
            double dh = 0;// Convert.ToDouble(step);
            double dintever = 0;// Convert.ToDouble(intever);

            double.TryParse(d, out dd);
            if (d != "0" && dd == 0)
            {
                MessageBox.Show("三角形底必须为数字");
                return;
            }
            double.TryParse(h, out dh);
            if (h != "0" && dh == 0)
            {
                MessageBox.Show("三角形高必须为数字");
                return;
            }

            double.TryParse(intever, out dintever);
            if (intever != "0" && dintever == 0)
            {
                MessageBox.Show("间距必须为数字");
                return;
            }

            IList<double> list = GetList(dd, dh, dintever);

            lbl_Result.Text = GetTotalLength(list).ToString();
        }

        public IList<double> GetList(double d, double h, double intever)
        {
            IList<double> list = new List<double>();

            double x_temp = 0;
            double x_line = 0;
            while (x_temp < h)
            {
                x_line = x_temp * d / h;
                x_temp += intever;
                list.Add(x_line);
            }

            return list;
        }

        public double GetTotalLength(IList<double> list)
        {
            double totalLength = 0;

            foreach (var item in list) {
                totalLength += item;
            }

            return totalLength;
        }

        private void txt_d_TextChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = string.Empty;
        }

        private void txt_d_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_h.Focus();
        }

        private void txt_h_TextChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = string.Empty;
        }

        private void txt_h_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_inveter.Focus();
        }

        private void txt_inveter_TextChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = string.Empty;
        }

        private void txt_inveter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetResult();
        }
    }
}
