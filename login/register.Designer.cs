namespace login
{
    partial class register
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
            this.showpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_btn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.registerbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.comfrimpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showpass.CheckedState.BorderRadius = 0;
            this.showpass.CheckedState.BorderThickness = 0;
            this.showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showpass.CheckMarkColor = System.Drawing.Color.Transparent;
            this.showpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpass.Font = new System.Drawing.Font("Microsoft Uighur", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showpass.Location = new System.Drawing.Point(185, 242);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(92, 26);
            this.showpass.TabIndex = 16;
            this.showpass.Text = "show password";
            this.showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showpass.UncheckedState.BorderRadius = 0;
            this.showpass.UncheckedState.BorderThickness = 0;
            this.showpass.UncheckedState.FillColor = System.Drawing.Color.Silver;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // password
            // 
            this.password.BorderRadius = 20;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.Location = new System.Drawing.Point(49, 145);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.PlaceholderText = "password";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(199, 36);
            this.password.TabIndex = 15;
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.AutoRoundedCorners = true;
            this.username.BorderRadius = 17;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.Location = new System.Drawing.Point(49, 87);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "username";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(199, 36);
            this.username.TabIndex = 14;
            // 
            // login_btn
            // 
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(-17, 451);
            this.login_btn.Name = "login_btn";
            this.login_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.login_btn.Size = new System.Drawing.Size(339, 152);
            this.login_btn.TabIndex = 13;
            this.login_btn.Text = " if you have an account ?login!";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.Animated = true;
            this.registerbtn.AutoRoundedCorners = true;
            this.registerbtn.BorderRadius = 21;
            this.registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerbtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.White;
            this.registerbtn.Location = new System.Drawing.Point(71, 321);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(177, 44);
            this.registerbtn.TabIndex = 12;
            this.registerbtn.Text = "register";
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(346, -49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "login form";
            // 
            // clearbtn
            // 
            this.clearbtn.Animated = true;
            this.clearbtn.AutoRoundedCorners = true;
            this.clearbtn.BackColor = System.Drawing.Color.Transparent;
            this.clearbtn.BorderRadius = 18;
            this.clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearbtn.FillColor = System.Drawing.Color.White;
            this.clearbtn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.clearbtn.ForeColor = System.Drawing.Color.Gray;
            this.clearbtn.Location = new System.Drawing.Point(71, 371);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(177, 39);
            this.clearbtn.TabIndex = 10;
            this.clearbtn.Text = "clear";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // comfrimpass
            // 
            this.comfrimpass.BorderRadius = 20;
            this.comfrimpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comfrimpass.DefaultText = "";
            this.comfrimpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.comfrimpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.comfrimpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.comfrimpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.comfrimpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comfrimpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comfrimpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comfrimpass.Location = new System.Drawing.Point(49, 200);
            this.comfrimpass.Name = "comfrimpass";
            this.comfrimpass.PasswordChar = '•';
            this.comfrimpass.PlaceholderText = "comfrim password";
            this.comfrimpass.SelectedText = "";
            this.comfrimpass.Size = new System.Drawing.Size(199, 36);
            this.comfrimpass.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(99, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "join us!";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 544);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comfrimpass);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CheckBox showpass;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2GradientCircleButton login_btn;
        private Guna.UI2.WinForms.Guna2GradientButton registerbtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private Guna.UI2.WinForms.Guna2TextBox comfrimpass;
        private System.Windows.Forms.Label label2;
    }
}