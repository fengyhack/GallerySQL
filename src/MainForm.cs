using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace GallerySQL
{
    public partial class MainForm : Form
    {
        private int index = 0;
        private bool bOpened = false;
        private MySqlConnection myConn = null;
        private string dbConn = "";
        private string imgName = "";

        DbsForm dbsf = null;

        private string fidl = "imageId.last";

        public MainForm()
        {
            InitializeComponent();

            button_imgWrite.Enabled = false;
            button_dbQuery.Enabled = false;
            button_dbClose.Enabled = false;

            if (!File.Exists(fidl))
            {
                StreamWriter sw = new StreamWriter(fidl);
                sw.WriteLine(0);
                sw.Close();

                index = 0;
            }

            StreamReader sr = new StreamReader(fidl);
            string s = sr.ReadLine();
            sr.Close();
            index = int.Parse(s);

            if (index == 0)
            {
                label_MaxId.Text = string.Format("(暂无图片)");
            }
            else
            {
                label_MaxId.Text = string.Format("图片编号(1~{0})", index);       
            }

            textBox_imgId.Text = index.ToString();
        }

        private void button_dbConn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(fidl);
                string s = sr.ReadLine();
                sr.Close();
                index = int.Parse(s);

                dbsf = new DbsForm();
                dbsf.ShowDialog(this);

                dbConn = string.Format("Server={0}; User={1}; Password={2}; Database={3}",
                    dbsf.DBS_Server(), dbsf.DBS_User(), dbsf.DBS_Passwd(), dbsf.DBS_Database());

                textBox_dbConn.Text = string.Format("{0}@{1}#{2}",
                    dbsf.DBS_Database(), dbsf.DBS_Server(), dbsf.DBS_User());

                dbsf.Close();

                myConn = new MySqlConnection(dbConn);

                myConn.Open();
                bOpened = true;

                button_imgWrite.Enabled = true;
                button_dbQuery.Enabled = true;
                button_dbClose.Enabled = true;
                button_dbConn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GallerySQL_Error");
            }
        }

        private void button_imgPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择图片文件";
            ofd.Multiselect = false;
            ofd.Filter = "JPEG|*.jpg|PNG|*.png|BMP|*.bmp|GIF|*.gif|TIFF|*.tif|All|*.*";

            if(ofd.ShowDialog()==DialogResult.OK)
            {
                imgName = ofd.FileName;
                textBox_imgPath.Text = imgName;
                pictureBox1.Image = new Bitmap(imgName);
            }
            else
            {
                imgName = "";
            }
        }

        private void button_imgWrite_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO imageList(id,fn,image) VALUES(@id,@fn,@image)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                cmd.Parameters.Add("@fn", MySqlDbType.String);
                cmd.Parameters.Add("@image", MySqlDbType.Blob);

                byte[] imgData = File.ReadAllBytes(imgName);

                string shortName = imgName.Replace('\\', '/');
                shortName = shortName.Substring(shortName.LastIndexOf('/') + 1);
                int len = shortName.Length;
                if (len > 60)
                {
                    shortName = shortName.Substring(len-60);
                }

                ++index;

                cmd.Parameters[0].Value = index;
                cmd.Parameters[1].Value = shortName;
                cmd.Parameters[2].Value = imgData;
                cmd.Connection = myConn;

                cmd.ExecuteNonQuery();

                cmd.Dispose();

                StreamWriter sw = new StreamWriter(fidl, false);
                sw.WriteLine(index);
                sw.Close();

                textBox_imgId.Text = index.ToString();
                label_MaxId.Text = string.Format("图片编号(1~{0})", index);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MySQL_Insert");
            }
        }

        private void button_dbClose_Click(object sender, EventArgs e)
        {
            try
            {
                myConn.Close();
                bOpened = false;

                button_dbConn.Enabled = true;
                button_imgWrite.Enabled = false;
                button_dbQuery.Enabled = false;
                button_dbClose.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "MySQL_Close");
            }
        }

        private void button_dbQuery_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = string.Format("SELECT id,image FROM imageList WHERE id = {0} ;",textBox_imgId.Text);
                cmd.Connection = myConn;

                System.Data.Common.DbDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                     reader.Read();  
                     long len = reader.GetBytes(1, 0, null, 0, 0);  // ord=1 是image  
                     byte[] buffer = new byte[len];  
                     len = reader.GetBytes(1, 0, buffer, 0, (int)len);  
                     MemoryStream ms = new MemoryStream(buffer);
                     Image img = Image.FromStream(ms);
                     pictureBox1.Image = img;  
                }
                else
                {
                    MessageBox.Show("没有查询到指定结果", "MySQL_Query");
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "MySQL_Query");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(bOpened)
            {
                myConn.Close();
            }
        }
    }
}
