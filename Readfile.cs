using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;


namespace CodeProject_B1
{
    internal class Readfile
    {
        static String PathImageFrom = "";
        static String PathImageTo = @"D:\subject_learning\Csharp\CodeProject_B1\Resources\ava\ava";
        static String pathUserChat = @"D:\subject_learning\Csharp\CodeProject_B1\Resources\UserChat";
        static String pathEmo = @"D:\subject_learning\Csharp\CodeProject_B1\Resources\emo";
        static String pathUser = @"D:\subject_learning\Csharp\CodeProject_B1\Resources\User.txt";
        static String loginUser = @"D:\subject_learning\Csharp\CodeProject_B1\Resources\login_user.txt";
        static String pathImage = @"D:\subject_learning\Csharp\CodeProject_B1\Resources\image";
        static String pathMedia = @"D:\subject_learning\Csharp\CodeProject_B1\Resources\media";
        public static int ID = -1;

        public static DataTable Read_user()
        {
            DataTable dt_u = new DataTable();
            StreamReader sr = new StreamReader(loginUser);
            String str;
            dt_u.Columns.Add("ID", typeof(int));
            dt_u.Columns.Add("email", typeof(String));
            dt_u.Columns.Add("pass", typeof(String));
            while ((str = sr.ReadLine()) != null)
            {
                String[] st = str.Split('*');
                dt_u.Rows.Add(int.Parse(st[0]), st[1], st[2]);
                ID = int.Parse(st[0]);
            }
            sr.Close();
            return dt_u;
        }

        public static DataTable Read_emoji()
        {
            DataTable dt_emo = new DataTable();
            dt_emo.Columns.Add("ID", typeof(int));
            dt_emo.Columns.Add("emo", typeof(String));
            String[] files = Directory.GetFiles(pathEmo);
            int index = 0;
            foreach (String file in files)
            {
                dt_emo.Rows.Add(index,file);
            }
            return dt_emo;
        }

