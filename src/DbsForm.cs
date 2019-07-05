using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GallerySQL
{
    public partial class DbsForm : Form
    {
        private string dbs_server="localhost";
        private string dbs_user="AgentX";
        private string dbs_passwd="windows";
        private string dbs_database="GallerySQL";
         public DbsForm()
        {
            InitializeComponent();
            textBox_Server.Text = dbs_server;
            textBox_User.Text = dbs_user;
            textBox_Passwd.Text = dbs_passwd;
            textBox_Database.Text = dbs_database;
        }

        public string DBS_Server()
         {
             return dbs_server;
         }

        public string DBS_User()
        {
            return dbs_user;
        }

        public string DBS_Passwd()
        {
            return dbs_passwd;
        }

        public string DBS_Database()
        {
            return dbs_database;
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            dbs_server = textBox_Server.Text;
            dbs_user = textBox_User.Text;
            dbs_passwd = textBox_Passwd.Text;
            dbs_database = textBox_Database.Text;

            this.Hide();
        }
    }
}
