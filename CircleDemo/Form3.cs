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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            GetResult();
        }

        private void GetResult()
        {
            string d = txt_d.Text.Trim();
            string h = txt_h.Text.Trim();
            string step = txt_step.Text.Trim();
            string intever = txt_intever.Text.Trim();
            string startLength = txt_startLength.Text.Trim();

            double dd = 0;// Convert.ToDouble(radius);
            double dh = 0;// Convert.ToDouble(step);
            double dintever = 0;// Convert.ToDouble(intever);
            double dstartlength = 0;
            double dstep = 0;

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

            double.TryParse(step, out dstep);
            if (step != "0" && dstep == 0)
            {
                MessageBox.Show("线条宽度必须为数字");
                return;
            }
            double.TryParse(intever, out dintever);
            if (intever != "0" && dintever == 0)
            {
                MessageBox.Show("间距必须为数字");
                return;
            }
            double.TryParse(startLength, out dstartlength);
            if (startLength != "0" && dstartlength == 0)
            {
                MessageBox.Show("预留宽度必须为数字");
                return;
            }

            Dictionary<double, double> dicList = GetXList(dd, dh, dintever, dstep, dstartlength);
            lbl_Result.Text = GetAllArea(dicList, dstep).ToString();
        }

        private Dictionary<double, double> GetXList(double d,double h, 
            double interval, double step, double startLength)
        {
            Dictionary<double, double> dicList = new Dictionary<double, double>();

            double x_temp = 0, x_low = 0, x_high = 0;
            x_temp = x_temp + startLength;

            while (x_temp < h - startLength)
            {
                x_low = (x_temp / h) * d;
                x_high = ((x_temp + step) / h) * d;
                dicList.Add(x_low, x_high);
                x_temp = x_temp + interval + step;
            }

            return dicList;
        }

        private double GetAllArea(Dictionary<double, double> dicList, double h)
        {
            double areaTotal = 0;

            foreach (var item in dicList) {
                areaTotal += GetSingleArea(item.Key, item.Value, h);
            }

            return areaTotal;
        }

        private double GetSingleArea(double upD, double downD, double h)
        {
            double area = 0;
            area = (upD + downD) * h / 2;
            return area;
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
                txt_step.Focus();
        }

        private void txt_step_TextChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = string.Empty;
        }

        private void txt_step_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_intever.Focus();
        }

        private void txt_intever_TextChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = string.Empty;
        }

        private void txt_intever_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_startLength.Focus();
        }

        private void txt_startLength_TextChanged(object sender, EventArgs e)
        {
            lbl_Result.Text = string.Empty;
        }

        private void txt_startLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetResult();
        }
    }
}
