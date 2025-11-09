namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //绘制图形
            Graphics g = e.Graphics;

            //直接使用未定义的Pen实例，导致编译错误
            //直接使用默认笔是Pens，而不是Pen
            // 修复错误：使用正确的Pen实例

            // Pen redPen = new Pen(Color.Red);
            //这样写也可以
            using (Pen redPen = new Pen(Color.Red,10))
            {
                g.DrawRectangle(redPen, 30, 40, 100, 200);
            }

            //接下来使用Brush绘制填充矩形

            //也可以直接使用Brushes
            //Brush blueBrush = new SolidBrush(Color.Blue);

            using (Brush blueBrush = new SolidBrush(Color.Blue))
            {
                g.FillRectangle(blueBrush, 150, 40, 100, 200);
            }

            // 修复错误：为 DrawBezier 方法提供正确的参数
            g.DrawBezier(Pens.Red, new Point(60, 100), new Point(120, 50), new Point(180, 150), new Point(240, 100));

            g.Flush();
        }
    }
}
