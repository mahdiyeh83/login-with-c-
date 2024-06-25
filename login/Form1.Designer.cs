namespace login
{
    partial class loginform
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
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.signup_btn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.showpass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            this.clearbtn.Location = new System.Drawing.Point(99, 396);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(119, 39);
            this.clearbtn.TabIndex = 1;
            this.clearbtn.Text = "clear";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(93, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "login form";
            // 
            // login
            // 
            this.login.Animated = true;
            this.login.AutoRoundedCorners = true;
            this.login.BorderRadius = 21;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(99, 346);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(119, 44);
            this.login.TabIndex = 4;
            this.login.Text = "login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(-22, 446);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.signup_btn.Size = new System.Drawing.Size(339, 152);
            this.signup_btn.TabIndex = 5;
            this.signup_btn.Text = " if you don\'t have an account ?sign up!";
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
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
            this.username.Location = new System.Drawing.Point(45, 112);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderText = "username";
            this.username.SelectedText = "";
            this.username.Size = new System.Drawing.Size(220, 36);
            this.username.TabIndex = 6;
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
            this.password.Location = new System.Drawing.Point(45, 170);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.PlaceholderText = "password";
            this.password.SelectedText = "";
            this.password.Size = new System.Drawing.Size(220, 36);
            this.password.TabIndex = 7;
            this.password.UseSystemPasswordChar = true;
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
            this.showpass.Location = new System.Drawing.Point(188, 223);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(92, 26);
            this.showpass.TabIndex = 8;
            this.showpass.Text = "show password";
            this.showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showpass.UncheckedState.BorderRadius = 0;
            this.showpass.UncheckedState.BorderThickness = 0;
            this.showpass.UncheckedState.FillColor = System.Drawing.Color.Silver;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // register
            // 
            this.register.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this.register.AutoSize = true;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.register.Location = new System.Drawing.Point(157, 264);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(123, 13);
            this.register.TabIndex = 9;
            this.register.TabStop = true;
            this.register.Text = "forget your password?";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 544);
            this.Controls.Add(this.register);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearbtn);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton login;
        private Guna.UI2.WinForms.Guna2GradientCircleButton signup_btn;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2CheckBox showpass;
        private System.Windows.Forms.LinkLabel register;
    }
}

