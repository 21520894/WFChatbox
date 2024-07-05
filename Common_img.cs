using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProject_B1
{
    internal class Common_img
    {
        public static void buttonUpload_Click(PictureBox pic)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog1.Multiselect = false;

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;

                // Process the selected file
                pic.BackgroundImage = Image.FromFile(selectedFile);


            }
        }
        public static void Img_Save (PictureBox pic, String path)
        {

            Image imageToSave = pic.BackgroundImage;
            imageToSave.Save(path);
        }
    }
}
