namespace GallerySQL
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_imgPath = new System.Windows.Forms.Button();
            this.button_dbConn = new System.Windows.Forms.Button();
            this.button_imgWrite = new System.Windows.Forms.Button();
            this.textBox_imgPath = new System.Windows.Forms.TextBox();
            this.textBox_dbConn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_dbClose = new System.Windows.Forms.Button();
            this.label_MaxId = new System.Windows.Forms.Label();
            this.textBox_imgId = new System.Windows.Forms.TextBox();
            this.label_Query = new System.Windows.Forms.Label();
            this.button_dbQuery = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "图  片:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "数据库:";
            // 
            // button_imgPath
            // 
            this.button_imgPath.Location = new System.Drawing.Point(385, 77);
            this.button_imgPath.Name = "button_imgPath";
            this.button_imgPath.Size = new System.Drawing.Size(56, 34);
            this.button_imgPath.TabIndex = 2;
            this.button_imgPath.Text = "...";
            this.button_imgPath.UseVisualStyleBackColor = true;
            this.button_imgPath.Click += new System.EventHandler(this.button_imgPath_Click);
            // 
            // button_dbConn
            // 
            this.button_dbConn.Location = new System.Drawing.Point(447, 32);
            this.button_dbConn.Name = "button_dbConn";
            this.button_dbConn.Size = new System.Drawing.Size(134, 34);
            this.button_dbConn.TabIndex = 0;
            this.button_dbConn.Text = "打开数据库";
            this.button_dbConn.UseVisualStyleBackColor = true;
            this.button_dbConn.Click += new System.EventHandler(this.button_dbConn_Click);
            // 
            // button_imgWrite
            // 
            this.button_imgWrite.Location = new System.Drawing.Point(447, 81);
            this.button_imgWrite.Name = "button_imgWrite";
            this.button_imgWrite.Size = new System.Drawing.Size(134, 34);
            this.button_imgWrite.TabIndex = 3;
            this.button_imgWrite.Text = "写入图像";
            this.button_imgWrite.UseVisualStyleBackColor = true;
            this.button_imgWrite.Click += new System.EventHandler(this.button_imgWrite_Click);
            // 
            // textBox_imgPath
            // 
            this.textBox_imgPath.BackColor = System.Drawing.Color.Silver;
            this.textBox_imgPath.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_imgPath.Location = new System.Drawing.Point(97, 81);
            this.textBox_imgPath.Name = "textBox_imgPath";
            this.textBox_imgPath.ReadOnly = true;
            this.textBox_imgPath.Size = new System.Drawing.Size(282, 30);
            this.textBox_imgPath.TabIndex = 5;
            // 
            // textBox_dbConn
            // 
            this.textBox_dbConn.BackColor = System.Drawing.Color.Silver;
            this.textBox_dbConn.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_dbConn.Location = new System.Drawing.Point(97, 32);
            this.textBox_dbConn.Name = "textBox_dbConn";
            this.textBox_dbConn.ReadOnly = true;
            this.textBox_dbConn.Size = new System.Drawing.Size(344, 30);
            this.textBox_dbConn.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 590);
            this.panel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(4, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 398);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_dbClose);
            this.groupBox1.Controls.Add(this.label_MaxId);
            this.groupBox1.Controls.Add(this.textBox_imgId);
            this.groupBox1.Controls.Add(this.label_Query);
            this.groupBox1.Controls.Add(this.button_dbQuery);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_imgPath);
            this.groupBox1.Controls.Add(this.button_imgWrite);
            this.groupBox1.Controls.Add(this.textBox_dbConn);
            this.groupBox1.Controls.Add(this.textBox_imgPath);
            this.groupBox1.Controls.Add(this.button_dbConn);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button_dbClose
            // 
            this.button_dbClose.Location = new System.Drawing.Point(447, 135);
            this.button_dbClose.Name = "button_dbClose";
            this.button_dbClose.Size = new System.Drawing.Size(134, 34);
            this.button_dbClose.TabIndex = 13;
            this.button_dbClose.Text = "关闭数据库";
            this.button_dbClose.UseVisualStyleBackColor = true;
            this.button_dbClose.Click += new System.EventHandler(this.button_dbClose_Click);
            // 
            // label_MaxId
            // 
            this.label_MaxId.AutoSize = true;
            this.label_MaxId.Location = new System.Drawing.Point(181, 138);
            this.label_MaxId.Name = "label_MaxId";
            this.label_MaxId.Size = new System.Drawing.Size(159, 20);
            this.label_MaxId.TabIndex = 12;
            this.label_MaxId.Text = "图片编号(1~max)";
            // 
            // textBox_imgId
            // 
            this.textBox_imgId.Location = new System.Drawing.Point(98, 132);
            this.textBox_imgId.Name = "textBox_imgId";
            this.textBox_imgId.Size = new System.Drawing.Size(77, 30);
            this.textBox_imgId.TabIndex = 11;
            // 
            // label_Query
            // 
            this.label_Query.AutoSize = true;
            this.label_Query.Location = new System.Drawing.Point(12, 138);
            this.label_Query.Name = "label_Query";
            this.label_Query.Size = new System.Drawing.Size(79, 20);
            this.label_Query.TabIndex = 10;
            this.label_Query.Text = "查  询:";
            // 
            // button_dbQuery
            // 
            this.button_dbQuery.Location = new System.Drawing.Point(346, 132);
            this.button_dbQuery.Name = "button_dbQuery";
            this.button_dbQuery.Size = new System.Drawing.Size(95, 34);
            this.button_dbQuery.TabIndex = 8;
            this.button_dbQuery.Text = "提取";
            this.button_dbQuery.UseVisualStyleBackColor = true;
            this.button_dbQuery.Click += new System.EventHandler(this.button_dbQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 590);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "GallerySQL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_imgWrite;
        private System.Windows.Forms.TextBox textBox_imgPath;
        private System.Windows.Forms.TextBox textBox_dbConn;
        private System.Windows.Forms.Button button_imgPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_dbConn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Query;
        private System.Windows.Forms.Button button_dbQuery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_MaxId;
        private System.Windows.Forms.TextBox textBox_imgId;
        private System.Windows.Forms.Button button_dbClose;
    }
}

