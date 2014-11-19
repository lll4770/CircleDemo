namespace CircleDemo
{
    partial class Form2
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
            this.txt_raidus = new System.Windows.Forms.TextBox();
            this.txt_step = new System.Windows.Forms.TextBox();
            this.txt_Save = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "圆半径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "间距：";
            // 
            // txt_raidus
            // 
            this.txt_raidus.Location = new System.Drawing.Point(122, 49);
            this.txt_raidus.Name = "txt_raidus";
            this.txt_raidus.Size = new System.Drawing.Size(100, 21);
            this.txt_raidus.TabIndex = 2;
            this.txt_raidus.TextChanged += new System.EventHandler(this.txt_raidus_TextChanged);
            this.txt_raidus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_raidus_KeyDown);
            // 
            // txt_step
            // 
            this.txt_step.Location = new System.Drawing.Point(122, 111);
            this.txt_step.Name = "txt_step";
            this.txt_step.Size = new System.Drawing.Size(100, 21);
            this.txt_step.TabIndex = 3;
            this.txt_step.TextChanged += new System.EventHandler(this.txt_step_TextChanged);
            this.txt_step.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_step_KeyDown);
            // 
            // txt_Save
            // 
            this.txt_Save.Location = new System.Drawing.Point(23, 184);
            this.txt_Save.Name = "txt_Save";
            this.txt_Save.Size = new System.Drawing.Size(75, 23);
            this.txt_Save.TabIndex = 4;
            this.txt_Save.Text = "戳我";
            this.txt_Save.UseVisualStyleBackColor = true;
            this.txt_Save.Click += new System.EventHandler(this.txt_Save_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(120, 189);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 12);
            this.lbl_result.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_Save);
            this.Controls.Add(this.txt_step);
            this.Controls.Add(this.txt_raidus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圆弦长";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_raidus;
        private System.Windows.Forms.TextBox txt_step;
        private System.Windows.Forms.Button txt_Save;
        private System.Windows.Forms.Label lbl_result;
    }
}