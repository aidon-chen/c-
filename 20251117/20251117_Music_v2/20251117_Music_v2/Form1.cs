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

        SongAlnum songAlnum = new SongAlnum();

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

            musicProgressBar1.SetCurPro(axWindowsMediaPlayer1 .Ctlcontrols.currentPosition);

            if(axWindowsMediaPlayer1.currentMedia .duration  <= 0)


            { 
            musicProgressBar1.Durantion = 1;
            }
            else
            {
                musicProgressBar1.Durantion = axWindowsMediaPlayer1.currentMedia.duration;
            }

            //使用if语句防止除以0报错 ，try语句没有这种情况无法避免

            //进度条显示音乐进度
            //使用try catch防止报错   ，异步加载媒体文件歌曲文件太大可能会发生无法及时加载完成的情况，导致currentMedia为空引用进而报错

            int curIdx = 0;
            //存储与时间匹配的歌词索引

            //歌词同步显示
            for (i = 0; i < Lyric.lines.Count; i++)
            {
                if (curTime > Lyric.lines[i].time && curTime < Lyric.lines[i+1].time )
                //找到当前时间所在的歌词区间
                {
                    curIdx = i;
                    
                    break;
                }
            }

            lblLyric.Text =  Lyric.lines[curIdx].text;
            //括号外找不到i，使用curIdx

        }

        int curIdx = 0;

        //记录当前歌词索引
        class SongAlnum
        {
            //歌曲专辑类
            public string title;

            public List<SongInfo> lstSongs = new List<SongInfo>();


        }

     
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //读取歌词

            //选取Lyric
            //Lyric.Load("薛之谦-演员.lrc");

            // axWindowsMediaPlayer1.URL = "薛之谦-演员.mp3";
            //调取MP3播放


            // timer1.Enabled = true;
            //timer1.Interval = 100;

            //载入分析歌词
            Lyric.Load("Lyric\\" + songAlnum.lstSongs[curIdx].lyricFileName);

            // timer1.Enabled = true;
            //timer1.Interval = 100;

            //载入分析歌词

            Lyric.Load("Lyric\\" + songAlnum.lstSongs[curIdx].lyricFileName);

            //播放音乐
            axWindowsMediaPlayer1.URL = "song\\" + songAlnum.lstSongs[curIdx].mp3FileName;


            //更换背景图片
            this.BackgroundImage = Image.FromFile("bg\\" + songAlnum.lstSongs[curIdx].bgFileName);

            Lyric.Load("Lyric\\" + songAlnum.lstSongs[curIdx].lyricFileName);

            //播放音乐
            axWindowsMediaPlayer1.URL = "song\\" + songAlnum.lstSongs[curIdx].mp3FileName;


            //更换背景图片
            this.BackgroundImage = Image.FromFile("bg\\" + songAlnum.lstSongs[curIdx].bgFileName);


            //启动计时器
            timer1.Enabled = true;
            timer1.Interval = 100;
        }



        private void picNext_Click(object sender, EventArgs e)
        {
            //读取歌词

            //选取Lyric
           // Lyric.Load("薛之谦-演员.lrc");

            //axWindowsMediaPlayer1.URL = "薛之谦-演员.mp3";
            //调取MP3播放


            //timer1.Enabled = true;
           // timer1.Interval = 100;
            
            curIdx++;

            //载入分析歌词

            Lyric.Load("Lyric\\" + songAlnum.lstSongs[curIdx % songAlnum.lstSongs.Count].lyricFileName);

            //播放音乐
            axWindowsMediaPlayer1.URL = "song\\" + songAlnum.lstSongs[curIdx].mp3FileName;


            //更换背景图片
            this.BackgroundImage = Image.FromFile("bg\\" + songAlnum.lstSongs[curIdx].bgFileName);


            //启动计时器
            timer1.Enabled = true;
            timer1.Interval = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体加载时的操作，一次性的操作较多

            songAlnum.title = "My Favorite Songs";


            songAlnum.lstSongs.Add(
              new SongInfo("陈一发儿-童话镇.lrc",
              "陈一发儿-童话镇.mp3",
              "陈一发儿-童话镇.jpg"
              ));


            songAlnum.lstSongs.Add(
                new SongInfo("大壮-我们不一样.lrc",
                "大壮-我们不一样.mp3",
                "大壮-我们不一样.jpg"
                ));



            songAlnum.lstSongs.Add(
                new SongInfo("金南玲-逆流成河.lrc",
                "金南玲-逆流成河.mp3",
                "金南玲-逆流成河.jpg"
                ));


            songAlnum.lstSongs.Add(
                new SongInfo("薛之谦-演员.lrc",
                "薛之谦-演员.mp3",
                "薛之谦-演员.jpg"
                ));


            songAlnum.lstSongs.Add(
                new SongInfo("音阙诗听-红昭愿.lrc",
                "音阙诗听-红昭愿.mp3",
                "音阙诗听-红昭愿.jpg"
                ));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //调用服务器可以
        }
    }


  


    class SongInfo
    {
        //歌曲信息类
        public string lyricFileName;
        public string bgFileName;
        public string mp3FileName;

        public SongInfo(string lyricFn, string mp3Fn, string bgFn)
        {
            lyricFileName = lyricFn;
            mp3FileName = mp3Fn;
            bgFileName = bgFn;
        }
    }
}
