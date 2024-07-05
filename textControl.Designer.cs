namespace CodeProject_B1
{
    partial class textControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pic_user = new PictureBox();
            txt_user = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pic_user).BeginInit();
            SuspendLayout();
            // 
            // pic_user
            // 
            pic_user.BackgroundImage = Properties.Resources.ava01;
            pic_user.BackgroundImageLayout = ImageLayout.Stretch;
            pic_user.Location = new Point(15, 24);
            pic_user.Name = "pic_user";
            pic_user.Size = new Size(40, 40);
            pic_user.TabIndex = 0;
            pic_user.TabStop = false;
            pic_user.Click += pictureBox1_Click;
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.MediumPurple;
            txt_user.BorderStyle = BorderStyle.None;
            txt_user.Font = new Font("Segoe UI", 13F);
            txt_user.Location = new Point(69, 27);
            txt_user.Name = "txt_user";
            txt_user.ReadOnly = true;
            txt_user.Size = new Size(358, 36);
            txt_user.TabIndex = 2;
            txt_user.Text = "";
            txt_user.TextChanged += txt_user_TextChanged;
            // 
            // textControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txt_user);
            Controls.Add(pic_user);
            Name = "textControl";
            Size = new Size(477, 87);
            ((System.ComponentModel.ISupportInitialize)pic_user).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_user;
        private RichTextBox txt_user;
    }
}
