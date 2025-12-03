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

        public double curPro=0.5;
        public double Durantion=1;
        public int Radius=10 ;


        public MusicProgressBar()
        {
            InitializeComponent();
        }

        private void MusicProgressBar_Load(object sender, EventArgs e)
        {

        }

        private void MusicProgressBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 

            Pen BlackPen = new Pen(Color.Black, 3);

            g.DrawLine(BlackPen, 0 ,this.Height / 2, this.Width, this.Height / 2);


            
            Pen YellowPen = new Pen(Color.Black, 3);
            int CurX = (int)(curPro / Durantion * this.Width);

            g.DrawLine(YellowPen, 0, this.Height / 2, CurX , this.Height / 2);

            Rectangle rect = new Rectangle(CurX - Radius, this.Height / 2 - Radius, Radius * 2, Radius * 2);

            g.FillEllipse(Brushes.Yellow, rect );


        }
    }
}
