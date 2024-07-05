using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using WMPLib;
using AxWMPLib;
using System.Runtime.Versioning;
using System.Reflection.Emit;
using System.Windows.Forms.Design;

namespace CodeProject_B1
{
    public partial class Form1 : Form
    {
        private int IDFrom;
        private String fr_chating;
        private int IDTo;
        Image img_user_from;
        Image img_user_to;
        private int y_point_to;
        private int x_point;
        private int flag = 0;
        public Form1()
        {
            InitializeComponent();
            load_data();
            Loademoji();
            y_point_to = pn_chatbox.Size.Width - 50;
        }
        public Form1(int ID)
        {
            InitializeComponent();
            this.IDFrom = ID; ;
            load_data();
            Loademoji();
            SetBorderRadius(txt_chat_text, 10);
            y_point_to = pn_chatbox.Size.Width - 100;
            x_point = pn_chatbox.Width - 50;
            Controls.Add(pn_info);
        }
        private void pn_chatbox_resize(object sender, EventArgs e)
        {
            FlowLayoutPanel form = (FlowLayoutPanel)sender;
            float controlWidthPercentage = 1f; // Adjust the percentage based on your needs

            foreach (Control control in form.Controls)
            {
                control.Width = (int)(form.Width * controlWidthPercentage);

            }
        }

        DataTable dt = new DataTable();
        DataTable dt_e = new DataTable();
        private void load_data()
        {

            dt = new DataTable();
            /*
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("ava", typeof(Image));
            dt.Columns.Add("online", typeof(Image));
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("text", typeof(string));
            dt.Rows.Add(1, global::CodeProject_B1.Properties.Resources.ava, global::CodeProject_B1.Properties.Resources.on, "Mạnh Nghĩa", "Online");
            dt.Rows.Add(2, global::CodeProject_B1.Properties.Resources.ava01, global::CodeProject_B1.Properties.Resources.on, "Huỳnh Trâm", "Chào ngày mới!");
            dt.Rows.Add(3, global::CodeProject_B1.Properties.Resources.ava02, global::CodeProject_B1.Properties.Resources.off, "Tùng Dương", "Offline");
            dt.Rows.Add(4, global::CodeProject_B1.Properties.Resources.ava03, global::CodeProject_B1.Properties.Resources.on, "Minh Lan", "Rộn ràng");
            dt.Rows.Add(5, global::CodeProject_B1.Properties.Resources.ava04, global::CodeProject_B1.Properties.Resources.on, "Bảo Hưng", "Vừa xong");
            dt.Rows.Add(6, global::CodeProject_B1.Properties.Resources.ava05, global::CodeProject_B1.Properties.Resources.off, "Tú Ngọc", "Offline");
            */
            dt = Readfile.User_info(-1);
            for (int i = 0; i < (int)(dt.Rows.Count); i++)
            {
                LoadUser((int)dt.Rows[i]["ID"], i);
            }

        }


        private void Loademoji()
        {
            dt_e = new DataTable();
            dt_e = Readfile.Read_emoji();

            for (int i = 1; i < (int)(dt_e.Rows.Count); i++)
            {
                LoadEmo(i);
            }

        }

        void LoadEmo(int ID)
        {
            PictureBox pic_emo = new PictureBox();
            pic_emo.BackgroundImage = Image.FromFile((String)dt_e.Rows[ID]["emo"]);
            pic_emo.Name = ID.ToString();
            pic_emo.Size = new Size(45, 45);
            this.pn_emo.Controls.Add(pic_emo);
            pic_emo.Click += Pic_emo_Click;
            //this.pn_chat_box.Controls.Add(pn_emo);
        }

        private void Pic_emo_Click(object? sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            emojiControl emoctl = new emojiControl((String)dt_e.Rows[int.Parse(pic.Name)]["emo"], img_user_from, 0, 15);
            emoctl.Size = new Size(x_point, 100);
            pn_chatbox.Controls.Add(emoctl);
            pn_chatbox.VerticalScroll.Value = pn_chatbox.VerticalScroll.Maximum;
            writeFile(3, (String)dt_e.Rows[int.Parse(pic.Name)]["emo"]);
        }

