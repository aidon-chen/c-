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


//重构2

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
            //读取歌词

            //选取Lyric
            Lyric.Load("薛之谦-演员.lrc");



            timer1 .Enabled = true;
            timer1.Interval = 1000;

        } 
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = Lyric.lines[i].Text;
            i++;

            //从lyric调用lines
        }
    }
}
