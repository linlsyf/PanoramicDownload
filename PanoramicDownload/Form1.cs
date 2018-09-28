﻿using System;
using AutoUpdateHelper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanoramicDownload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UIInit();
        }

        /// <summary>
        /// UI状态初始化
        /// </summary>
        private void UIInit()
        {
           //、LocalConf conf = new LocalConf();
            //同步版本UI
           // Text = "猪猪全景图下载器 v" + conf.Version;
            //设置状态
            UrlStateBox.Image = Properties.Resources.未标题_2;
            //添加检测事件
            InputUrlTextBox.TextChanged += InputUrlTextBox_TextChanged;
        }

        /// <summary>
        /// 检查Url是否是可下载的全景图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputUrlTextBox.Text))
            {
                return;
            }
            string InputUrl = InputUrlTextBox.Text.Trim();
            if (string.IsNullOrEmpty(InputUrl))
            {
                return;
            }
            //获得url中的关键字符     b/l1/01/l1_b_01_01.jpg
            string InputUrlkey = UToos.RegExManager.Matchs(InputUrl); //后几位

            string InputUrlKJZ = UToos.RegExManager.MatchKJL(InputUrl);


            //判断url是否为可访问 
            if (!isPing(InputUrl))
            {
                Mesbox("请输入正确的链接");
                UrlStateBox.Image = Properties.Resources.失败_表情;
                return;
            }
            //判断url是否为可下载的全景图片
            if (InputUrlkey.Equals("") && InputUrlKJZ.Equals(""))
            {
                Mesbox("请输入标准格式的全景图下载地址");
                UrlStateBox.Image = Properties.Resources.失败_表情;
                return;
            }
            if (!InputUrlkey.Equals(""))
            {
                downLoadType = DownLoadType.lx_x_xx_xx;
            }
            if (!InputUrlKJZ.Equals(""))
            {
                downLoadType = DownLoadType.ssssxssss;
            }
            UrlStateBox.Image = Properties.Resources.yes;

        }


        /// <summary>
        /// 图片质量级别
        /// </summary>
        public int ImageQualityIndex;
        /// <summary>
        /// 全景图6分面 单张 横排最高数
        /// </summary>
        public int ImageRowCount;


        private DownLoadType downLoadType = new DownLoadType();
        public Dictionary<string, string> ImagePath = new Dictionary<string, string>();
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ConstPath.exePath + "\\下载文件"))
            {
                FileManager.DelectDir(ConstPath.exePath + "\\下载文件");
                listView1.Items.Clear();
            }

            jiance();

        }
        List<string> newKeystrList = new List<string>();
        public void jiance()
        {
            //清空url中的空白
            string InputUrl = InputUrlTextBox.Text.Trim();
            //获得url中的关键字符     b/l1/01/l1_b_01_01.jpg
            string InputUrlkey = UToos.RegExManager.Matchs(InputUrl); //720云

            string inputUrlKJL = UToos.RegExManager.MatchKJL(InputUrl);//酷家乐


            FileInfo myFile = new FileInfo(ConstPath.exePath + "/config.txt");
            StreamWriter sw5 = myFile.CreateText();


            switch (downLoadType)
            {
                case DownLoadType.lx_x_xx_xx:
                    string newUrl = InputUrl.Substring(0, InputUrl.Length - InputUrlkey.Length + 1);
                    newKeystrList = UToos.RegExManager.GetRegex(InputUrlkey);
                    string newkey1 = "";
                    int maxtpye = 0;
                    int maxIndex = 0;
                    List<string> newKeystr1 = new List<string>();
                    if (newKeystrList[2].Length.Equals(2))
                    {

                        for (int j = 1; j < 20; j++)
                        {
                            newkey1 = InputUrlkey.Replace(newKeystrList[0], "l" + j).Replace("/" + newKeystrList[1], "/01").Replace("_" + newKeystrList[2] + "_", "_01_").Replace("_" + newKeystrList[3] + ".", "_01.");
                            if (isPing(newUrl + newkey1))
                            {
                                maxtpye = j;
                            }
                            else
                            {
                                break;
                            }
                        }
                        ImageQualityIndex = maxtpye;
                        //MessageBox.Show(maxtpye.ToString());
                        newkey1 = InputUrlkey.Replace(newKeystrList[0], "l" + maxtpye).Replace("/" + newKeystrList[1], "/01").Replace("_" + newKeystrList[2] + "_", "_01_").Replace("_" + newKeystrList[3] + ".", "_01.");

                        newKeystr1 = UToos.RegExManager.GetRegex(newkey1);
                        for (int i = 1; i < 20; i++)
                        {
                            string value1 = "";
                            if (i >= 10)
                            {
                                value1 = newkey1.Replace("/" + newKeystr1[1] + "/", "/" + i + "/").Replace("_" + newKeystr1[2] + "_", "_" + i + "_");
                                if (isPing(newUrl + value1))
                                {
                                    maxIndex = i;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                value1 = newkey1.Replace("/" + newKeystr1[1] + "/", "/0" + i + "/").Replace("_" + newKeystr1[2] + "_", "_0" + i + "_");
                                if (isPing(newUrl + value1))
                                {
                                    maxIndex = i;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        ImageRowCount = maxIndex;

                        writeTxt(DirectionType.b, maxIndex, newUrl, maxtpye, sw5);
                        writeTxt(DirectionType.d, maxIndex, newUrl, maxtpye, sw5);
                        writeTxt(DirectionType.f, maxIndex, newUrl, maxtpye, sw5);
                        writeTxt(DirectionType.r, maxIndex, newUrl, maxtpye, sw5);
                        writeTxt(DirectionType.u, maxIndex, newUrl, maxtpye, sw5);
                        writeTxt(DirectionType.l, maxIndex, newUrl, maxtpye, sw5);
                        sw5.Close();
                        sw5.Dispose();

                        var command = " -i " + ConstPath.exePath + "/config.txt  -d" + ConstPath.exePath + "/下载文件";
                        using (var p = new Process())
                        {
                            RedirectExcuteProcess(p, ConstPath.exePath + "/aria2c.exe", command, (s, e) => ShowInfo("", e.Data));
                            p.Close();
                        }

                        Mesbox("配置文件已生成=====请等待下载");
                        return;
                    }

                    for (int j = 1; j < 20; j++)
                    {
                        newkey1 = InputUrlkey.Replace(newKeystrList[0], "l" + j).Replace("/" + newKeystrList[1], "/1").Replace("_" + newKeystrList[2] + "_", "_1_").Replace("_" + newKeystrList[3] + ".", "_1.");
                        if (isPing(newUrl + newkey1))
                        {
                            maxtpye = j;
                        }
                        else
                        {
                            break;
                        }
                    }
                    ImageQualityIndex = maxtpye;
                    //MessageBox.Show(maxtpye.ToString());
                    newkey1 = InputUrlkey.Replace(newKeystrList[0], "l" + maxtpye).Replace("/" + newKeystrList[1], "/1").Replace("_" + newKeystrList[2] + "_", "_1_").Replace("_" + newKeystrList[3] + ".", "_1.");
                    newKeystr1 = UToos.RegExManager.GetRegex(newkey1);
                    for (int i = 1; i < 20; i++)
                    {
                        string value1 = newkey1.Replace("/" + newKeystr1[1] + "/", "/" + i + "/").Replace("_" + newKeystr1[2] + "_", "_" + i + "_");
                        if (isPing(newUrl + value1))
                        {
                            maxIndex = i;
                        }
                        else
                        {
                            break;
                        }
                    }
                    writeTxt1(DirectionType.b, maxIndex, newUrl, maxtpye, sw5);
                    writeTxt1(DirectionType.d, maxIndex, newUrl, maxtpye, sw5);
                    writeTxt1(DirectionType.f, maxIndex, newUrl, maxtpye, sw5);
                    writeTxt1(DirectionType.r, maxIndex, newUrl, maxtpye, sw5);
                    writeTxt1(DirectionType.u, maxIndex, newUrl, maxtpye, sw5);
                    writeTxt1(DirectionType.l, maxIndex, newUrl, maxtpye, sw5);
                    sw5.Close();
                    sw5.Dispose();


                    var command1 = " -i " + ConstPath.exePath + "/config.txt   --save-session=" + ConstPath.exePath + "/out.txt" + " -d" + ConstPath.exePath + "/下载文件/";
                    using (var p = new Process())
                    {
                        RedirectExcuteProcess(p, ConstPath.exePath + "/aria2c.exe", command1, (s, e) => ShowInfo("", e.Data));
                        p.Close();
                    }
                    //MessageBox.Show(maxIndex.ToString());
                    ImageRowCount = maxIndex;
                    Mesbox("配置文件已生成=====请等待下载");



                    break;
                case DownLoadType.ssssxssss:
                    FileInfo myFile1 = new FileInfo(ConstPath.exePath + "/compound.txt");
                    StreamWriter sw51 = myFile1.CreateText();
                    int index = InputUrl.IndexOf(".jpg", 1, InputUrl.Length - 1);
                    string newstr = InputUrl.Remove(index + 4, InputUrl.Length - index - 4);
                    sw5.WriteLine(newstr + "_" + DirectionType.b);
                    sw5.WriteLine(newstr + "_" + DirectionType.d);
                    sw5.WriteLine(newstr + "_" + DirectionType.f);
                    sw5.WriteLine(newstr + "_" + DirectionType.l);
                    sw5.WriteLine(newstr + "_" + DirectionType.r);
                    sw5.WriteLine(newstr + "_" + DirectionType.u);
                    sw5.Close();
                    sw5.Dispose();

                    var command2 = " -i " + ConstPath.exePath + "/config.txt   --save-session=" + ConstPath.exePath + "/out.txt" + " -d" + ConstPath.exePath + "/下载文件/";
                    using (var p = new Process())
                    {
                        RedirectExcuteProcess(p, ConstPath.exePath + "/aria2c.exe", command2, (s, e) => ShowInfo("", e.Data));
                        
                        p.Close();
                        
                    }

                    Thread.Sleep(5200);
                    string[] sDirectories = Directory.GetFiles(ConstPath.exePath + "\\下载文件\\");
                    for (int i = 0; i < sDirectories.Length; i++)
                    {

                        string sDirectoryName = Path.GetFileName(sDirectories[i]);
                        string newstrDir = sDirectoryName.Remove(0, sDirectoryName.Length - 1);
                        string sNewDirectoryName = newstrDir + ".jpg";
                        string sNewDirectory = Path.Combine(ConstPath.exePath + "\\下载文件\\", sNewDirectoryName);
                        Directory.Move(sDirectories[i], sNewDirectory);
                        sw51.WriteLine(sNewDirectory);
                    }

                    sw51.Close();
                    sw51.Dispose();


                    break;
                default:
                    Mesbox("未知错误------->" + downLoadType);
                    break;
            }
        }

        public static bool IsFileInUse(string fileName)
        {
            bool inUse = true;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read,
                FileShare.None);
                inUse = false;
            }
            catch
            {
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return inUse;//true表示正在使用,false没有使用  
        }

        /// <summary>
        ///  有0的
        /// </summary>
        /// <param name="type"></param>
        /// <param name="maxIndex"></param>
        /// <param name="newUrl"></param>
        /// <param name="maxtpye"></param>
        /// <param name="sw5"></param>
        public void writeTxt(DirectionType type, int maxIndex, string newUrl, int maxtpye, StreamWriter sw5)
        {
            for (int i = 1; i <= maxIndex; i++)
            {
                for (int x = 1; x <= maxIndex; x++)
                {
                    bool get1 = false;
                    bool get = false;
                    if (i < 10 && x < 10)
                    {
                        get = isPing(newUrl + type + "/" + "l" + maxtpye + "/0" + i + "/l" + maxtpye + "_" + type + "_0" + i + "_0" + x + ".jpg");
                        if (get)
                        {
                            string url = newUrl + type + "/" + "l" + maxtpye + "/0" + i + "/l" + maxtpye + "_" + type + "_0" + i + "_0" + x + ".jpg";
                            sw5.WriteLine(url);
                        }
                    }
                    if (i < 10 && x >= 10)
                    {
                        get1 = isPing(newUrl + type + "/" + "l" + maxtpye + "/0" + i + "/l" + maxtpye + "_" + type + "_0" + i + "_" + x + ".jpg");
                        if (get1)
                        {
                            string url = newUrl + type + "/" + "l" + maxtpye + "/0" + i + "/l" + maxtpye + "_" + type + "_0" + i + "_" + x + ".jpg";
                            sw5.WriteLine(url);
                        }
                    }
                    if (i >= 10 && x >= 10)
                    {
                        get1 = isPing(newUrl + type + "/" + "l" + maxtpye + "/" + i + "/l" + maxtpye + "_" + type + "_" + i + "_" + x + ".jpg");
                        if (get1)
                        {
                            string url = newUrl + type + "/" + "l" + maxtpye + "/" + i + "/l" + maxtpye + "_" + type + "_" + i + "_" + x + ".jpg";
                            sw5.WriteLine(url);
                        }
                    }
                    if (i >= 10 && x < 10)
                    {
                        get1 = isPing(newUrl + type + "/" + "l" + maxtpye + "/" + i + "/l" + maxtpye + "_" + type + "_" + i + "_0" + x + ".jpg");
                        if (get1)
                        {
                            string url = newUrl + type + "/" + "l" + maxtpye + "/" + i + "/l" + maxtpye + "_" + type + "_" + i + "_0" + x + ".jpg";
                            sw5.WriteLine(url);
                        }
                    }
                }
            }

        }
        public void writeTxt1(DirectionType type, int maxIndex, string newUrl, int maxtpye, StreamWriter sw5)
        {
            for (int i = 1; i <= maxIndex; i++)
            {
                for (int x = 1; x <= maxIndex; x++)
                {
                    bool get = isPing(newUrl + type + "/" + "l" + maxtpye + "/" + i + "/l" + maxtpye + "_" + type + "_" + i + "_" + x + ".jpg");
                    if (get)
                    {
                        string url = newUrl + type + "/" + "l" + maxtpye + "/" + i + "/l" + maxtpye + "_" + type + "_" + i + "_" + x + ".jpg";
                        sw5.WriteLine(url);
                    }
                }
            }
        }




        public void fullfile(string confi, string Url, string index, int forint, DirectionType mode, List<string> sw)
        {
            for (int i = 1; i <= forint; i++)
            {
                for (int x = 1; x <= forint; x++)
                {
                    bool get = isPing(Url + mode + "/" + "l" + index + "/" + i + "/l" + index + "_" + mode + "_" + i + "_" + x + ".jpg");
                    if (get)
                    {
                        string url = "";
                        var command = " -j 5  " + Url + mode + "/l" + index + "/" + i + "/l" + index + "_" + mode + "_" + i + "_" + x + ".jpg  -d " + confi + "";
                        using (var p = new Process())
                        {
                            RedirectExcuteProcess(p, @"D:\test\aria2c.exe", command, (s, e) => ShowInfo(url, e.Data));
                            p.Close();
                        }
                    }
                }
            }

        }

        private void ShowInfo(string url, string a)
        {
            if (a == null) return;

            Thread_proc(a);
        }
        /// <summary>
        /// 重定向
        /// </summary>
        /// <param name="p"></param>
        /// <param name="exe"></param>
        /// <param name="arg"></param>
        /// <param name="output"></param>
        private void RedirectExcuteProcess(Process p, string exe, string arg, DataReceivedEventHandler output)
        {
            p.StartInfo.FileName = exe;
            p.StartInfo.Arguments = arg;
            p.StartInfo.UseShellExecute = false;    //输出信息重定向
            p.StartInfo.ErrorDialog = false;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;


            p.OutputDataReceived += output;
            p.ErrorDataReceived += output;


            p.Start();                    //启动线程
            Application.DoEvents();
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            //p.WaitForExit();            //等待进程结束

            p.Exited += P_Exited;
        }

        private void P_Exited(object sender, EventArgs e)
        {
            Mesbox("执行完毕");
        }





        public void getimg(string filepath, string imgName, string tpye, int index, StreamWriter sw5)
        {
 

            ListViewItem lvi = new ListViewItem();

            ProgressBar dd = new ProgressBar();
            //dd.Maximum = 0;
            this.listView1.BeginUpdate();
            lvi.Text = tpye + ".jpg";
            int idd = 0;
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");

            this.listView1.Items.Add(lvi);
            dd.Maximum = 100;
            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
            int contwidth = 0;



            for (int x = 1; x <= index; x++)
            {
                Image image3 = null;
                if (newKeystrList[2].Length.Equals(2))
                {
                    if (x < 10)
                    {
                        image3 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_0" + 1 + "_0" + x + ".jpg");
                    }
                    else
                    {
                        image3 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_0" + 1 + "_" + x + ".jpg");
                    }

                }
                else
                {
                    image3 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_" + 1 + "_" + x + ".jpg");
                }
                int i = image3.Width;
                contwidth += i;
                image3.Dispose();
            }

            Image bmp = new Bitmap(contwidth, contwidth, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);
            int high = 0;

            for (int i = 1; i <= index; i++)
            {
                int width = 0;
                for (int d = 1; d <= index; d++)
                {
                    Application.DoEvents();
                    Image image1 = null;
                    if (newKeystrList[2].Length.Equals(2))
                    {
                        if (i < 10 && d < 10)
                        {
                            image1 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_0" + i + "_0" + d + ".jpg");
                        }
                        if (d >= 10 && i >= 10)
                        {
                            image1 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_" + i + "_" + d + ".jpg");
                        }
                        if (d >= 10 && i < 10)
                        {
                            image1 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_0" + i + "_" + d + ".jpg");
                        }
                        if (d < 10 && i >= 10)
                        {
                            image1 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_" + i + "_0" + d + ".jpg");
                        }
                    }
                    else
                    {
                        image1 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_" + i + "_" + d + ".jpg");
                    }

                    g.DrawImage(image1, width, high, image1.Width, image1.Height);
                    width += image1.Width;
                    image1.Dispose();
                    idd++;

                    this.listView1.BeginUpdate();
                    //lvi.SubItems[2].Text = idd.ToString();
                    dd.Parent = listView1;
                    dd.SetBounds(lvi.SubItems[1].Bounds.X, lvi.SubItems[1].Bounds.Y, lvi.SubItems[1].Bounds.Width, lvi.SubItems[1].Bounds.Height);


                    Thread.Sleep(5);
                    float max = ImageRowCount * ImageRowCount;
                    float flomax = max / 100;
                    dd.Value = (int)(idd / flomax);

                    this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
                    Application.DoEvents();

                    lvi.SubItems[2].Text = (int)(idd / flomax) + "%";
                    //  lvi.SubItems[2].Text = flomax + "%";
                    if (dd.Value == 100)
                    {

                        lvi.SubItems[2].Text = "完成😀";
                    }
                }
                Image image2 = null;
                if (newKeystrList[2].Length.Equals(2))
                {
                    if (i < 10)
                    {
                        image2 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_0" + i + "_0" + 1 + ".jpg");
                    }
                    else
                    {
                        image2 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_" + i + "_0" + 1 + ".jpg");
                    }
                }
                else
                {
                    image2 = Image.FromFile(filepath + "l" + imgName + "_" + tpye + "_" + i + "_" + i + ".jpg");
                }
                high += image2.Height;
                image2.Dispose();
            }

            g.Flush();
            g.Dispose();
            bmp.Save(ConstPath.exePath + "/下载文件/" + tpye + ".JPG", ImageFormat.Jpeg);
            bmp.Dispose();

            //sw5.WriteLine(ConstPath.exePath + "\\下载文件\\" + tpye + ".JPG");

           

            ImagePath.Add(tpye, ConstPath.exePath + "\\下载文件\\" + tpye + ".JPG");

        }

        delegate void d(string args);
        private delegate void UpdateInfo(string str);
        void Thread_proc(string args)
        {
            if (this.InvokeRequired)
            {
                d dd = new d(Thread_proc);
                this.Invoke(dd, new object[] { args });
            }
            else
            {
                if (args == null)
                {
                    return;
                }
                const string re1 = ".*?"; // Non-greedy match on filler
                const string re2 = "(\\(.*\\))"; // Round Braces 1

                var r = new Regex(re1 + re2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                var m = r.Match(args);
                if (m.Success)
                {
                    var rbraces1 = m.Groups[1].ToString().Replace("(", "").Replace(")", "").Replace("%", "").Replace("s", "0");
                    if (rbraces1 == "OK")
                    {
                        rbraces1 = "100";
                    }
                }
            }
        }

        delegate void imags(string args, string args1, string args2, int index);



        #region 一般级
        /// <summary>
        /// 配置文件路径按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = OpenText();
        }

        #region  社交类
        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ConstPath.mailUrl);
        }

        /// <summary>
        /// 联系qq
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", ConstPath.qqUrl);
        }


        /// <summary>
        /// 图标点击 互动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IconInteraction_OnCilck(object sender, EventArgs e)
        {
            if (toolTip1.GetToolTip(pictureBox1).Equals("你瞅啥？？"))
            {
                this.toolTip1.SetToolTip(pictureBox1, "瞅你咋的！！");
            }
            else
            {
                this.toolTip1.SetToolTip(pictureBox1, "你瞅啥？？");
            }
        }
        #endregion




        /// <summary>
        /// 打开路径
        /// </summary>
        /// <returns></returns>
        public string OpenText()
        {
            using (OpenFileDialog OpenFD = new OpenFileDialog())     //实例化一个 OpenFileDialog 的对象
            {
                //定义打开的默认文件夹位置
                OpenFD.InitialDirectory = Application.StartupPath;
                OpenFD.Filter = "All files(*.*)|*.*|txt files(*.txt)|*.txt";
                OpenFD.FilterIndex = 2;
                OpenFD.ShowDialog();                  //显示打开本地文件的窗体
                OpenFD.RestoreDirectory = true;
                return OpenFD.FileName;       //把 路径名称 赋给 fileName
            }
        }
        #endregion

        #region  网络类
        /// <summary>
        /// 判断链接 200
        /// </summary>
        /// <param name="url"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static string GetWebStatusCode(string url, int timeout)
        {
            HttpWebRequest req = null;
            try
            {
                req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
                req.Method = "HEAD";  //这是关键        
                req.Timeout = timeout;

                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                if (res.ContentType.Equals("image/jpeg"))
                {
                    return Convert.ToInt32(res.StatusCode).ToString();
                }
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (req != null)
                {
                    req.Abort();
                    req = null;
                }
            }
        }

        /// <summary>
        /// 如果是图片 并且返回的是200
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public bool isPing(string url)
        {
            if (GetWebStatusCode(url, 2000).Equals("200"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {

            switch (downLoadType)
            {
                case DownLoadType.lx_x_xx_xx:
                    break;
                case DownLoadType.ssssxssss:
                    StreamReader sr = new StreamReader(ConstPath.exePath + "/compound.txt");
                    var command1 = "-l=" + sr.ReadLine() + " -f=" + sr.ReadLine() + " -r=" + sr.ReadLine() + " -b=" + sr.ReadLine() + " -u=" + sr.ReadLine() + " -d=" + sr.ReadLine() + " -o=下载文件/sphere.jpeg";

                    //Thread demoThread =  new Thread(new ThreadStart(this.ThreadProcSafe));
                    // demoThread.Start();

                    using (var p = new Process())
                    {
                        RedirectExcuteProcess(p, ConstPath.exePath + "/kcube2sphere.exe", command1, null);
                        p.Close();
                    }
                    return;
                    break;
                default:
                    break;
            }
            string paths = ConstPath.exePath + "/config.txt";
            string[] strings = File.ReadAllLines(paths);

          //  FileInfo myFile = new FileInfo(ConstPath.exePath + "/compound.txt");
          //  StreamWriter sw5 = myFile.CreateText();

            string path = ConstPath.exePath + "//下载文件//";
            if (strings.Length != 0)
            {
                getimg(path, ImageQualityIndex.ToString(), "d", ImageRowCount, null);//2304//4608//3072
                getimg(path, ImageQualityIndex.ToString(), "f", ImageRowCount, null);//2304//4608//3072
                getimg(path, ImageQualityIndex.ToString(), "b", ImageRowCount, null);//2304//4608//3072
                getimg(path, ImageQualityIndex.ToString(), "u", ImageRowCount, null);//2304//4608//3072
                getimg(path, ImageQualityIndex.ToString(), "l", ImageRowCount, null);//2304//4608//3072
                getimg(path, ImageQualityIndex.ToString(), "r", ImageRowCount, null);//2304//4608//3072
            }
           // sw5.Close();
            //sw5.Dispose();
            string l = ImagePath["l"];
            string f = ImagePath["f"];
            string r = ImagePath["r"];
            string b = ImagePath["b"];
            string u = ImagePath["u"];
            string d = ImagePath["d"];

            //compiler.WaitForExit();
            var command = "-l=" + l + " -f=" + f + " -r=" + r + " -b=" + b + " -u=" + u + " -d=" + d + " -o=下载文件/sphere.jpeg";

            //Thread demoThread =  new Thread(new ThreadStart(this.ThreadProcSafe));
            // demoThread.Start();

            using (var p = new Process())
            {
                RedirectExcuteProcess(p, ConstPath.exePath + "/kcube2sphere.exe", command, null);
                p.Close();
            }
            ImagePath.Clear();
            Mesbox("合成完毕");
        }


        /// <summary>
        /// 提示框封装
        /// </summary>
        /// <param name="content"></param>
        public void Mesbox(string content)
        {
            MessageBox.Show(content, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
        }


        /// <summary>
        /// 打开图片存储文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenImageFile_Click(object sender, EventArgs e)
        {
            string path = ConstPath.exePath + "\\下载文件";
            Process.Start("explorer.exe", path);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


    }
}
