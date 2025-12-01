namespace _202512210_ppt_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Point> lstPoints = new List<Point>();

        Rectangle rect = new Rectangle();

        bool isDrawing = false;


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                lstPoints.Add(new Point(e.X, e.Y));
                this.Invalidate();


               


            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            if (lstPoints.Count > 1)
            {
                g.DrawLines(pen, lstPoints.ToArray());
            }


        }

    }
}



