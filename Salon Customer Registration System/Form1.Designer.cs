namespace Salon_Customer_Registration_System
{
    partial class Login
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
            this.u_name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.lg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // u_name
            // 
            this.u_name.Location = new System.Drawing.Point(171, 96);
            this.u_name.Name = "u_name";
            this.u_name.Size = new System.Drawing.Size(139, 20);
            this.u_name.TabIndex = 0;
            this.u_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(171, 156);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(139, 20);
            this.password.TabIndex = 1;
            // 
            // lg_btn
            // 
            this.lg_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lg_btn.Location = new System.Drawing.Point(193, 208);
            this.lg_btn.Name = "lg_btn";
            this.lg_btn.Size = new System.Drawing.Size(81, 41);
            this.lg_btn.TabIndex = 2;
            this.lg_btn.Text = "Log";
            this.lg_btn.UseVisualStyleBackColor = false;
            this.lg_btn.Click += new System.EventHandler(this.lg_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Salon_Customer_Registration_System.Properties.Resources.blog_post_2015_11_29;
            this.ClientSize = new System.Drawing.Size(460, 401);
            this.Controls.Add(this.lg_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.u_name);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox u_name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button lg_btn;
    }
}

