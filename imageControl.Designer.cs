namespace CodeProject_B1
{
    partial class imageControl
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
            pn_pic = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pic_user).BeginInit();
            SuspendLayout();
            // 
            // pic_user
            // 
            pic_user.BackgroundImage = Properties.Resources.ava;
            pic_user.BackgroundImageLayout = ImageLayout.Stretch;
            pic_user.Location = new Point(15, 24);
            pic_user.Name = "pic_user";
            pic_user.Size = new Size(50, 50);
            pic_user.TabIndex = 0;
            pic_user.TabStop = false;
            // 
            // pn_pic
            // 
            pn_pic.Location = new Point(103, 24);
            pn_pic.Name = "pn_pic";
            pn_pic.Size = new Size(350, 350);
            pn_pic.TabIndex = 2;
            // 
            // imageControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pn_pic);
            Controls.Add(pic_user);
            Name = "imageControl";
            Size = new Size(544, 400);
            Load += imageControl_Load;
            ((System.ComponentModel.ISupportInitialize)pic_user).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_user;
        private FlowLayoutPanel pn_pic;
    }
}