        public static void create_user(String txt_name, String txt_signup_email, String txt_signup_pass, String txt_phone, PictureBox pic_user)
        {
            ID++;
            StreamWriter sw = new StreamWriter(pathUser, true);
            sw.WriteLine(ID.ToString() + "*" + PathImageTo + ID + ".png" + "*off*" + txt_name + "*Online*" + txt_phone);
            sw.Close();

            sw = new StreamWriter(loginUser, true);
            sw.WriteLine(ID.ToString() + "*" + txt_signup_email + "*" + txt_signup_pass);
            sw.Close();

            Common_img.Img_Save(pic_user, PathImageTo + ID + ".png");
            ID++;
        }
        private static bool Find_folder(String name, String startwith)
        {
            String[] files = Directory.GetFiles(pathUser, startwith + "-*");
            foreach (String subdirectory in files)
            {
                String foldername = Path.GetFileName(subdirectory);
                if (foldername.Equals(ID.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private static int Find_file(String From, String To)
        {
            String[] filesFT = Directory.GetFiles(pathUserChat, From + "-" + To + ".txt");
            String[] filesTF = Directory.GetFiles(pathUserChat, To + "-" + From + ".txt");
            if (filesFT.Length == 0 && filesTF.Length == 0)
                {
                    return 0;
                }
            else if (filesFT.Length != 0)
                return 1;
            else 
                return -1;
        }

        public static DataTable User_info(int ID)
        {
            DataTable dt_ui = new DataTable();
            StreamReader sr = new StreamReader(pathUser);
            string str;
            dt_ui.Columns.Add("ID", typeof(int));
            dt_ui.Columns.Add("ava", typeof(Image));
            dt_ui.Columns.Add("online", typeof(Image));
            dt_ui.Columns.Add("name", typeof(string));
            dt_ui.Columns.Add("text", typeof(string));
            while ((str = sr.ReadLine()) != null)
            {
                string[] st = str.Split('*');
                if (st[0] == ID.ToString()) continue;
                else
                {
                    Image onoff;
                    if (st[2] == "on")
                        onoff = global::CodeProject_B1.Properties.Resources.on;
                    else
                        onoff = global::CodeProject_B1.Properties.Resources.off;
                    dt_ui.Rows.Add(int.Parse(st[0]), Image.FromFile(st[1]), onoff, st[3], st[4]);
                }
            }
            /*
                    dt_ui.Rows.Add(1, global::CodeProject_B1.Properties.Resources.ava, global::CodeProject_B1.Properties.Resources.on, "Mạnh Nghĩa", "Online");
                    dt_ui.Rows.Add(2, global::CodeProject_B1.Properties.Resources.ava01, global::CodeProject_B1.Properties.Resources.on, "Huỳnh Trâm", "Chào ngày mới!");
                    dt_ui.Rows.Add(3, global::CodeProject_B1.Properties.Resources.ava02, global::CodeProject_B1.Properties.Resources.off, "Tùng Dương", "Offline");
                    dt_ui.Rows.Add(4, global::CodeProject_B1.Properties.Resources.ava03, global::CodeProject_B1.Properties.Resources.on, "Minh Lan", "Rộn ràng");
                    dt_ui.Rows.Add(5, global::CodeProject_B1.Properties.Resources.ava04, global::CodeProject_B1.Properties.Resources.on, "Bảo Hưng", "Vừa xong");
                    dt_ui.Rows.Add(6, global::CodeProject_B1.Properties.Resources.ava05, global::CodeProject_B1.Properties.Resources.off, "Tú Ngọc", "Offline");
             */
            sr.Close();
            return dt_ui;
        }

        public static DataTable read_user_chat (StreamReader sr)
        {
            DataTable dt_uc = new DataTable();
            string str;
            //ID from, ID to,Loại tin nhắn, Nội dung, Thời gian
            dt_uc.Columns.Add("IDF", typeof(int));
            dt_uc.Columns.Add("IDT", typeof(int));
            dt_uc.Columns.Add("Mes_type", typeof(int));
            dt_uc.Columns.Add("Info", typeof(String));
            dt_uc.Columns.Add("time", typeof(DateTime));
            while ((str = sr.ReadLine()) != null)
            {
                string[] cbi = str.Split('*');
                dt_uc.Rows.Add(int.Parse(cbi[0]), int.Parse(cbi[1]), int.Parse(cbi[2]), cbi[3], DateTime.Parse(cbi[4]));
            }
            sr.Close();
            return dt_uc;
        }
        //return the path conversation of 2 people
        public static String Userchatpath(int IDFrom,int IDTo) 
        {

            int chatfile = Find_file(IDFrom.ToString(), IDTo.ToString());
            String chatboxpath = pathUserChat + @"\" + IDFrom.ToString() + '-' + IDTo.ToString();
            if (chatfile == 1)
            {
                //Nếu tìm thấy file thì đọc file ra
                return chatboxpath + ".txt";
            }
            //nếu ko có file thì tạo 1 file mới
            else if (chatfile == -1)
            {
                //Nếu tìm thấy file thì đọc file ra
                chatboxpath = pathUserChat + @"\" + IDTo.ToString() + '-' + IDFrom.ToString();
                return chatboxpath + ".txt";
            }
            else
                File.Create(chatboxpath + ".txt").Close();
            return chatboxpath + ".txt";
        }

        //return the conversation of 2 people
        public static DataTable Userchat(int IDFrom, int IDTo,String chatboxpath)
        {
            DataTable dt_uc = new DataTable();
            //String temppath = Userchatpath(IDFrom, IDTo);
            StreamReader sr = new StreamReader(chatboxpath);
            dt_uc = read_user_chat(sr);
            return dt_uc;
        }

        public static String CopyImage(String fileName)
        {
            DateTime now = DateTime.Now;

            // Generate a file name based on the timestamp
            string newfileName = $"{now:yyyyMMddHHmmssfff}.jpg";

            try
            {
                // Copy the image file to the destination folder
                File.Copy(fileName, Path.Combine(pathImage,newfileName));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while copying the image file: {ex.Message}");
            }
            return Path.Combine(pathImage, newfileName);
        }

        public static String Copyvideo(String fileName)
        {
            DateTime now = DateTime.Now;

            // Generate a file name based on the timestamp
            string newfileName = $"{now:yyyyMMddHHmmssfff}.mp4";

            try
            {
                // Copy the image file to the destination folder
                File.Copy(fileName, Path.Combine(pathMedia, newfileName));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while copying the image file: {ex.Message}");
            }
            return Path.Combine(pathImage, newfileName);
        }
    } 
}

