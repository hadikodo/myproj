namespace myproj
{
    partial class Register
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
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conf_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_txt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.username_txt.Location = new System.Drawing.Point(109, 57);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(217, 33);
            this.username_txt.TabIndex = 0;
            this.username_txt.Text = "Username";
            this.username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username_txt.Click += new System.EventHandler(this.username_txt_Click);
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_txt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pass_txt.Location = new System.Drawing.Point(109, 96);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(217, 33);
            this.pass_txt.TabIndex = 1;
            this.pass_txt.Text = "Password";
            this.pass_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pass_txt.Click += new System.EventHandler(this.pass_txt_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.AutoSize = true;
            this.reg_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.reg_btn.FlatAppearance.BorderSize = 0;
            this.reg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.reg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.Location = new System.Drawing.Point(109, 185);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(213, 49);
            this.reg_btn.TabIndex = 5;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(117, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "password must be between 8-16 characters and must have * or # or @";
            // 
            // conf_txt
            // 
            this.conf_txt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf_txt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.conf_txt.Location = new System.Drawing.Point(109, 135);
            this.conf_txt.Name = "conf_txt";
            this.conf_txt.Size = new System.Drawing.Size(217, 33);
            this.conf_txt.TabIndex = 8;
            this.conf_txt.Text = "Confirm Password";
            this.conf_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.conf_txt.Click += new System.EventHandler(this.conf_txt_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(424, 336);
            this.Controls.Add(this.conf_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.username_txt);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox conf_txt;
    }
}