        int y_locate = 80;
        void LoadUser(int ID, int index)
        {
            int temp = 0;
            if (ID > this.IDFrom)
            {
                temp = y_locate * (index - 1);
            }
            else if (ID == this.IDFrom)
            {
                img_user_from = (Image)dt.Rows[index]["ava"];
                pic_user.BackgroundImage = img_user_from;
                lbl_username.Text = (String)dt.Rows[index]["name"];
                return;
            }
            else temp = y_locate * index;
            UserControl1 uct = new UserControl1(ID);
            //Image ava_img = Image.FromFile(dt.Rows[ID]["ava"]);
            //Image status_img = Image.FromFile(dt.Rows[ID]["online"]);
            uct.loaduserdata((int)(dt.Rows[index]["ID"]),
                (Image)(dt.Rows[index]["ava"]),
                //ava_img,
                (Image)(dt.Rows[index]["online"]),
                //status_img,
                dt.Rows[index]["name"].ToString(),
                dt.Rows[index]["text"].ToString());
            this.pn_user.Controls.Add(uct);
            uct.Location = new System.Drawing.Point(0, temp);
            uct.Size = new Size(389, 80);
            uct.Click += new EventHandler(UserControl_clicked);
            uct.Show();
            if (flag == 0)
            {
                UserControl_clicked(uct, EventArgs.Empty);
                flag = 1;
            }



        }

        private void UserControl_clicked(object sender, EventArgs e)
        {
            // Handle the click event of the user control
            UserControl1 control = (UserControl1)sender;
            img_user_to = control.getfrImg();
            IDTo = control.getid();
            this.IDTo = IDTo;
            fr_pic.BackgroundImage = img_user_to;
            fr_pic.Location = new Point(35, 14);
            fr_name.Text = control.getfrName();

            fr_chating = Readfile.Userchatpath(this.IDFrom, IDTo);
            DataTable Userchat = Readfile.Userchat(this.IDFrom, control.getid(), fr_chating);
            pn_chatbox.Controls.Clear();
            for (int i = 0; i < Userchat.Rows.Count; i++)
            {
                if ((int)Userchat.Rows[i]["IDF"] == this.IDFrom)
                {
                    switch ((int)Userchat.Rows[i]["Mes_type"])
                    {
                        case 0:
                            textControl txt_control = new textControl((String)Userchat.Rows[i]["info"], img_user_from, 0, 15);
                            txt_control.Size = new Size(x_point, txt_control.get_txt_height() + 45);
                            txt_control.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                            pn_chatbox.Controls.Add(txt_control);
                            break;
                        case 1:
                            imageControl img_ctl;
                            List<string> myList = new List<string>();
                            while (i < Userchat.Rows.Count && (int)Userchat.Rows[i]["Mes_type"] == 1)
                            {
                                myList.Add((String)Userchat.Rows[i]["Info"]);
                                i++;
                            }
                            String[] fileNames = myList.ToArray();
                            if (fileNames.Length <= 3)
                            {
                                img_ctl = new imageControl(img_user_from, 0, 15, 1, fileNames, 0);
                                img_ctl.Size = new Size(x_point, 170);
                            }
                            else if (fileNames.Length <= 6)
                            {
                                img_ctl = new imageControl(img_user_from, 0, 15, 2, fileNames, 0);
                                img_ctl.Size = new Size(x_point, 290);
                            }
                            else
                            {
                                img_ctl = new imageControl(img_user_from, 0, 15, 3, fileNames, 0);
                                img_ctl.Size = new Size(x_point, 400);
                            }
                            img_ctl.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                            pn_chatbox.Controls.Add(img_ctl);
                            i--;
                            break;
                        case 2:
                            videoControl videoctl = new videoControl((String)Userchat.Rows[i]["info"], img_user_from, 0, 15, 0);
                            videoctl.Size = new Size(x_point, 350);
                            videoctl.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                            pn_chatbox.Controls.Add(videoctl);
                            break;
                        case 3:
                            emojiControl emoctl = new emojiControl((String)Userchat.Rows[i]["info"], img_user_from, 0, 15);
                            emoctl.Size = new Size(x_point, 100);
                            emoctl.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                            pn_chatbox.Controls.Add(emoctl);
                            break;
                    }

                }
                else
                {
                    switch ((int)Userchat.Rows[i]["Mes_type"])
                    {
                        case 0:
                            textControl txt_control = new textControl((String)Userchat.Rows[i]["info"], img_user_to, 1, y_point_to);
                            txt_control.Size = new Size(x_point, txt_control.get_txt_height() + 45);
                            txt_control.Anchor = AnchorStyles.Right;
                            pn_chatbox.Controls.Add(txt_control);
                            break;
                        case 1:
                            imageControl img_ctl;
                            List<string> myList = new List<string>();
                            while (i < Userchat.Rows.Count && (int)Userchat.Rows[i]["Mes_type"] == 1)
                            {
                                myList.Add((String)Userchat.Rows[i]["Info"]);
                                i++;
                            }
                            String[] fileNames = myList.ToArray();
                            if (fileNames.Length <= 3)
                            {
                                img_ctl = new imageControl(img_user_to, 1, y_point_to, 1, fileNames, 0);
                                img_ctl.Size = new Size(x_point, 170);
                            }
                            else if (fileNames.Length <= 6)
                            {
                                img_ctl = new imageControl(img_user_to, 1, y_point_to, 2, fileNames, 0);
                                img_ctl.Size = new Size(x_point, 290);
                            }
                            else
                            {
                                img_ctl = new imageControl(img_user_to, 1, y_point_to, 3, fileNames, 0);
                                img_ctl.Size = new Size(x_point, 400);
                            }
                            img_ctl.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                            pn_chatbox.Controls.Add(img_ctl);
                            i--;
                            break;
                        case 2:
                            videoControl videoctl = new videoControl((String)Userchat.Rows[i]["info"], img_user_to, 1, y_point_to, 0);
                            videoctl.Size = new Size(x_point, 350);
                            videoctl.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                            pn_chatbox.Controls.Add(videoctl);
                            break;
                        case 3:
                            emojiControl emoctl = new emojiControl((String)Userchat.Rows[i]["info"], img_user_to, 1, y_point_to);
                            emoctl.Size = new Size(x_point, 100);
                            emoctl.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                            pn_chatbox.Controls.Add(emoctl);
                            break;
                    }
                }
            }
            pn_chatbox.VerticalScroll.Value = pn_chatbox.VerticalScroll.Maximum;
        }





