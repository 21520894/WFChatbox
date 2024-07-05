using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Serialization;
using static CodeProject_B1.Common_img;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CodeProject_B1
{
    public partial class Signin : Form
    {
        HashCode hc = new HashCode();
        int ID;
        DataTable dt_u = new DataTable();
        String PathImageFrom = "";
        public Signin()
        {
            InitializeComponent();
            dt_u = Readfile.Read_user();
        }
        // Sign up email
        private bool checkEmail(String email)
        {
            foreach (DataRow row in dt_u.Rows)
            {
                if (email == row[1].ToString())
                {
                    return true;
                }
            }
            return false;
        }
        // Login
        private int checkEmailAndPass(String email, String password)
        {
            foreach (DataRow row in dt_u.Rows)
            {
                if (email == row[1].ToString() && hc.PassHash(password) == row[2].ToString())
                {
                    return int.Parse(row[0].ToString());
                }
            }
            return -1;
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            pn_login.Dock = DockStyle.None;
            pn_login.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            txt_email.KeyPress += textBox_KeyPress;
            txt_password.KeyPress += textBox_KeyPress;
            txt_email.Padding = new Padding(3, 0, 3, 0);
            txt_password.Padding = new Padding(3, 0, 3, 0);


        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Suppress the Enter key's default behavior
            }
        }


        private void Signin_Resize(object sender, EventArgs e)
        {
            scale_panel(pn_login);
        }

        private void scale_panel(Panel this_pn)
        {
            int panelHeight = this.ClientSize.Height; // Calculate the desired height here
            this_pn.Height = panelHeight;
        }


        //Check email, mật khẩu
        private void btn_login_Click(object sender, EventArgs e)
        {
            int temp = checkEmailAndPass(txt_email.Text, txt_password.Text);
            if (temp != -1)
            {
                MessageBox.Show("Đăng nhập thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Close();
                Form1 f1 = new Form1(temp);
                this.Hide();
                f1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai Email hoặc mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Xử lý gửi mail quên mật khẩu
        private void btn_new_pass_Click(object sender, EventArgs e)
        {
            String mk = "";
            if (checkEmail(txt_recover_email.Text))
            {
                foreach (DataRow row in dt_u.Rows)
                {
                    if (txt_recover_email.Text == row[1].ToString())
                    {
                        mk = row[2].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Email này chưa được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress("21520894@gm.uit.edu.vn");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(mail.From.Address, "fajidvtrzrrbcpkd");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(txt_recover_email.Text));
            mail.IsBodyHtml = true;
            mail.Subject = "Password";
            mail.Body = mk;

            //for (int i = 0; i < attachmentFilename.Length; i++)
            //    mail.Attachments.Add(new Attachment(attachmentFilename[i]));

            smtp.Send(mail);
            MessageBox.Show("Email sent successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Load hình
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Common_img.buttonUpload_Click(pic_user);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pn_signup.Visible = false;
            pn_signup.Enabled = false;
            pn_login.Visible = true;
            pn_login.Enabled = true;
        }

        private void lbl_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pn_forgot.Visible = false;
            pn_forgot.Enabled = false;
            pn_signup.Visible = true;
            pn_signup.Enabled = true;
        }

        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pn_login.Visible = false;
            pn_login.Enabled = false;
            pn_signup.Visible = true;
            pn_signup.Enabled = true;
        }

        private void lbl_forget_pass_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pn_forgot.Visible = true;
            pn_forgot.Enabled = true;
            pn_login.Visible = false;
            pn_login.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pn_forgot.Visible = false;
            pn_forgot.Enabled = false;
            pn_login.Visible = true;
            pn_login.Enabled = true;
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmail(txt_signup_email.Text) == false && txt_name.Text.Length != 0 && txt_signup_pass.Text.Length != 0 && txt_phone.Text.Length != 0 )
                {
                    if (pic_user.BackgroundImage != null)
                    {
                        pic_user.BackgroundImage = Image.FromFile(@"D:\subject_learning\Csharp\CodeProject_B1\Resources\ava.png");
                    }    
                    Readfile.create_user(txt_name.Text, txt_signup_email.Text, hc.PassHash(txt_signup_pass.Text), txt_phone.Text, pic_user);
                    MessageBox.Show("Đăng ký tài khoản thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt_u.Rows.Add(dt_u.Rows.Count, txt_signup_email.Text, hc.PassHash(txt_signup_pass.Text));
                    Form1 f1 = new Form1(dt_u.Rows.Count-1);
                    this.Hide();
                    f1.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch { MessageBox.Show("Đăng ký tài khoản thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pn_login_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
