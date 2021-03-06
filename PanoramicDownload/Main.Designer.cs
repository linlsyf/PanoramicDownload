﻿namespace PanoramicDownload
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Pay_Button = new HslCommunication.Controls.UserButton();
            this.Activate_Button = new HslCommunication.Controls.UserButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UrlStateBox = new System.Windows.Forms.PictureBox();
            this.timer_Tick = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.DownLoadImage_Button = new HslCommunication.Controls.UserButton();
            this.Log_texBox = new System.Windows.Forms.TextBox();
            this.MakeImage_Button = new HslCommunication.Controls.UserButton();
            this.SetImageSavePath_Button = new HslCommunication.Controls.UserButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UseExplain_Link = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.InputUrl_TextBox = new System.Windows.Forms.TextBox();
            this.OpenImagePath_Button = new HslCommunication.Controls.UserButton();
            this.ImageSavePath_Label = new System.Windows.Forms.Label();
            this.MakePano_Button = new HslCommunication.Controls.UserButton();
            this.ADW_label = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ProgressListview(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlStateBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolTip1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.Tag = "";
            // 
            // Pay_Button
            // 
            this.Pay_Button.BackColor = System.Drawing.Color.Transparent;
            this.Pay_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pay_Button.CustomerInformation = "";
            this.Pay_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Pay_Button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Pay_Button.Location = new System.Drawing.Point(303, 3);
            this.Pay_Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Pay_Button.Name = "Pay_Button";
            this.Pay_Button.OriginalColor = System.Drawing.SystemColors.InactiveCaption;
            this.Pay_Button.Size = new System.Drawing.Size(70, 33);
            this.Pay_Button.TabIndex = 20;
            this.toolTip1.SetToolTip(this.Pay_Button, "激活软件联系 qq:1228267639");
            this.Pay_Button.UIText = "付款码";
            this.Pay_Button.Click += new System.EventHandler(this.Pay_Button_Click);
            // 
            // Activate_Button
            // 
            this.Activate_Button.BackColor = System.Drawing.Color.Transparent;
            this.Activate_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Activate_Button.CustomerInformation = "";
            this.Activate_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Activate_Button.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Activate_Button.Location = new System.Drawing.Point(392, 3);
            this.Activate_Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Activate_Button.Name = "Activate_Button";
            this.Activate_Button.OriginalColor = System.Drawing.SystemColors.InactiveCaption;
            this.Activate_Button.Size = new System.Drawing.Size(80, 33);
            this.Activate_Button.TabIndex = 6;
            this.toolTip1.SetToolTip(this.Activate_Button, "激活软件联系 qq:1228267639");
            this.Activate_Button.UIText = "激活软件";
            this.Activate_Button.Click += new System.EventHandler(this.Activate_Button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PanoramicDownload.Properties.Resources.问好;
            this.pictureBox2.Location = new System.Drawing.Point(116, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "请输入本软件支持平台的全景链接  先观看使用说明在进行操作");
            // 
            // UrlStateBox
            // 
            this.UrlStateBox.Image = global::PanoramicDownload.Properties.Resources.yes;
            this.UrlStateBox.Location = new System.Drawing.Point(491, 13);
            this.UrlStateBox.Name = "UrlStateBox";
            this.UrlStateBox.Size = new System.Drawing.Size(48, 51);
            this.UrlStateBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UrlStateBox.TabIndex = 6;
            this.UrlStateBox.TabStop = false;
            this.toolTip1.SetToolTip(this.UrlStateBox, "使用笑脸判断链接是否为可下载的全景图链接");
            // 
            // timer_Tick
            // 
            this.timer_Tick.Enabled = true;
            this.timer_Tick.Interval = 10;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 719);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(666, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(666, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(666, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 719);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 719);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContentPanel.Size = new System.Drawing.Size(666, 719);
            // 
            // DownLoadImage_Button
            // 
            this.DownLoadImage_Button.BackColor = System.Drawing.Color.Transparent;
            this.DownLoadImage_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DownLoadImage_Button.CustomerInformation = "";
            this.DownLoadImage_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.DownLoadImage_Button.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.DownLoadImage_Button.Location = new System.Drawing.Point(3, 4);
            this.DownLoadImage_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DownLoadImage_Button.Name = "DownLoadImage_Button";
            this.DownLoadImage_Button.Size = new System.Drawing.Size(60, 39);
            this.DownLoadImage_Button.TabIndex = 16;
            this.DownLoadImage_Button.UIText = "下载";
            this.DownLoadImage_Button.Click += new System.EventHandler(this.DownLoadImage_Button_Click);
            // 
            // Log_texBox
            // 
            this.Log_texBox.Location = new System.Drawing.Point(28, 376);
            this.Log_texBox.Margin = new System.Windows.Forms.Padding(2);
            this.Log_texBox.Multiline = true;
            this.Log_texBox.Name = "Log_texBox";
            this.Log_texBox.Size = new System.Drawing.Size(570, 70);
            this.Log_texBox.TabIndex = 15;
            // 
            // MakeImage_Button
            // 
            this.MakeImage_Button.BackColor = System.Drawing.Color.Transparent;
            this.MakeImage_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MakeImage_Button.CustomerInformation = "";
            this.MakeImage_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.MakeImage_Button.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.MakeImage_Button.Location = new System.Drawing.Point(69, 4);
            this.MakeImage_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MakeImage_Button.Name = "MakeImage_Button";
            this.MakeImage_Button.Size = new System.Drawing.Size(60, 39);
            this.MakeImage_Button.TabIndex = 17;
            this.MakeImage_Button.UIText = "合成";
            this.MakeImage_Button.Click += new System.EventHandler(this.MakeImage_Button_Click_1);
            // 
            // SetImageSavePath_Button
            // 
            this.SetImageSavePath_Button.BackColor = System.Drawing.Color.Transparent;
            this.SetImageSavePath_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SetImageSavePath_Button.CustomerInformation = "";
            this.SetImageSavePath_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.SetImageSavePath_Button.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.SetImageSavePath_Button.Location = new System.Drawing.Point(137, 4);
            this.SetImageSavePath_Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SetImageSavePath_Button.Name = "SetImageSavePath_Button";
            this.SetImageSavePath_Button.Size = new System.Drawing.Size(124, 39);
            this.SetImageSavePath_Button.TabIndex = 18;
            this.SetImageSavePath_Button.UIText = "设置下载目录";
            this.SetImageSavePath_Button.Click += new System.EventHandler(this.SetImageSavePath_Button_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UseExplain_Link);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.Activate_Button);
            this.panel3.Controls.Add(this.UrlStateBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.InputUrl_TextBox);
            this.panel3.Controls.Add(this.Pay_Button);
            this.panel3.Location = new System.Drawing.Point(28, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 72);
            this.panel3.TabIndex = 11;
            // 
            // UseExplain_Link
            // 
            this.UseExplain_Link.AutoSize = true;
            this.UseExplain_Link.Location = new System.Drawing.Point(139, 16);
            this.UseExplain_Link.Name = "UseExplain_Link";
            this.UseExplain_Link.Size = new System.Drawing.Size(53, 12);
            this.UseExplain_Link.TabIndex = 21;
            this.UseExplain_Link.TabStop = true;
            this.UseExplain_Link.Text = "使用说明";
            this.UseExplain_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UseExplain_Link_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "全景图下载链接";
            // 
            // InputUrl_TextBox
            // 
            this.InputUrl_TextBox.Location = new System.Drawing.Point(6, 41);
            this.InputUrl_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.InputUrl_TextBox.Name = "InputUrl_TextBox";
            this.InputUrl_TextBox.Size = new System.Drawing.Size(470, 21);
            this.InputUrl_TextBox.TabIndex = 3;
            // 
            // OpenImagePath_Button
            // 
            this.OpenImagePath_Button.BackColor = System.Drawing.Color.Transparent;
            this.OpenImagePath_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenImagePath_Button.CustomerInformation = "";
            this.OpenImagePath_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.OpenImagePath_Button.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.OpenImagePath_Button.Location = new System.Drawing.Point(373, 4);
            this.OpenImagePath_Button.Margin = new System.Windows.Forms.Padding(4);
            this.OpenImagePath_Button.Name = "OpenImagePath_Button";
            this.OpenImagePath_Button.Size = new System.Drawing.Size(134, 39);
            this.OpenImagePath_Button.TabIndex = 19;
            this.OpenImagePath_Button.UIText = "打开图片目录";
            this.OpenImagePath_Button.Click += new System.EventHandler(this.OpenImagePath_Button_Click);
            // 
            // ImageSavePath_Label
            // 
            this.ImageSavePath_Label.AutoSize = true;
            this.ImageSavePath_Label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImageSavePath_Label.Font = new System.Drawing.Font("楷体", 8F);
            this.ImageSavePath_Label.Location = new System.Drawing.Point(37, 307);
            this.ImageSavePath_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImageSavePath_Label.Name = "ImageSavePath_Label";
            this.ImageSavePath_Label.Size = new System.Drawing.Size(59, 11);
            this.ImageSavePath_Label.TabIndex = 8;
            this.ImageSavePath_Label.Text = ".........";
            this.ImageSavePath_Label.Click += new System.EventHandler(this.ImageSavePath_Label_Click);
            // 
            // MakePano_Button
            // 
            this.MakePano_Button.BackColor = System.Drawing.Color.Transparent;
            this.MakePano_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MakePano_Button.CustomerInformation = "";
            this.MakePano_Button.EnableColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.MakePano_Button.Font = new System.Drawing.Font("微软雅黑", 12.75F);
            this.MakePano_Button.Location = new System.Drawing.Point(271, 4);
            this.MakePano_Button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MakePano_Button.Name = "MakePano_Button";
            this.MakePano_Button.Size = new System.Drawing.Size(93, 39);
            this.MakePano_Button.TabIndex = 21;
            this.MakePano_Button.UIText = "查看全景";
            this.MakePano_Button.Click += new System.EventHandler(this.MakePano_Button_Click);
            // 
            // ADW_label
            // 
            this.ADW_label.AutoSize = true;
            this.ADW_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ADW_label.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ADW_label.ForeColor = System.Drawing.Color.Red;
            this.ADW_label.Location = new System.Drawing.Point(25, 470);
            this.ADW_label.Name = "ADW_label";
            this.ADW_label.Size = new System.Drawing.Size(512, 16);
            this.ADW_label.TabIndex = 22;
            this.ADW_label.Text = "目前支持平台：720yun 建e网 汽车之家 酷家乐 详情咨询：1228267639";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.ImageSavePath_Label);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listView1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Log_texBox);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(616, 502);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(616, 502);
            this.toolStripContainer1.TabIndex = 22;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("楷体", 10F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 450);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "下载目录不要随意设置。每次下载会清空你设置的目录";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.MakeImage_Button, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MakePano_Button, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.SetImageSavePath_Button, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.OpenImagePath_Button, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.DownLoadImage_Button, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 326);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 49);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.Location = new System.Drawing.Point(28, 84);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.ProgressColumnIndex = -1;
            this.listView1.Size = new System.Drawing.Size(570, 223);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "图片名称";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "合成进度";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "合成完成";
            this.columnHeader3.Width = 200;
            // 
            // Main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(616, 502);
            this.Controls.Add(this.ADW_label);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "全景图下载器";
            this.toolTip1.SetToolTip(this, "你知道的太多了");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrlStateBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        /// <summary>
        /// 跑马灯定时器
        /// </summary>
        private System.Windows.Forms.Timer timer_Tick;
        private HslCommunication.Controls.UserButton DownLoadImage_Button;
        /// <summary>
        /// 日志输出Text
        /// </summary>
        private System.Windows.Forms.TextBox Log_texBox;
        private HslCommunication.Controls.UserButton MakeImage_Button;
        private System.Windows.Forms.ProgressListview listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private HslCommunication.Controls.UserButton SetImageSavePath_Button;
        private System.Windows.Forms.Panel panel3;
        /// <summary>
        /// 软件使用说明 
        /// </summary>
        private System.Windows.Forms.LinkLabel UseExplain_Link;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox UrlStateBox;
        private System.Windows.Forms.Label label2;
        /// <summary>
        /// URL输入框
        /// </summary>
        private System.Windows.Forms.TextBox InputUrl_TextBox;
        private HslCommunication.Controls.UserButton OpenImagePath_Button;
        /// <summary>
        /// 激活Button
        /// </summary>
        private HslCommunication.Controls.UserButton Pay_Button;
        /// <summary>
        /// 下载图片的保存路径
        /// </summary>
        private System.Windows.Forms.Label ImageSavePath_Label;
        /// <summary>
        /// 付款Button
        /// </summary>
        private HslCommunication.Controls.UserButton Activate_Button;
        /// <summary>
        /// 查看全景按钮
        /// </summary>
        private HslCommunication.Controls.UserButton MakePano_Button;
        /// <summary>
        /// 跑马灯广告文字
        /// </summary>
        private System.Windows.Forms.Label ADW_label;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}

