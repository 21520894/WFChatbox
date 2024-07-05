using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace CodeProject_B1
{
    public partial class imageControl : UserControl
    {
        String[] fileNames;
        public imageControl()
        {
            InitializeComponent();
        }

        private void imageControl_Load(object sender, EventArgs e)
        {
        }
        public imageControl(System.Drawing.Image pic, int sendto, int pic_point, int num_img, string[] fileNames, int read_or_add)
        {
            InitializeComponent();
            if (num_img == 1)
            {
                pn_pic.Size = new Size(350, 120);
                open_large_dialog(fileNames,read_or_add);
            }
            else if (num_img == 2)
            {
                pn_pic.Size = new Size(350, 240);
                open_large_dialog(fileNames,read_or_add);
            }
            else if(num_img == 3)
            {
                pn_pic.Size = new Size(350, 350);
                open_large_dialog(fileNames,read_or_add);
            }
             
            pic_user.Location = new Point(pic_point, 25);
            pic_user.BackgroundImage = pic;
            if (sendto == 1)
            {
                pn_pic.Location = new Point(pic_user.Left - 360, 25);
                pn_pic.FlowDirection = FlowDirection.RightToLeft;
            }

        }

        private static int thumbnailSize = 100;

        public int Main_funct()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; // Enable multiple file selection

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;

                if (fileNames.Length == 0)
                { return 0; }
                else if (fileNames.Length <= 3)
                {
                    pn_pic.Size = new Size(350, 120);
                    open_large_dialog(fileNames,1);
                    return 1;
                }
                else if (fileNames.Length <= 6)
                {
                    pn_pic.Size = new Size(350, 240);
                    open_large_dialog(fileNames,1);
                    return 2;
                }
                else
                {
                    pn_pic.Size = new Size(350, 350);
                    open_large_dialog(fileNames,1);
                    return 3;
                }    
                

                // Create a form to host the flow layout panel
            }
            else { return 0; }
        }

        private void open_large_dialog(string[] fileNames, int read_or_add)
        {
            int length = fileNames.Length;
            for (int i =0; i < length; i++)
            {
                if (read_or_add == 1)
                {
                    fileNames[i] = Readfile.CopyImage(fileNames[i]);
                }
                // Load the thumbnail image
                Image originalImage = Image.FromFile(fileNames[i]);
                Image thumbnailImage = GetThumbnail(originalImage, thumbnailSize);

                // Create a PictureBox for the thumbnail
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = thumbnailImage;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = thumbnailSize;
                pictureBox.Height = thumbnailSize;

                // Attach the click event handler
                pictureBox.Click += (sender, e) =>
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

                // Add the PictureBox to the flow layout panel
                pn_pic.Controls.Add(pictureBox);
            }
             this.fileNames = fileNames;
        }

        private String[] getfileNames() { return this.fileNames; }


        // Helper method to create a thumbnail image with a specified size
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


    }
}
