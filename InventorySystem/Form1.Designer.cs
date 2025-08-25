namespace InventorySystem
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.createAccount_btn = new Guna.UI2.WinForms.Guna2Button();
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.password_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.user_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.eyeImage_btn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(234, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(383, 33);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Electronics Inventory System";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.eyeImage_btn);
            this.guna2GroupBox1.Controls.Add(this.createAccount_btn);
            this.guna2GroupBox1.Controls.Add(this.login_btn);
            this.guna2GroupBox1.Controls.Add(this.password_txt);
            this.guna2GroupBox1.Controls.Add(this.user_txt);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 65);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(727, 388);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Login";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // createAccount_btn
            // 
            this.createAccount_btn.AutoRoundedCorners = true;
            this.createAccount_btn.CausesValidation = false;
            this.createAccount_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAccount_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAccount_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAccount_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAccount_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.createAccount_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.createAccount_btn.ForeColor = System.Drawing.Color.White;
            this.createAccount_btn.Location = new System.Drawing.Point(386, 224);
            this.createAccount_btn.Name = "createAccount_btn";
            this.createAccount_btn.Size = new System.Drawing.Size(159, 35);
            this.createAccount_btn.TabIndex = 5;
            this.createAccount_btn.Text = "Create Account";
            this.createAccount_btn.Click += new System.EventHandler(this.createAccount_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.AutoRoundedCorners = true;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(221, 224);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(159, 35);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // password_txt
            // 
            this.password_txt.AutoRoundedCorners = true;
            this.password_txt.BorderColor = System.Drawing.Color.Black;
            this.password_txt.BorderThickness = 2;
            this.password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txt.DefaultText = "";
            this.password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.password_txt.ForeColor = System.Drawing.Color.Black;
            this.password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txt.Location = new System.Drawing.Point(221, 162);
            this.password_txt.Name = "password_txt";
            this.password_txt.PlaceholderText = "";
            this.password_txt.SelectedText = "";
            this.password_txt.Size = new System.Drawing.Size(317, 41);
            this.password_txt.TabIndex = 3;
            this.password_txt.UseSystemPasswordChar = true;
            this.password_txt.Validating += new System.ComponentModel.CancelEventHandler(this.username_validating);
            // 
            // user_txt
            // 
            this.user_txt.AutoRoundedCorners = true;
            this.user_txt.BorderColor = System.Drawing.Color.Black;
            this.user_txt.BorderThickness = 2;
            this.user_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_txt.DefaultText = "";
            this.user_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.user_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.user_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_txt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.user_txt.ForeColor = System.Drawing.Color.Black;
            this.user_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_txt.Location = new System.Drawing.Point(221, 97);
            this.user_txt.Name = "user_txt";
            this.user_txt.PlaceholderText = "";
            this.user_txt.SelectedText = "";
            this.user_txt.Size = new System.Drawing.Size(317, 41);
            this.user_txt.TabIndex = 2;
            this.user_txt.Validating += new System.ComponentModel.CancelEventHandler(this.username_validating);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(138, 162);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(73, 23);
            this.guna2HtmlLabel3.TabIndex = 1;
            this.guna2HtmlLabel3.Text = "Password:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(138, 97);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(77, 23);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Username:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // eyeImage_btn
            // 
            this.eyeImage_btn.BackColor = System.Drawing.Color.White;
            this.eyeImage_btn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.eyeImage_btn.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.eyeImage_btn.Image = global::InventorySystem.Properties.Resources.icons8_eye_25;
            this.eyeImage_btn.ImageOffset = new System.Drawing.Point(0, 0);
            this.eyeImage_btn.ImageRotate = 0F;
            this.eyeImage_btn.ImageSize = new System.Drawing.Size(25, 25);
            this.eyeImage_btn.Location = new System.Drawing.Point(505, 170);
            this.eyeImage_btn.Name = "eyeImage_btn";
            this.eyeImage_btn.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.eyeImage_btn.Size = new System.Drawing.Size(25, 26);
            this.eyeImage_btn.TabIndex = 6;
            this.eyeImage_btn.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(756, 476);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.Shown += new System.EventHandler(this.loginForm_Shown);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox password_txt;
        private Guna.UI2.WinForms.Guna2TextBox user_txt;
        private Guna.UI2.WinForms.Guna2Button login_btn;
        private Guna.UI2.WinForms.Guna2Button createAccount_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ImageButton eyeImage_btn;
    }
}

