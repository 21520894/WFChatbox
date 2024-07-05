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
    public partial class UserControl1 : UserControl
    {
        private int ID;
        public event EventHandler Clicked;
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }
        public void loaduserdata(int ID, Image ava, Image icon_status, string name, string text)
        {
            pic_avata.BackgroundImage = ava;
            ic_status.BackgroundImage = icon_status;
            this.name.Text = name;
            lbl_status.Text = text;

        }

        public Image getfrImg()
        {
            return pic_avata.BackgroundImage;
        }
        public int getid()
        {
            return ID;
        }

        public String getfrName()
        {
            return this.name.Text;
        }
        // Method to raise the Clicked event


    }
}