        private void lbl_search_Click(object sender, EventArgs e)
        {
            foreach (Control control in pn_chatbox.Controls)
            {
                if (control is textControl)
                {
                    textControl txtctl = (textControl)control;
                    txtctl.get_rtxtbox().SelectAll();
                    txtctl.get_rtxtbox().SelectionColor = Color.Black;
                }
            }
            String searchtxt = txt_search.Text;
            if (searchtxt.Length == 0)
                return;
            else
            {
                int flag = 0;
                foreach (Control control in pn_chatbox.Controls)
                {
                    if (control is textControl)
                    {
                        textControl txtctl = (textControl)control;
                        String clt = txtctl.get_txt().ToLower();
                        searchtxt = searchtxt.ToLower();
                        bool iscontain = clt.Contains(searchtxt);
                        if (iscontain)
                        {
                            flag = 1;
                            FindAndChangeTextColor(searchtxt, Color.Red, (RichTextBox)txtctl.get_rtxtbox());
                            //pn_chatbox.ScrollControlIntoView(control);
                        }
                    }
                }
                if (flag == 0)
                    MessageBox.Show("Don't have chat with: " +  searchtxt,"Lưu ý",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void FindAndChangeTextColor(string searchText, Color color, RichTextBox richTextBox)
        {
            int searchStart = 0;
            while (searchStart < richTextBox.TextLength)
            {
                int foundIndex = richTextBox.Find(searchText, searchStart, RichTextBoxFinds.None);
                if (foundIndex != -1)
                {
                    richTextBox.SelectionStart = foundIndex;
                    richTextBox.SelectionLength = searchText.Length;
                    richTextBox.SelectionColor = color;
                    searchStart = foundIndex + searchText.Length;
                }
                else
                {
                    break;
                }
            }
        }
        public static void SetBorderRadius(Control control, int borderRadius)
        {
            // Create a GraphicsPath with rounded rectangle shape
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Top-left corner
            path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Top-right corner
            path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Bottom-left corner
            path.CloseAllFigures();

            // Set the region of the control to the rounded rectangle shape
            control.Region = new Region(path);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pn_user.Dock = DockStyle.None;
            pn_user.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;

            pn_chatbox.Dock = DockStyle.None;
            pn_chatbox.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            pn_fr_info.Dock = DockStyle.None;
            pn_fr_info.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
        }

        private void pn_user_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txt_chat_text_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_chat_text.Text.Length == 1)
                    return;
                else
                {
                    textControl txt_control = new textControl(txt_chat_text.Text, img_user_from, 0, 15);
                    txt_control.Size = new Size(x_point, txt_control.get_txt_height() + 45);
                    txt_control.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                    pn_chatbox.Controls.Add(txt_control);
                    pn_chatbox.VerticalScroll.Value = pn_chatbox.VerticalScroll.Maximum;
                    writeFile(0, txt_chat_text.Text);
                    e.Handled = true;
                    txt_chat_text.Clear();

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = true; // Enable multiple file selection
            imageControl img_ctl;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;

                if (fileNames.Length == 0)
                    return;
                else if (fileNames.Length <= 3)
                {
                    img_ctl = new imageControl(img_user_from, 0, 15, 1, fileNames, 1);
                    img_ctl.Size = new Size(x_point, 170);
                }
                else if (fileNames.Length <= 6)
                {
                    img_ctl = new imageControl(img_user_from, 0, 15, 2, fileNames, 1);
                    img_ctl.Size = new Size(x_point, 290);
                }
                else
                {
                    img_ctl = new imageControl(img_user_from, 0, 15, 3, fileNames, 1);
                    img_ctl.Size = new Size(x_point, 400);
                }

                foreach (String file in fileNames)
                {
                    writeFile(1, file);
                }


                // Create a form to host the flow layout panel
            }
            else
                return;
            pn_chatbox.Controls.Add(img_ctl);
            pn_chatbox.VerticalScroll.Value = pn_chatbox.VerticalScroll.Maximum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 and Video Files|*.mp3;*.mp4;*.avi;*.mkv|All Files|*.*";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String[] fileNames = openFileDialog.FileNames;
                foreach (String fileName in fileNames)
                {
                    videoControl videoctl = new videoControl(fileName, img_user_from, 0, 15, 1);
                    videoctl.Size = new Size(x_point, 350);
                    pn_chatbox.Controls.Add(videoctl);
                    pn_chatbox.VerticalScroll.Value = pn_chatbox.VerticalScroll.Maximum;
                    writeFile(2, fileName);

                }    
                // Handle the selected files here
            }
            else return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pn_emo.Visible == false)
            {
                pn_emo.Visible = true;
                pn_emo.Enabled = true;
            }
            else
            {
                pn_emo.Visible = false;
                pn_emo.Enabled = false;
            }
        }

