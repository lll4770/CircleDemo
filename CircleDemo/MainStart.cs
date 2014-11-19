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
    public partial class MainStart : Form
    {
        public MainStart()
        {
            InitializeComponent();
        }

        private void btn_radius_Click(object sender, EventArgs e)
        {
            new 半圆中布条面积().Show();
        }

        private void btn_length_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
