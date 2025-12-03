using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20251117_Music_v2
{
    public partial class MusicProgressBar: UserControl
    {

        public double curPro=0;
        public double Durantion=1;
        //初始位置

        public int Radius=10 ;


        //解决调用问题

        public  void  SetCurPro(double cur)
        {
            curPro = cur;
            this.Invalidate(); //重绘控件
        }
        //在属性中打开双储存缓存



        public MusicProgressBar()
        {
            InitializeComponent();
        }

        private void MusicProgressBar_Load(object sender, EventArgs e)
        {

        }

        Graphics g;
        //在外部重绘事件中使用Graphics对象，以防止多次创建Graphics对象导致资源浪费
        private void MusicProgressBar_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics; 

            Pen BlackPen = new Pen(Color.Black, 3);

            g.DrawLine(BlackPen, 0 ,this.Height / 2, this.Width, this.Height / 2);


            
            Pen YellowPen = new Pen(Color.Yellow , 3);
            int CurX = (int)(curPro / Durantion * this.Width);

            g.DrawLine(YellowPen, 0, this.Height / 2, CurX , this.Height / 2);

            Rectangle rect = new Rectangle(CurX - Radius, this.Height / 2 - Radius, Radius * 2, Radius * 2);

            g.FillEllipse(Brushes.Yellow, rect );


        }
    }
}
