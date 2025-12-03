using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace _20251117_Music_v2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Lyric Lyric = new Lyric();
        //定义一个Lyric对象
        private void button1_Click(object sender, EventArgs e)
        {

        } 
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime .Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString+ "/" 
                + axWindowsMediaPlayer1.currentMedia.durationString;

            //创建Label显示时间
           


            double curTime = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;


            try
            {
                progressBar1.Value = (int)(curTime / axWindowsMediaPlayer1.currentMedia.duration * 100);
            }
            catch (Exception ex)
            {
                progressBar1.Value = 0;
            }

            //进度条显示音乐进度
            //使用try catch防止报错   ，异步加载媒体文件歌曲文件太大可能会发生无法及时加载完成的情况，导致currentMedia为空引用进而报错

            int curIdx = 0;
            //存储与时间匹配的歌词索引

            //歌词同步显示
            for (i = 0; i < Lyric.lines.Count; i++)
            {
                if (curTime > Lyric.lines[i].Time && curTime < Lyric.lines[i+1].Time )
                //找到当前时间所在的歌词区间
                {
                    curIdx = i;
                    
                    break;
                }
            }

            lblLyric.Text =  Lyric.lines[curIdx].Text;
            //括号外找不到i，使用curIdx

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //读取歌词

            //选取Lyric
            Lyric.Load("薛之谦-演员.lrc");

            axWindowsMediaPlayer1.URL = "薛之谦-演员.mp3";
            //调取MP3播放


            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