        //0. text
        //1. image
        //2. media
        //3. emoji
        private void writeFile(int type, String info)
        {
            StreamWriter sw = new StreamWriter(fr_chating, true);
            sw.WriteLine(this.IDFrom.ToString() + "*" + this.IDTo.ToString() + "*" + type.ToString() + "*" + info + "*" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sw.Close();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            if (pn_info.Visible == false)
            {
                pn_info.Visible = true;
                pn_info.Enabled = true;
                pn_chatbox.Visible = false;
                pn_chatbox.Enabled = false ;
                txt_chat_text.Visible = false;
                txt_chat_text.Enabled = false;
                button1.Visible = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button2.Visible = false;
                button3.Visible = false;
                button3 .Enabled = false;
                Load_img_video();
            }
            else
            {
                pn_info.Visible = false;
                pn_info.Enabled = false;
                pn_chatbox.Visible = true;
                pn_chatbox.Enabled = true;
                txt_chat_text.Visible = true;
                txt_chat_text.Enabled = true;
                button1.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button2.Visible = true;
                button3.Visible = true;
                button3.Enabled = true;
            }
        }
        private void Load_img_video()
        {
            flow_img.Controls.Clear();
            flow_video.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i == this.IDFrom)
                {
                    continue;
                }
                else
                {
                    String temp = Readfile.Userchatpath(this.IDFrom, i);
                    DataTable Userchat = Readfile.Userchat(this.IDFrom, i, temp);

                    for (int j = 0; j < Userchat.Rows.Count; j++)
                    {
                        if (((String)Userchat.Rows[j]["Info"]).EndsWith(".jpg"))
                        {
                            SingleimgControl vc = new SingleimgControl((String)Userchat.Rows[j]["Info"], Userchat.Rows[j]["time"].ToString());
                            flow_img.Controls.Add(vc);
                        }
                        else if (((String)Userchat.Rows[j]["Info"]).EndsWith(".mp4"))
                        {
                            videoControl vc = new videoControl((String)Userchat.Rows[j]["Info"], Userchat.Rows[j]["time"].ToString());
                            vc.Size = new Size(155, 155);
                            flow_video.Controls.Add(vc);
                        }

                    }


                }
            }
        }
        private void pic_play_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Visible = false;
            pic.Enabled = false;

        }

        private void pn_info_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
