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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_Save_Click(object sender, EventArgs e)
        {
            GetResult();
        }

        private void GetResult()
        {
            string radius = txt_raidus.Text.Trim();
            string step = txt_step.Text.Trim();

            double dradius = 0;// Convert.ToDouble(radius);
            double dstep = 0;// Convert.ToDouble(step);

            double.TryParse(radius, out dradius);
            if (radius != "0" && dradius == 0)
            {
                MessageBox.Show("圆半径必须为数字");
                return;
            }

            double.TryParse(step, out dstep);
            if (step != "0" && dstep == 0)
            {
                MessageBox.Show("间距宽度必须为数字");
                return;
            }

            IList<double> x_lineList = GetXList(dradius, dstep);

            double totalLength = 0;

            for (int i = 0; i < x_lineList.Count; i++)
            {
                if (x_lineList[i] == dradius)
                {
                    totalLength += x_lineList[i];
                }
                else
                {
                    totalLength += x_lineList[i] * 2;
                }
            }
            lbl_result.Text = totalLength.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="R">半径</param>
        /// <param name="step">间距</param>
        /// <returns></returns>
        private IList<double> GetXList(double R, double step)
        {
            IList<double> lineList = new List<double>();

            double x_temp = 0, x_line =0;
            while (x_temp <= R)
            {
                x_line = x_temp;
                x_temp = x_temp + step;

                lineList.Add(x_line);
            }

            return lineList;
        }

        private void txt_raidus_TextChanged(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;
        }

        private void txt_raidus_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                txt_step.Focus();
        }

        private void txt_step_TextChanged(object sender, EventArgs e)
        {
            lbl_result.Text = string.Empty;
        }

        private void txt_step_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetResult();
        }
    }
}
