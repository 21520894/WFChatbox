using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeProject_B1
{
    public partial class SingleimgControl : UserControl
    {
        public SingleimgControl()
        {
            InitializeComponent();

        }
        
        private static int thumbnailSize = 138;
        public SingleimgControl(String path, String date)
        {
            InitializeComponent();
            //pic_img.BackgroundImage = Image.FromFile(path);
            lbl_date.Text = date;

            Image originalImage = Image.FromFile(path);
            Image thumbnailImage = GetThumbnail(originalImage, thumbnailSize);

            // Create a PictureBox for the thumbnail
            PictureBox pictureBox = new PictureBox();
            pic_img.Image = thumbnailImage;
            pic_img.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_img.Width = thumbnailSize;
            pic_img.Height = thumbnailSize;

            // Attach the click event handler
            pic_img.Click += (sender, e) =>
            {
                // Create a new form to display the larger image
                Form imageForm = new Form();
                imageForm.StartPosition = FormStartPosition.CenterScreen;
                imageForm.Size = new Size(originalImage.Width, originalImage.Height);

                // Create a PictureBox for the larger image
                PictureBox largePictureBox = new PictureBox();
                largePictureBox.Image = originalImage;
                largePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                largePictureBox.Dock = DockStyle.Fill;

                // Add the PictureBox to the form
                imageForm.Controls.Add(largePictureBox);

                // Show the form
                imageForm.ShowDialog();
            };

        }
        private static Image GetThumbnail(Image originalImage, int size)
        {
            int width, height;
            if (originalImage.Width > originalImage.Height)
            {
                width = size;
                height = (int)((float)originalImage.Height / originalImage.Width * size);
            }
            else
            {
                width = (int)((float)originalImage.Width / originalImage.Height * size);
                height = size;
            }
            return originalImage.GetThumbnailImage(width, height, null, IntPtr.Zero);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
