using AxWMPLib;
using MediaPlayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
    
using Label = System.Windows.Forms.Label;

namespace CodeProject_B1
{
    public partial class videoControl : UserControl
    {
        PictureBox pic_play;
        String medialink;
        public videoControl()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = @"C:\Users\ADMIN\Videos\2024-03-21 08-33-16.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.stretchToFit = true;
        }

        public videoControl(String media_link,String date)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = media_link;

            pic_play = new PictureBox();
            pic_play.BackgroundImage = global::CodeProject_B1.Properties.Resources.icons8_play_48;
            pic_play.BackgroundImageLayout = ImageLayout.Stretch;
            axWindowsMediaPlayer1.Controls.Add(pic_play);
            pic_play.Size = new Size(40, 40);
            axWindowsMediaPlayer1.Location = new Point(5, 0);
            axWindowsMediaPlayer1.Size = new Size(138, 138);
            pic_play.Location = new Point((axWindowsMediaPlayer1.Width - 40) / 2, (axWindowsMediaPlayer1.Height - 40) / 2);
            pic_user.Visible = false;
            pic_user.Enabled= false;
            pic_play.Click += pic_play_Click;
            axWindowsMediaPlayer1.stretchToFit = true;

            Label lbl = new Label();
            lbl.Text = date;
            lbl.Location = new Point(20, 143);
            lbl.ForeColor = Color.Black;
            lbl.Font = new Font(lbl.Font.FontFamily, 7, lbl.Font.Style);
            Controls.Add(lbl);

            axWindowsMediaPlayer1.Ctlcontrols.stop();
            axWindowsMediaPlayer1.uiMode = "none";
        }


        private void videoControl_Load(object sender, EventArgs e)
        {

        }

        public videoControl(String media_link, Image pic, int send_to,int pic_point,int read_or_add)
        {
            InitializeComponent();
            if (read_or_add == 1)
            {
                this.medialink = Readfile.Copyvideo(media_link);
                medialink = this.medialink;
            }    
            axWindowsMediaPlayer1.stretchToFit = true;
            pic_user.Location = new Point (pic_point, 25);
            axWindowsMediaPlayer1.URL = media_link;
            pic_user.BackgroundImage = pic;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            if (send_to == 0) return;
            else {
                axWindowsMediaPlayer1.Location = new Point(pic_user.Left - 10 - 300, 25);
            }
        }

        private void axWindowsMediaPlayer1_MouseMoveEvent(object sender, _WMPOCXEvents_MouseMoveEvent e)
        {

        }
        public String get_media_link() { return this.medialink; }

        private void pic_play_Click(object sender, EventArgs e)
        {
            pic_play.Visible = false;
            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.AutoSize = false;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

    }
}
