
namespace CodeProject_B1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pn_user = new Panel();
            pn_profile = new Panel();
            lbl_search = new Label();
            pictureBox3 = new PictureBox();
            txt_search = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            lbl_username = new Label();
            pic_user = new PictureBox();
            pn_fr_info = new Panel();
            btn_info = new Button();
            fr_name = new Label();
            fr_pic = new PictureBox();
            txt_chat_text = new TextBox();
            button1 = new Button();
            pn_emo = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            pn_info = new Panel();
            label3 = new Label();
            label1 = new Label();
            flow_video = new FlowLayoutPanel();
            flow_img = new FlowLayoutPanel();
            pn_chatbox = new FlowLayoutPanel();
            pn_profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_user).BeginInit();
            pn_fr_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fr_pic).BeginInit();
            pn_info.SuspendLayout();
            SuspendLayout();
            // 
            // pn_user
            // 
            pn_user.BackgroundImage = Properties.Resources.BG2;
            pn_user.BackgroundImageLayout = ImageLayout.Stretch;
            pn_user.BorderStyle = BorderStyle.FixedSingle;
            pn_user.Location = new Point(1, 195);
            pn_user.Name = "pn_user";
            pn_user.Size = new Size(389, 452);
            pn_user.TabIndex = 0;
            pn_user.Paint += pn_user_Paint;
            // 
            // pn_profile
            // 
            pn_profile.BackgroundImage = Properties.Resources.BG2;
            pn_profile.BackgroundImageLayout = ImageLayout.Stretch;
            pn_profile.BorderStyle = BorderStyle.FixedSingle;
            pn_profile.Controls.Add(lbl_search);
            pn_profile.Controls.Add(pictureBox3);
            pn_profile.Controls.Add(txt_search);
            pn_profile.Controls.Add(label2);
            pn_profile.Controls.Add(pictureBox2);
            pn_profile.Controls.Add(lbl_username);
            pn_profile.Controls.Add(pic_user);
            pn_profile.Location = new Point(1, 1);
            pn_profile.Name = "pn_profile";
            pn_profile.Size = new Size(389, 188);
            pn_profile.TabIndex = 1;
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.BackColor = Color.Fuchsia;
            lbl_search.Font = new Font("Segoe UI", 13F);
            lbl_search.Location = new Point(276, 120);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(78, 30);
            lbl_search.TabIndex = 6;
            lbl_search.Text = "Search";
            lbl_search.Click += lbl_search_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.on;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(225, 123);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 23);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(43, 123);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(206, 27);
            txt_search.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(131, 46);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 3;
            label2.Text = "online";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.on;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(92, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 23);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_username.Location = new Point(89, 15);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(129, 28);
            lbl_username.TabIndex = 1;
            lbl_username.Text = "Mạnh Nghĩa";
            // 
            // pic_user
            // 
            pic_user.BackgroundImage = Properties.Resources.ava;
            pic_user.BackgroundImageLayout = ImageLayout.Stretch;
            pic_user.Location = new Point(11, 11);
            pic_user.Name = "pic_user";
            pic_user.Size = new Size(60, 59);
            pic_user.TabIndex = 0;
            pic_user.TabStop = false;
            // 
            // pn_fr_info
            // 
            pn_fr_info.BackgroundImage = Properties.Resources.BG2;
            pn_fr_info.BackgroundImageLayout = ImageLayout.Stretch;
            pn_fr_info.BorderStyle = BorderStyle.Fixed3D;
            pn_fr_info.Controls.Add(btn_info);
            pn_fr_info.Controls.Add(fr_name);
            pn_fr_info.Controls.Add(fr_pic);
            pn_fr_info.Location = new Point(414, 1);
            pn_fr_info.Name = "pn_fr_info";
            pn_fr_info.Size = new Size(965, 101);
            pn_fr_info.TabIndex = 2;
            // 
            // btn_info
            // 
            btn_info.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_info.BackgroundImage = Properties.Resources.icons8_car_65;
            btn_info.BackgroundImageLayout = ImageLayout.Stretch;
            btn_info.Location = new Point(877, 23);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(71, 53);
            btn_info.TabIndex = 2;
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // fr_name
            // 
            fr_name.AutoSize = true;
            fr_name.BackColor = Color.BlanchedAlmond;
            fr_name.BorderStyle = BorderStyle.Fixed3D;
            fr_name.Font = new Font("Roboto", 18F);
            fr_name.Location = new Point(130, 31);
            fr_name.Name = "fr_name";
            fr_name.Size = new Size(99, 39);
            fr_name.TabIndex = 1;
            fr_name.Text = "label1";
            // 
            // fr_pic
            // 
            fr_pic.BackgroundImageLayout = ImageLayout.Stretch;
            fr_pic.Location = new Point(35, 14);
            fr_pic.Name = "fr_pic";
            fr_pic.Size = new Size(59, 62);
            fr_pic.TabIndex = 0;
            fr_pic.TabStop = false;
            // 
            // txt_chat_text
            // 
            txt_chat_text.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt_chat_text.BorderStyle = BorderStyle.FixedSingle;
            txt_chat_text.Location = new Point(507, 588);
            txt_chat_text.Name = "txt_chat_text";
            txt_chat_text.Size = new Size(812, 27);
            txt_chat_text.TabIndex = 3;
            txt_chat_text.KeyPress += txt_chat_text_KeyDown;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackgroundImage = Properties.Resources.icons8_camera_64;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(405, 588);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pn_emo
            // 
            pn_emo.AutoScroll = true;
            pn_emo.BorderStyle = BorderStyle.FixedSingle;
            pn_emo.Enabled = false;
            pn_emo.Location = new Point(1051, 521);
            pn_emo.Name = "pn_emo";
            pn_emo.Size = new Size(330, 48);
            pn_emo.TabIndex = 5;
            pn_emo.Visible = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackgroundImage = Properties.Resources.icons8_media_481;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(451, 588);
            button2.Name = "button2";
            button2.Size = new Size(40, 40);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackgroundImage = Properties.Resources.icons8_happy_50;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(1343, 580);
            button3.Name = "button3";
            button3.Size = new Size(40, 40);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pn_info
            // 
            pn_info.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pn_info.BackgroundImage = Properties.Resources.BG2;
            pn_info.BackgroundImageLayout = ImageLayout.Stretch;
            pn_info.Controls.Add(label3);
            pn_info.Controls.Add(label1);
            pn_info.Controls.Add(flow_video);
            pn_info.Controls.Add(flow_img);
            pn_info.Enabled = false;
            pn_info.Location = new Point(403, 104);
            pn_info.Name = "pn_info";
            pn_info.Size = new Size(994, 563);
            pn_info.TabIndex = 8;
            pn_info.Visible = false;
            pn_info.Paint += pn_info_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.BlanchedAlmond;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(15, 276);
            label3.Name = "label3";
            label3.Size = new Size(135, 37);
            label3.TabIndex = 3;
            label3.Text = "Video sent";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BlanchedAlmond;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 2;
            label1.Text = "Image sent";
            // 
            // flow_video
            // 
            flow_video.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flow_video.AutoScroll = true;
            flow_video.Location = new Point(15, 350);
            flow_video.Name = "flow_video";
            flow_video.Size = new Size(966, 191);
            flow_video.TabIndex = 1;
            // 
            // flow_img
            // 
            flow_img.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flow_img.AutoScroll = true;
            flow_img.Location = new Point(15, 65);
            flow_img.Name = "flow_img";
            flow_img.Size = new Size(966, 178);
            flow_img.TabIndex = 0;
            // 
            // pn_chatbox
            // 
            pn_chatbox.AutoScroll = true;
            pn_chatbox.BorderStyle = BorderStyle.Fixed3D;
            pn_chatbox.Location = new Point(414, 108);
            pn_chatbox.Name = "pn_chatbox";
            pn_chatbox.Size = new Size(969, 446);
            pn_chatbox.TabIndex = 1;
            pn_chatbox.Resize += pn_chatbox_resize;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.BG1;
            ClientSize = new Size(1418, 673);
            Controls.Add(pn_emo);
            Controls.Add(pn_info);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_chat_text);
            Controls.Add(pn_chatbox);
            Controls.Add(pn_fr_info);
            Controls.Add(pn_profile);
            Controls.Add(pn_user);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pn_profile.ResumeLayout(false);
            pn_profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_user).EndInit();
            pn_fr_info.ResumeLayout(false);
            pn_fr_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fr_pic).EndInit();
            pn_info.ResumeLayout(false);
            pn_info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel pn_user;
        private Panel pn_profile;
        private Panel pn_fr_info;
        private Label label2;
        private PictureBox pictureBox2;
        private Label lbl_username;
        private PictureBox pic_user;
        private Label lbl_search;
        private TextBox txt_search;
        private TextBox txt_chat_text;
        private Button button1;
        private FlowLayoutPanel pn_emo;
        private Button button2;
        private Button button3;
        private PictureBox fr_pic;
        private Label fr_name;
        private PictureBox pictureBox3;
        private Button btn_info;
        private Panel pn_info;
        private Label label3;
        private Label label1;
        private FlowLayoutPanel flow_video;
        private FlowLayoutPanel flow_img;
        private FlowLayoutPanel pn_chatbox;
    }
}
