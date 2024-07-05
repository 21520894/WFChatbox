namespace CodeProject_B1
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_email = new TextBox();
            btn_login = new Button();
            pn_login = new Panel();
            lbl_forgot_pass = new LinkLabel();
            label4 = new Label();
            panel3 = new Panel();
            txt_password = new TextBox();
            panel2 = new Panel();
            link_signup = new LinkLabel();
            label5 = new Label();
            btn_fb_login = new Button();
            pn_forgot = new Panel();
            lbl_re_login = new LinkLabel();
            label6 = new Label();
            panel6 = new Panel();
            txt_recover_email = new TextBox();
            lbl_signup = new LinkLabel();
            label7 = new Label();
            label8 = new Label();
            btn_new_pass = new Button();
            label9 = new Label();
            pn_signup = new Panel();
            panel1 = new Panel();
            txt_signup_pass = new TextBox();
            label10 = new Label();
            pic_user = new PictureBox();
            panel9 = new Panel();
            linkLabel3 = new LinkLabel();
            label17 = new Label();
            panel10 = new Panel();
            txt_phone = new TextBox();
            label18 = new Label();
            panel8 = new Panel();
            txt_signup_email = new TextBox();
            label16 = new Label();
            label11 = new Label();
            panel7 = new Panel();
            txt_name = new TextBox();
            lbl_s_re_login = new LinkLabel();
            label12 = new Label();
            label13 = new Label();
            btn_signup = new Button();
            label14 = new Label();
            pn_login.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pn_forgot.SuspendLayout();
            panel6.SuspendLayout();
            pn_signup.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user).BeginInit();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 15F, FontStyle.Bold);
            label1.Location = new Point(33, 51);
            label1.Name = "label1";
            label1.Size = new Size(256, 31);
            label1.TabIndex = 0;
            label1.Text = "Login to your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 10F);
            label2.Location = new Point(31, 144);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10F);
            label3.Location = new Point(33, 240);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.AcceptsReturn = true;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.CausesValidation = false;
            txt_email.Font = new Font("Roboto", 10F);
            txt_email.Location = new Point(8, 9);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(282, 21);
            txt_email.TabIndex = 3;
            txt_email.Tag = "";
            txt_email.Text = "matactap2@gmail.com";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(96, 98, 249);
            btn_login.Font = new Font("Roboto", 10F);
            btn_login.ForeColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(33, 384);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(302, 41);
            btn_login.TabIndex = 6;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pn_login
            // 
            pn_login.BackColor = Color.White;
            pn_login.Controls.Add(lbl_forgot_pass);
            pn_login.Controls.Add(label4);
            pn_login.Controls.Add(panel3);
            pn_login.Controls.Add(panel2);
            pn_login.Controls.Add(link_signup);
            pn_login.Controls.Add(label5);
            pn_login.Controls.Add(btn_fb_login);
            pn_login.Controls.Add(label1);
            pn_login.Controls.Add(btn_login);
            pn_login.Controls.Add(label2);
            pn_login.Controls.Add(label3);
            pn_login.Font = new Font("Roboto", 7.8F);
            pn_login.Location = new Point(0, 0);
            pn_login.Name = "pn_login";
            pn_login.Size = new Size(403, 671);
            pn_login.TabIndex = 7;
            pn_login.Paint += pn_login_Paint;
            // 
            // lbl_forgot_pass
            // 
            lbl_forgot_pass.AutoSize = true;
            lbl_forgot_pass.Font = new Font("Roboto", 8F);
            lbl_forgot_pass.Location = new Point(218, 345);
            lbl_forgot_pass.Name = "lbl_forgot_pass";
            lbl_forgot_pass.Size = new Size(122, 18);
            lbl_forgot_pass.TabIndex = 11;
            lbl_forgot_pass.TabStop = true;
            lbl_forgot_pass.Text = "Forgot password?";
            lbl_forgot_pass.LinkClicked += lbl_forget_pass_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 8F);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(33, 103);
            label4.Name = "label4";
            label4.Size = new Size(283, 18);
            label4.TabIndex = 10;
            label4.Text = "Welcome back! Please log into your account.";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txt_password);
            panel3.Location = new Point(33, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 40);
            panel3.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.AcceptsReturn = true;
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.CausesValidation = false;
            txt_password.Font = new Font("Roboto", 10F);
            txt_password.Location = new Point(8, 9);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(282, 21);
            txt_password.TabIndex = 3;
            txt_password.Tag = "";
            txt_password.Text = "123456";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txt_email);
            panel2.Location = new Point(33, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 40);
            panel2.TabIndex = 0;
            // 
            // link_signup
            // 
            link_signup.AutoSize = true;
            link_signup.Font = new Font("Roboto", 10F);
            link_signup.Location = new Point(202, 533);
            link_signup.Name = "link_signup";
            link_signup.Size = new Size(125, 22);
            link_signup.TabIndex = 9;
            link_signup.TabStop = true;
            link_signup.Text = "Create account";
            link_signup.LinkClicked += link_signup_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10F);
            label5.Location = new Point(45, 533);
            label5.Name = "label5";
            label5.Size = new Size(171, 22);
            label5.TabIndex = 8;
            label5.Text = "Need a new account?";
            // 
            // btn_fb_login
            // 
            btn_fb_login.BackColor = Color.FromArgb(96, 98, 249);
            btn_fb_login.Font = new Font("Roboto", 10F);
            btn_fb_login.ForeColor = SystemColors.ControlLightLight;
            btn_fb_login.Location = new Point(33, 453);
            btn_fb_login.Name = "btn_fb_login";
            btn_fb_login.Size = new Size(302, 41);
            btn_fb_login.TabIndex = 7;
            btn_fb_login.Text = "Log In with Facebook";
            btn_fb_login.UseVisualStyleBackColor = false;
            // 
            // pn_forgot
            // 
            pn_forgot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pn_forgot.BackColor = Color.White;
            pn_forgot.Controls.Add(lbl_re_login);
            pn_forgot.Controls.Add(label6);
            pn_forgot.Controls.Add(panel6);
            pn_forgot.Controls.Add(lbl_signup);
            pn_forgot.Controls.Add(label7);
            pn_forgot.Controls.Add(label8);
            pn_forgot.Controls.Add(btn_new_pass);
            pn_forgot.Controls.Add(label9);
            pn_forgot.Font = new Font("Roboto", 7.8F);
            pn_forgot.Location = new Point(0, 0);
            pn_forgot.Name = "pn_forgot";
            pn_forgot.Size = new Size(403, 683);
            pn_forgot.TabIndex = 11;
            pn_forgot.Visible = false;
            // 
            // lbl_re_login
            // 
            lbl_re_login.AutoSize = true;
            lbl_re_login.Font = new Font("Roboto", 8F);
            lbl_re_login.Location = new Point(233, 244);
            lbl_re_login.Name = "lbl_re_login";
            lbl_re_login.Size = new Size(102, 18);
            lbl_re_login.TabIndex = 12;
            lbl_re_login.TabStop = true;
            lbl_re_login.Text = "Return to log in";
            lbl_re_login.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 8F);
            label6.ForeColor = SystemColors.ActiveBorder;
            label6.Location = new Point(33, 103);
            label6.Name = "label6";
            label6.Size = new Size(253, 18);
            label6.TabIndex = 10;
            label6.Text = "Please enter your email to take the code";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Window;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(txt_recover_email);
            panel6.Location = new Point(33, 184);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 40);
            panel6.TabIndex = 0;
            // 
            // txt_recover_email
            // 
            txt_recover_email.AcceptsReturn = true;
            txt_recover_email.BorderStyle = BorderStyle.None;
            txt_recover_email.CausesValidation = false;
            txt_recover_email.Font = new Font("Roboto", 10F);
            txt_recover_email.Location = new Point(8, 9);
            txt_recover_email.Name = "txt_recover_email";
            txt_recover_email.Size = new Size(282, 21);
            txt_recover_email.TabIndex = 3;
            txt_recover_email.Tag = "";
            txt_recover_email.Text = "fakerhunghshs@gmail.com";
            // 
            // lbl_signup
            // 
            lbl_signup.AutoSize = true;
            lbl_signup.Font = new Font("Roboto", 10F);
            lbl_signup.Location = new Point(202, 533);
            lbl_signup.Name = "lbl_signup";
            lbl_signup.Size = new Size(125, 22);
            lbl_signup.TabIndex = 9;
            lbl_signup.TabStop = true;
            lbl_signup.Text = "Create account";
            lbl_signup.LinkClicked += lbl_signup_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10F);
            label7.Location = new Point(45, 533);
            label7.Name = "label7";
            label7.Size = new Size(171, 22);
            label7.TabIndex = 8;
            label7.Text = "Need a new account?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 15F, FontStyle.Bold);
            label8.Location = new Point(33, 51);
            label8.Name = "label8";
            label8.Size = new Size(256, 31);
            label8.TabIndex = 0;
            label8.Text = "Login to your account";
            // 
            // btn_new_pass
            // 
            btn_new_pass.BackColor = Color.FromArgb(96, 98, 249);
            btn_new_pass.Font = new Font("Roboto", 10F);
            btn_new_pass.ForeColor = SystemColors.ControlLightLight;
            btn_new_pass.Location = new Point(33, 275);
            btn_new_pass.Name = "btn_new_pass";
            btn_new_pass.Size = new Size(302, 41);
            btn_new_pass.TabIndex = 6;
            btn_new_pass.Text = "Send code";
            btn_new_pass.UseVisualStyleBackColor = false;
            btn_new_pass.Click += btn_new_pass_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 10F);
            label9.Location = new Point(31, 144);
            label9.Name = "label9";
            label9.Size = new Size(52, 22);
            label9.TabIndex = 1;
            label9.Text = "Email";
            // 
            // pn_signup
            // 
            pn_signup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pn_signup.BackColor = Color.White;
            pn_signup.Controls.Add(panel1);
            pn_signup.Controls.Add(label10);
            pn_signup.Controls.Add(pic_user);
            pn_signup.Controls.Add(panel9);
            pn_signup.Controls.Add(label17);
            pn_signup.Controls.Add(panel10);
            pn_signup.Controls.Add(label18);
            pn_signup.Controls.Add(panel8);
            pn_signup.Controls.Add(label16);
            pn_signup.Controls.Add(label11);
            pn_signup.Controls.Add(panel7);
            pn_signup.Controls.Add(lbl_s_re_login);
            pn_signup.Controls.Add(label12);
            pn_signup.Controls.Add(label13);
            pn_signup.Controls.Add(btn_signup);
            pn_signup.Controls.Add(label14);
            pn_signup.Font = new Font("Roboto", 7.8F);
            pn_signup.Location = new Point(0, 0);
            pn_signup.Name = "pn_signup";
            pn_signup.Size = new Size(403, 671);
            pn_signup.TabIndex = 12;
            pn_signup.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_signup_pass);
            panel1.Location = new Point(35, 300);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 40);
            panel1.TabIndex = 18;
            // 
            // txt_signup_pass
            // 
            txt_signup_pass.AcceptsReturn = true;
            txt_signup_pass.BorderStyle = BorderStyle.None;
            txt_signup_pass.CausesValidation = false;
            txt_signup_pass.Font = new Font("Roboto", 10F);
            txt_signup_pass.Location = new Point(8, 9);
            txt_signup_pass.Name = "txt_signup_pass";
            txt_signup_pass.PasswordChar = '*';
            txt_signup_pass.Size = new Size(282, 21);
            txt_signup_pass.TabIndex = 3;
            txt_signup_pass.Tag = "";
            txt_signup_pass.Text = "123456";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 10F);
            label10.Location = new Point(32, 275);
            label10.Name = "label10";
            label10.Size = new Size(87, 22);
            label10.TabIndex = 19;
            label10.Text = "Password";
            // 
            // pic_user
            // 
            pic_user.BackgroundImage = (Image)resources.GetObject("pic_user.BackgroundImage");
            pic_user.BackgroundImageLayout = ImageLayout.Stretch;
            pic_user.Location = new Point(274, 464);
            pic_user.Name = "pic_user";
            pic_user.Size = new Size(52, 40);
            pic_user.TabIndex = 17;
            pic_user.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Window;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(linkLabel3);
            panel9.Location = new Point(35, 464);
            panel9.Name = "panel9";
            panel9.Size = new Size(218, 40);
            panel9.TabIndex = 15;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Roboto", 10F);
            linkLabel3.Location = new Point(8, 7);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(190, 22);
            linkLabel3.TabIndex = 0;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Upload your Image here";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Roboto", 10F);
            label17.Location = new Point(33, 431);
            label17.Name = "label17";
            label17.Size = new Size(111, 22);
            label17.TabIndex = 16;
            label17.Text = "Profile image";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.Window;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(txt_phone);
            panel10.Location = new Point(35, 384);
            panel10.Name = "panel10";
            panel10.Size = new Size(300, 40);
            panel10.TabIndex = 13;
            // 
            // txt_phone
            // 
            txt_phone.AcceptsReturn = true;
            txt_phone.BorderStyle = BorderStyle.None;
            txt_phone.CausesValidation = false;
            txt_phone.Font = new Font("Roboto", 10F);
            txt_phone.Location = new Point(8, 9);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(282, 21);
            txt_phone.TabIndex = 3;
            txt_phone.Tag = "";
            txt_phone.Text = "123456789";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Roboto", 10F);
            label18.Location = new Point(35, 357);
            label18.Name = "label18";
            label18.Size = new Size(58, 22);
            label18.TabIndex = 14;
            label18.Text = "Phone";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Window;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(txt_signup_email);
            panel8.Location = new Point(35, 225);
            panel8.Name = "panel8";
            panel8.Size = new Size(300, 40);
            panel8.TabIndex = 11;
            // 
            // txt_signup_email
            // 
            txt_signup_email.AcceptsReturn = true;
            txt_signup_email.BorderStyle = BorderStyle.None;
            txt_signup_email.CausesValidation = false;
            txt_signup_email.Font = new Font("Roboto", 10F);
            txt_signup_email.Location = new Point(8, 9);
            txt_signup_email.Name = "txt_signup_email";
            txt_signup_email.Size = new Size(282, 21);
            txt_signup_email.TabIndex = 3;
            txt_signup_email.Tag = "";
            txt_signup_email.Text = "helloworld@gmail.com";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Roboto", 10F);
            label16.Location = new Point(31, 194);
            label16.Name = "label16";
            label16.Size = new Size(52, 22);
            label16.TabIndex = 12;
            label16.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Roboto", 8F);
            label11.ForeColor = SystemColors.ActiveBorder;
            label11.Location = new Point(33, 92);
            label11.Name = "label11";
            label11.Size = new Size(247, 18);
            label11.TabIndex = 10;
            label11.Text = "Please filled your infomation to sign up";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Window;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(txt_name);
            panel7.Location = new Point(35, 147);
            panel7.Name = "panel7";
            panel7.Size = new Size(300, 40);
            panel7.TabIndex = 0;
            // 
            // txt_name
            // 
            txt_name.AcceptsReturn = true;
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.CausesValidation = false;
            txt_name.Font = new Font("Roboto", 10F);
            txt_name.Location = new Point(8, 9);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(282, 21);
            txt_name.TabIndex = 3;
            txt_name.Tag = "";
            txt_name.Text = "tester";
            // 
            // lbl_s_re_login
            // 
            lbl_s_re_login.AutoSize = true;
            lbl_s_re_login.Font = new Font("Roboto", 10F);
            lbl_s_re_login.Location = new Point(259, 604);
            lbl_s_re_login.Name = "lbl_s_re_login";
            lbl_s_re_login.Size = new Size(56, 22);
            lbl_s_re_login.TabIndex = 9;
            lbl_s_re_login.TabStop = true;
            lbl_s_re_login.Text = "Log in";
            lbl_s_re_login.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto", 10F);
            label12.Location = new Point(74, 604);
            label12.Name = "label12";
            label12.Size = new Size(179, 22);
            label12.TabIndex = 8;
            label12.Text = "Already have account?";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Roboto", 15F, FontStyle.Bold);
            label13.Location = new Point(33, 51);
            label13.Name = "label13";
            label13.Size = new Size(249, 31);
            label13.TabIndex = 0;
            label13.Text = "Sign up your account";
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(96, 98, 249);
            btn_signup.Font = new Font("Roboto", 10F);
            btn_signup.ForeColor = SystemColors.ControlLightLight;
            btn_signup.Location = new Point(44, 524);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(302, 41);
            btn_signup.TabIndex = 6;
            btn_signup.Text = "Sign up";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Roboto", 10F);
            label14.Location = new Point(31, 122);
            label14.Name = "label14";
            label14.Size = new Size(91, 22);
            label14.TabIndex = 1;
            label14.Text = "User name";
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tải_xuống;
            ClientSize = new Size(1456, 663);
            Controls.Add(pn_signup);
            Controls.Add(pn_forgot);
            Controls.Add(pn_login);
            Name = "Signin";
            Text = "Signin";
            Load += Signin_Load;
            Resize += Signin_Resize;
            pn_login.ResumeLayout(false);
            pn_login.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pn_forgot.ResumeLayout(false);
            pn_forgot.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pn_signup.ResumeLayout(false);
            pn_signup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_email;
        private Button btn_login;
        private Panel pn_login;
        private LinkLabel link_signup;
        private Label label5;
        private Button btn_fb_login;
        private Panel panel2;
        private Panel panel3;
        private TextBox txt_password;
        private Label label4;
        private Panel pn_forgot;
        private Label label6;
        private Panel panel6;
        private TextBox txt_recover_email;
        private LinkLabel lbl_signup;
        private Label label7;
        private Label label8;
        private Button btn_new_pass;
        private Label label9;
        private Panel pn_signup;
        private Label label11;
        private Panel panel7;
        private TextBox txt_name;
        private LinkLabel lbl_s_re_login;
        private Label label12;
        private Label label13;
        private Button btn_signup;
        private Label label14;
        private Label label17;
        private Panel panel10;
        private TextBox txt_phone;
        private Label label18;
        private Panel panel8;
        private TextBox txt_signup_email;
        private Label label16;
        private PictureBox pic_user;
        private Panel panel9;
        private LinkLabel linkLabel3;
        private LinkLabel lbl_forgot_pass;
        private LinkLabel lbl_re_login;
        private Panel panel1;
        private TextBox txt_signup_pass;
        private Label label10;
    }
}