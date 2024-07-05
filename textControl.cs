using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeProject_B1
{
    public partial class textControl : UserControl
    {
        public textControl()
        {
            InitializeComponent();
        }

        public textControl(String text, Image pic, int sendto, int pic_point)
        {
            InitializeComponent();
            pic_user.Location = new Point(pic_point, 25);
            pic_user.BackgroundImage = pic;
            txt_user.Text = text;
            //Xử lý độ cao của txtbox
            Size textSize = TextRenderer.MeasureText(txt_user.Text, txt_user.Font, new Size(txt_user.Width, int.MaxValue), TextFormatFlags.WordBreak);
            if (textSize.Height * textSize.Width / 358 < 30)
            {
                txt_user.Height = 39;
                txt_user.Width = textSize.Width;
            }
            else txt_user.Height = (textSize.Height * textSize.Width / 358 / 30+1) * 32;
            if (sendto == 1)
            {
                txt_user.Location = new Point(pic_user.Left - txt_user.Width, 25);
            }
            //txt_user.Size = new Size (350,500);
            Form1.SetBorderRadius(txt_user, 20);
        }

        public int get_txt_height()
        {

            return txt_user.Size.Height;
        }

        public String get_txt()
        {

            return txt_user.Text;
        }

        public RichTextBox get_rtxtbox()
        {

            return txt_user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
