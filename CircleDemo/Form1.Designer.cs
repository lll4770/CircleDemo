namespace CircleDemo
{
    partial class 半圆中布条面积
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_radius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_step = new System.Windows.Forms.TextBox();
            this.txt_interver = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_startLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "圆半径：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "生成结果";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_radius
            // 
            this.txt_radius.Location = new System.Drawing.Point(130, 45);
            this.txt_radius.Name = "txt_radius";
            this.txt_radius.Size = new System.Drawing.Size(100, 21);
            this.txt_radius.TabIndex = 2;
            this.txt_radius.TextChanged += new System.EventHandler(this.txt_radius_TextChanged);
            this.txt_radius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_radius_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "线条宽度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "间距：";
            // 
            // txt_step
            // 
            this.txt_step.Location = new System.Drawing.Point(130, 86);
            this.txt_step.Name = "txt_step";
            this.txt_step.Size = new System.Drawing.Size(100, 21);
            this.txt_step.TabIndex = 5;
            this.txt_step.TextChanged += new System.EventHandler(this.txt_step_TextChanged);
            this.txt_step.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_step_KeyDown);
            // 
            // txt_interver
            // 
            this.txt_interver.Location = new System.Drawing.Point(130, 127);
            this.txt_interver.Name = "txt_interver";
            this.txt_interver.Size = new System.Drawing.Size(100, 21);
            this.txt_interver.TabIndex = 6;
            this.txt_interver.TextChanged += new System.EventHandler(this.txt_interver_TextChanged);
            this.txt_interver.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_interver_KeyDown);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(133, 220);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 12);
            this.lbl_result.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "预留长度";
            // 
            // txt_startLength
            // 
            this.txt_startLength.Location = new System.Drawing.Point(130, 172);
            this.txt_startLength.Name = "txt_startLength";
            this.txt_startLength.Size = new System.Drawing.Size(100, 21);
            this.txt_startLength.TabIndex = 9;
            this.txt_startLength.TextChanged += new System.EventHandler(this.txt_startLength_TextChanged);
            this.txt_startLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_startLength_KeyDown);
            // 
            // 半圆中布条面积
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 276);
            this.Controls.Add(this.txt_startLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_interver);
            this.Controls.Add(this.txt_step);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_radius);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "半圆中布条面积";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "半圆中布条面积";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_radius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_step;
        private System.Windows.Forms.TextBox txt_interver;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_startLength;
    }
}

