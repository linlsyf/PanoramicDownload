﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanoramicDownload.Core
{
    public class PlatformWZ : PlatformBase
    {
        public ProgressListview listview;
        public int ImageRowCount;
        public Dictionary<string, string> ImagePath = new Dictionary<string, string>();
        public override void WriteDownLoad(DirectionType type = DirectionType.b, int maxIndex = 1, StringBuilder newUrl = null, int maxQuality = 1, StreamWriter SWFile = null)
        {
            for (int i = 1; i <= maxIndex; i++)
            {
                for (int x = 1; x <= maxIndex; x++)
                {
                    StringBuilder url = new StringBuilder(newUrl + "" + type + "/" + "n" + maxQuality + "/" + i + "/" + type + "_" + i + "_" + x + ".jpg");
                    SWFile.WriteLine(url);
                }
            }
        }
        public override void MatchingImage(string imagePath, string imageQuality, string tpye, int imageIndex, StreamWriter SWFile, int progindex)
        {
            ListViewItem lvi = new ListViewItem();
            listview.ProgressColumnIndex = 1;

            lvi.Text = tpye + ".jpg";
            int idd = 0;
            listview.Items.Add(lvi);
            lvi.SubItems.AddRange(new string[] { "0", "0", "0" });
            int contwidth = 0;
            Image image3 = null;
            for (int x = 1; x <= imageIndex; x++)
            {
                if (urlKeysList[2].Length.Equals(2))
                {
                    if (x < 10)
                    {
                        image3 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_0" + 1 + "_0" + x + ".jpg")));
                        //image3 = Image.FromFile(imagePath + tpye + "_0" + 1 + "_0" + x + ".jpg");
                    }
                    else
                    {
                        image3 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_0" + 1 + "_" + x + ".jpg")));
                        //image3 = Image.FromFile(imagePath + tpye + "_0" + 1 + "_" + x + ".jpg");
                    }

                }
                else
                {
                    image3 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_" + 1 + "_" + x + ".jpg")));
                    //image3 = Image.FromFile(imagePath + tpye + "_" + 1 + "_" + x + ".jpg");
                }
                int i = image3.Width;
                contwidth += i;
                image3.Dispose();
            }
            Image bmp = new Bitmap(contwidth, contwidth, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);
            int high = 0;
            Image image1 = null;
            for (int i = 1; i <= imageIndex; i++)
            {
                int width = 0;
                for (int d = 1; d <= imageIndex; d++)
                {
                    Application.DoEvents();
                    if (urlKeysList[2].Length.Equals(2))
                    {
                        if (i < 10 && d < 10)
                        {
                            image1 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_0" + i + "_0" + d + ".jpg")));
                            // image1 = Image.FromFile(imagePath  + tpye + "_0" + i + "_0" + d + ".jpg");
                        }
                        if (d >= 10 && i >= 10)
                        {
                            image1 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_" + i + "_" + d + ".jpg")));
                            //image1 = Image.FromFile(imagePath   + tpye + "_" + i + "_" + d + ".jpg");
                        }
                        if (d >= 10 && i < 10)
                        {
                            image1 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_0" + i + "_" + d + ".jpg")));
                            //image1 = Image.FromFile(imagePath + tpye + "_0" + i + "_" + d + ".jpg");
                        }
                        if (d < 10 && i >= 10)
                        {
                            image1 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_" + i + "_0" + d + ".jpg")));
                            //image1 = Image.FromFile(imagePath + tpye + "_" + i + "_0" + d + ".jpg");
                        }
                    }
                    else
                    {
                        image1 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_" + i + "_" + d + ".jpg")));
                        // image1 = Image.FromFile(imagePath + tpye + "_" + i + "_" + d + ".jpg");
                    }

                    g.DrawImage(image1, width, high, image1.Width, image1.Height);
                    width += image1.Width;
                    image1.Dispose();
                    idd++;

                    float max = ImageRowCount * ImageRowCount;
                    float flomax = max / 100;

                    var th = new Thread(delegate ()
                    {
                        listview.SetProgress(progindex, Convert.ToInt32(idd / flomax));
                        Thread.Sleep(10);
                    });
                    th.IsBackground = true;
                    th.Start();


                    Application.DoEvents();

                    lvi.SubItems[2].Text = Convert.ToInt32(idd / flomax) + "%";


                }
                Image image2 = null;
                if (urlKeysList[2].Length.Equals(2))
                {
                    if (i < 10)
                    {
                        image2 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_0" + i + "_0" + 1 + ".jpg")));
                        //image2 = Image.FromFile(imagePath + tpye + "_0" + i + "_0" + 1 + ".jpg");
                    }
                    else
                    {
                        image2 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_" + i + "_0" + 1 + ".jpg")));
                        //image2 = Image.FromFile(imagePath + tpye + "_" + i + "_0" + 1 + ".jpg");
                    }
                }
                else
                {
                    image2 = Image.FromStream(ByteToStream(SetImageToByteArray(imagePath + tpye + "_" + i + "_" + i + ".jpg")));
                    //image2 = Image.FromFile(imagePath + tpye + "_" + i + "_" + i + ".jpg");
                }
                high += image2.Height;
                image2.Dispose();
            }

            g.Flush();
            g.Dispose();
            bmp.Save(ConstPath.saveFile + tpye + ".JPG", ImageFormat.Jpeg);
            bmp.Dispose();
            ImagePath.Add(tpye, ConstPath.saveFile + tpye + ".JPG");
        }
    }
}
