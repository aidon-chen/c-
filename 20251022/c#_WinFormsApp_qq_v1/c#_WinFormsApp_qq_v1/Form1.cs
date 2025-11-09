using System.Windows.Forms;

namespace c__WinFormsApp_qq_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 加入主界面

            FromMain frm = new FromMain();
            frm.Show();
        }

        private void pichead_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            step = 8;
            // 移动图片

        }
        int step = 0;



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            picAdd.Location = new Point(picAdd.Location.X + step, picAdd.Location.Y);

            if (picAdd.Location.X >= 350)
            {
                step = 0;
            }

            if (picAdd.Location.X <= 200)
            {
                step = 0;
            }


        }


        private void pichead_MouseLeave(object sender, EventArgs e)
        {

            step = -8;
            //鼠标移出

        }

        private void pictSetUp_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.BackColor = Color.Gray;
        }

        private void pictSetUp_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            pb.BackColor = Color.Transparent;
        }



        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Red;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }

        private void labFindPasswards_MouseEnter(object sender, EventArgs e)
        {
            Label lb = sender as Label;

            lb.ForeColor = Color.Black;

        }

        private void labFindPasswards_MouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;

            lb.ForeColor = Color.Gray;
        }

        private void labSignUp_MouseEnter(object sender, EventArgs e)
        {

            labSignUp.ForeColor = Color.Black;

        }

        private void labSignUp_MouseLeave(object sender, EventArgs e)
        {
            labSignUp.ForeColor = Color.Gray;

        }


     
        private void txtAccount_MouseEnter(object sender, EventArgs e)
        {
            Panel pb = sender as Panel;
            pb.BackColor = Color.DeepSkyBlue ; 


        }

        private void txtAccount_MouseLeave(object sender, EventArgs e)
        {
            Panel pb = sender as Panel;
            pb.BackColor = Color.White;
        }
    }
}
