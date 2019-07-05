namespace GallerySQL
{
    partial class DbsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbsForm));
            this.label_Server = new System.Windows.Forms.Label();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label_User = new System.Windows.Forms.Label();
            this.textBox_Passwd = new System.Windows.Forms.TextBox();
            this.label_Passwd = new System.Windows.Forms.Label();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.label_Database = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Server
            // 
            this.label_Server.AutoSize = true;
            this.label_Server.Location = new System.Drawing.Point(23, 34);
            this.label_Server.Name = "label_Server";
            this.label_Server.Size = new System.Drawing.Size(79, 20);
            this.label_Server.TabIndex = 0;
            this.label_Server.Text = "Server:";
            // 
            // textBox_Server
            // 
            this.textBox_Server.Location = new System.Drawing.Point(146, 24);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(158, 30);
            this.textBox_Server.TabIndex = 1;
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(146, 78);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(158, 30);
            this.textBox_User.TabIndex = 3;
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.Location = new System.Drawing.Point(23, 88);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(59, 20);
            this.label_User.TabIndex = 2;
            this.label_User.Text = "User:";
            // 
            // textBox_Passwd
            // 
            this.textBox_Passwd.Location = new System.Drawing.Point(146, 132);
            this.textBox_Passwd.Name = "textBox_Passwd";
            this.textBox_Passwd.PasswordChar = '*';
            this.textBox_Passwd.Size = new System.Drawing.Size(158, 30);
            this.textBox_Passwd.TabIndex = 5;
            // 
            // label_Passwd
            // 
            this.label_Passwd.AutoSize = true;
            this.label_Passwd.Location = new System.Drawing.Point(23, 142);
            this.label_Passwd.Name = "label_Passwd";
            this.label_Passwd.Size = new System.Drawing.Size(99, 20);
            this.label_Passwd.TabIndex = 4;
            this.label_Passwd.Text = "Password:";
            // 
            // textBox_Database
            // 
            this.textBox_Database.Location = new System.Drawing.Point(146, 186);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(158, 30);
            this.textBox_Database.TabIndex = 7;
            // 
            // label_Database
            // 
            this.label_Database.AutoSize = true;
            this.label_Database.Location = new System.Drawing.Point(23, 196);
            this.label_Database.Name = "label_Database";
            this.label_Database.Size = new System.Drawing.Size(99, 20);
            this.label_Database.TabIndex = 6;
            this.label_Database.Text = "Database:";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(83, 265);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(164, 46);
            this.button_Submit.TabIndex = 8;
            this.button_Submit.Text = "确认";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // DbsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 337);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Database);
            this.Controls.Add(this.label_Database);
            this.Controls.Add(this.textBox_Passwd);
            this.Controls.Add(this.label_Passwd);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.textBox_Server);
            this.Controls.Add(this.label_Server);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbsForm";
            this.Text = "GallerySQL - DB Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Server;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.TextBox textBox_Passwd;
        private System.Windows.Forms.Label label_Passwd;
        private System.Windows.Forms.TextBox textBox_Database;
        private System.Windows.Forms.Label label_Database;
        private System.Windows.Forms.Button button_Submit;
    }
}