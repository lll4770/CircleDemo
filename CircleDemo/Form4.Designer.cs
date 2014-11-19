namespace CircleDemo
{
    partial class Form4
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
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_h = new System.Windows.Forms.TextBox();
            this.txt_inveter = new System.Windows.Forms.TextBox();
            this.txt_Save = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "三角形底：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "三角形高：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "间距：";
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(122, 37);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 21);
            this.txt_d.TabIndex = 3;
            this.txt_d.TextChanged += new System.EventHandler(this.txt_d_TextChanged);
            this.txt_d.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_d_KeyDown);
            // 
            // txt_h
            // 
            this.txt_h.Location = new System.Drawing.Point(122, 82);
            this.txt_h.Name = "txt_h";
            this.txt_h.Size = new System.Drawing.Size(100, 21);
            this.txt_h.TabIndex = 4;
            this.txt_h.TextChanged += new System.EventHandler(this.txt_h_TextChanged);
            this.txt_h.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_h_KeyDown);
            // 
            // txt_inveter
            // 
            this.txt_inveter.Location = new System.Drawing.Point(122, 137);
            this.txt_inveter.Name = "txt_inveter";
            this.txt_inveter.Size = new System.Drawing.Size(100, 21);
            this.txt_inveter.TabIndex = 5;
            this.txt_inveter.TextChanged += new System.EventHandler(this.txt_inveter_TextChanged);
            this.txt_inveter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_inveter_KeyDown);
            // 
            // txt_Save
            // 
            this.txt_Save.Location = new System.Drawing.Point(37, 203);
            this.txt_Save.Name = "txt_Save";
            this.txt_Save.Size = new System.Drawing.Size(75, 23);
            this.txt_Save.TabIndex = 6;
            this.txt_Save.Text = "戳我";
            this.txt_Save.UseVisualStyleBackColor = true;
            this.txt_Save.Click += new System.EventHandler(this.txt_Save_Click);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(137, 208);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(0, 12);
            this.lbl_Result.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txt_Save);
            this.Controls.Add(this.txt_inveter);
            this.Controls.Add(this.txt_h);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "三角形弦长";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_h;
        private System.Windows.Forms.TextBox txt_inveter;
        private System.Windows.Forms.Button txt_Save;
        private System.Windows.Forms.Label lbl_Result;
    }
}