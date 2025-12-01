using Microsoft.VisualBasic.Devices;

namespace WinFormsApp_draw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            rect = new Rects();

            rect.X = random.Next(this.Width );

            rect.Y = random.Next(this.Height );

            int a = random.Next(100);

            rect.w = a;
            rect.h = a;

            rect.c= Color .FromArgb (random .Next(255),random.Next(255), random.Next(255));

           // lstRects.Add(rect);
            
            this.Invalidate();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            Graphics g = e.Graphics;
            

            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, rect.X, rect.Y, rect.w, rect.h);

            g.Flush (); 
        }


            class Rects
        {
            public int X;
            public int Y;
            public int w;
            public int h;
            public Color c;

        }

        Rects rect = new Rects();
        //只存在单一的图形

       // List<Rects> rects = new List<Rects>();

        //使用list储存多个图形

        //这是一段测试分支的注释





    }
}
