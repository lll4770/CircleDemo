namespace CircleDemo
{
    partial class MainStart
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
            this.btn_radius = new System.Windows.Forms.Button();
            this.btn_length = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_radius
            // 
            this.btn_radius.Location = new System.Drawing.Point(63, 24);
            this.btn_radius.Name = "btn_radius";
            this.btn_radius.Size = new System.Drawing.Size(150, 23);
            this.btn_radius.TabIndex = 0;
            this.btn_radius.Text = "求圆中分布的圆面积";
            this.btn_radius.UseVisualStyleBackColor = true;
            this.btn_radius.Click += new System.EventHandler(this.btn_radius_Click);
            // 
            // btn_length
            // 
            this.btn_length.Location = new System.Drawing.Point(63, 67);
            this.btn_length.Name = "btn_length";
            this.btn_length.Size = new System.Drawing.Size(150, 23);
            this.btn_length.TabIndex = 1;
            this.btn_length.Text = "求圆中分布的弦长";
            this.btn_length.UseVisualStyleBackColor = true;
            this.btn_length.Click += new System.EventHandler(this.btn_length_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(63, 207);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(150, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "退出程序";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "求三角形中分布的圆面积";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "求三角形中分布的弦长";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_length);
            this.Controls.Add(this.btn_radius);
            this.Name = "MainStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "主程序入口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_radius;
        private System.Windows.Forms.Button btn_length;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}