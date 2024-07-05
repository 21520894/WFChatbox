namespace CodeProject_B1
{
    partial class SingleimgControl
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
            pic_img = new PictureBox();
            label1 = new Label();
            lbl_date = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_img).BeginInit();
            SuspendLayout();
            // 
            // pic_img
            // 
            pic_img.BackgroundImageLayout = ImageLayout.Stretch;
            pic_img.Location = new Point(9, 3);
            pic_img.Name = "pic_img";
            pic_img.Size = new Size(138, 138);
            pic_img.TabIndex = 0;
            pic_img.TabStop = false;
            pic_img.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 135);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 7F);
            lbl_date.Location = new Point(28, 139);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(38, 15);
            lbl_date.TabIndex = 2;
            lbl_date.Text = "label2";
            // 
            // SingleimgControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_date);
            Controls.Add(label1);
            Controls.Add(pic_img);
            Name = "SingleimgControl";
            Size = new Size(155, 155);
            ((System.ComponentModel.ISupportInitialize)pic_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_img;
        private Label label1;
        private Label lbl_date;
    }
}
