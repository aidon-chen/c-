namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Define dx, dy, and random as class-level fields
        private int dx = 2;  // X方向步长（初始向右）
        private int dy = 2;  // Y方向步长（初始向下）
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //or timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Generate random color for the label
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);
            label1.ForeColor = Color.FromArgb(red, green, blue);

            // Get the container dimensions
            int containerWidth = this.ClientSize.Width;
            int containerHeight = this.ClientSize.Height;

            // Calculate the new position of the label
            int newX = label1.Left + dx;
            int newY = label1.Top + dy;

            // Boundary detection: reverse X direction if hitting left or right edges
            if (newX <= 0 || newX + label1.Width >= containerWidth)
            {
                dx = -dx;  // Reverse X direction
                newX = label1.Left + dx;  // Recalculate position
            }

            // Boundary detection: reverse Y direction if hitting top or bottom edges
            if (newY <= 0 || newY + label1.Height >= containerHeight)
            {
                dy = -dy;  // Reverse Y direction
                newY = label1.Top + dy;  // Recalculate position
            }

            // Update the label's position
            label1.Location = new Point(newX, newY);
        }
    }
}


