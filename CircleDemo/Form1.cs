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
    public partial class 半圆中布条面积 : Form
    {
        public 半圆中布条面积()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetResult();
        }

        private void GetResult()
        {
            string radius = txt_radius.Text.Trim();
            string step = txt_step.Text.Trim();
            string intever = txt_interver.Text.Trim();
            string startLength = txt_startLength.Text.Trim();

            double dradius = 0;// Convert.ToDouble(radius);
            double dstep = 0;// Convert.ToDouble(step);
            double dintever = 0;// Convert.ToDouble(intever);
            double dstartlength = 0;

            double.TryParse(radius, out dradius);
            if (radius != "0" && dradius == 0)
            {
                MessageBox.Show("圆半径必须为数字");
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

            Dictionary<double, double> dicList = GetXList(dradius * 2, dintever, dstep,dstartlength);

            double areaResult = GetAllArea(dradius, dicList);

            lbl_result.Text = areaResult.ToString();
        }

        private Dictionary<double, double> GetXList(double R, double interval, double step,double startLength)
        {
            Dictionary<double, double> dicList = new Dictionary<double, double>();

            double x_temp = 0, x_low = 0, x_high = 0;
            x_temp = x_temp + startLength;
            while (x_temp < R - startLength) {
                x_low = x_temp;
                x_high = x_low + step;
                dicList.Add(x_low, x_high);
                x_temp = x_temp + interval + step;
            }

            return dicList;
        }

        private double GetAllArea(double r, Dictionary<double, double> dic)
        {
            double area = 0;
            foreach (var item in dic)
            {
                area += GetSingleArea(r, item.Key, item.Value);
            }

            return area;
        }

        private double GetSingleArea(double r, double low, double high)
        { 
            double singleArea = 0;

            singleArea = Math.Abs(GetValue(r - high, r) - GetValue(r - low, r));

            return singleArea;
        }

        private double GetValue(double x, double r)
        {
            return (x / 2) * Math.Sqrt(r * r - x * x) + (r * r / 2) * Math.Asin(x / r);
        }

        private void txt_interver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                txt_startLength.Focus();
            }
        }

        private void txt_radius_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                txt_step.Focus();
            }
        }

        private void txt_step_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                txt_interver.Focus();
            }
        }

        private void txt_radius_TextChanged(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;
        }

        private void txt_step_TextChanged(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;
        }

        private void txt_interver_TextChanged(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;
        }

        private void txt_startLength_TextChanged(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;
        }

        private void txt_startLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetResult();
            }
        }
    }
}
