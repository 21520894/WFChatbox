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

namespace CodeProject_B1
{
    public partial class emojiControl : UserControl
    {
        public emojiControl()
        {
            InitializeComponent();
        }
        public emojiControl(String emoji_link, Image pic, int send_to, int pic_point)
        {
            InitializeComponent();
            pic_user.Location = new Point(pic_point, 25);
            pic_user.BackgroundImage = pic;
            pic_emo.BackgroundImage = Image.FromFile(emoji_link);
            if (send_to == 0) return;
            else
            {
                pic_emo.Location = new Point(pic_user.Left - 10 - 60, 25);
            }

        }
    }
}
