namespace CodeProject_B1
{
    partial class emojiControl
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
            pic_emo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_emo).BeginInit();
            SuspendLayout();
            // 
            // pic_user
            // 
            pic_user.BackgroundImage = Properties.Resources.ava01;
            pic_user.BackgroundImageLayout = ImageLayout.Stretch;
            pic_user.Location = new Point(15, 24);
            pic_user.Name = "pic_user";
            pic_user.Size = new Size(50, 50);
            pic_user.TabIndex = 0;
            pic_user.TabStop = false;
            // 
            // pic_emo
            // 
            pic_emo.BackgroundImage = Properties.Resources.emo1;
            pic_emo.BackgroundImageLayout = ImageLayout.Stretch;
            pic_emo.Location = new Point(86, 21);
            pic_emo.Name = "pic_emo";
            pic_emo.Size = new Size(60, 60);
            pic_emo.TabIndex = 1;
            pic_emo.TabStop = false;
            // 
            // emojiControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pic_emo);
            Controls.Add(pic_user);
            Name = "emojiControl";
            Size = new Size(282, 102);
            ((System.ComponentModel.ISupportInitialize)pic_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_emo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_user;
        private PictureBox pic_emo;
    }
}
