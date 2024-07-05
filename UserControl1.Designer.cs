namespace CodeProject_B1
{
    partial class UserControl1
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
            pic_avata = new PictureBox();
            lbl_status = new Label();
            name = new Label();
            ic_status = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_avata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ic_status).BeginInit();
            SuspendLayout();
            // 
            // pic_avata
            // 
            pic_avata.BackgroundImage = Properties.Resources.ava;
            pic_avata.BackgroundImageLayout = ImageLayout.Zoom;
            pic_avata.Location = new Point(19, 17);
            pic_avata.Name = "pic_avata";
            pic_avata.Size = new Size(47, 54);
            pic_avata.TabIndex = 4;
            pic_avata.TabStop = false;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(112, 48);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(52, 20);
            lbl_status.TabIndex = 7;
            lbl_status.Text = "Online";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(75, 22);
            name.Name = "name";
            name.Size = new Size(88, 20);
            name.TabIndex = 5;
            name.Text = "Huỳnh Trâm";
            // 
            // ic_status
            // 
            ic_status.BackgroundImage = Properties.Resources.on;
            ic_status.BackgroundImageLayout = ImageLayout.Stretch;
            ic_status.Location = new Point(84, 48);
            ic_status.Name = "ic_status";
            ic_status.Size = new Size(22, 23);
            ic_status.TabIndex = 6;
            ic_status.TabStop = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pic_avata);
            Controls.Add(lbl_status);
            Controls.Add(name);
            Controls.Add(ic_status);
            Name = "UserControl1";
            Size = new Size(370, 89);
            ((System.ComponentModel.ISupportInitialize)pic_avata).EndInit();
            ((System.ComponentModel.ISupportInitialize)ic_status).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_avata;
        private Label lbl_status;
        private Label name;
        private PictureBox ic_status;
    }
}
