﻿namespace CircleDemo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.txt_step = new System.Windows.Forms.TextBox();
            this.txt_intever = new System.Windows.Forms.TextBox();
            this.txt_startLength = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "三角形底：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "三角形高：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "布条宽度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "间距：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "预留长度：";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(135, 26);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 21);
            this.txt_d.TabIndex = 5;
            this.txt_d.TextChanged += new System.EventHandler(this.txt_d_TextChanged);
            this.txt_d.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_d_KeyDown);
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(135, 66);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(100, 21);
            this.txt_h.TabIndex = 6;
            this.txt_h.TextChanged += new System.EventHandler(this.txt_h_TextChanged);
            this.txt_h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_h_KeyDown);
            // 
            // txt_step
            // 
            this.txt_step.Location = new System.Drawing.Point(135, 106);
            this.txt_step.Name = "txt_step";
            this.txt_step.Size = new System.Drawing.Size(100, 21);
            this.txt_step.TabIndex = 7;
            this.txt_step.TextChanged += new System.EventHandler(this.txt_step_TextChanged);
            this.txt_step.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_step_KeyDown);
            // 
            // txt_intever
            // 
            this.txt_intever.Location = new System.Drawing.Point(135, 151);
            this.txt_intever.Name = "txt_intever";
            this.txt_intever.Size = new System.Drawing.Size(100, 21);
            this.txt_intever.TabIndex = 8;
            this.txt_intever.TextChanged += new System.EventHandler(this.txt_intever_TextChanged);
            this.txt_intever.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_intever_KeyDown);
            // 
            // txt_startLength
            // 
            this.txt_startLength.Location = new System.Drawing.Point(135, 194);
            this.txt_startLength.Name = "txt_startLength";
            this.txt_startLength.Size = new System.Drawing.Size(100, 21);
            this.txt_startLength.TabIndex = 9;
            this.txt_startLength.TextChanged += new System.EventHandler(this.txt_startLength_TextChanged);
            this.txt_startLength.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_startLength_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(38, 248);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "戳我";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(146, 253);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(0, 12);
            this.lbl_Result.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 294);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_startLength);
            this.Controls.Add(this.txt_intever);
            this.Controls.Add(this.txt_step);
            this.Controls.Add(this.txt_h);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三角形布条面积";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.TextBox txt_step;
        private System.Windows.Forms.TextBox txt_intever;
        private System.Windows.Forms.TextBox txt_startLength;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Result;
    }
}