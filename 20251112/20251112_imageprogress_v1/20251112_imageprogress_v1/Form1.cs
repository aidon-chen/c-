using System.Windows.Forms;

namespace _20251112_imageprogress_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image img;

        //全局变量

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            //打开图片

            OpenFileDialog ofd = new OpenFileDialog();

            //打开文件资源管理器，ofd这个位置什么名字都可以

            ofd.ShowDialog();
            //显示对话框

            img = Image.FromFile(ofd.FileName);

            //使用文件名实体化类

            label1.Text = ofd.FileName;

            picOrg.BackgroundImage = img;
            picOrg.BackgroundImageLayout = ImageLayout.Stretch;


            // ofd.FileName;
            //选择图片路径

            //picOrg.Image = img;

            //显示图片，这里也可以用backgroundimage

            //picOrg.ImageLayout=ImageLayout .Stretch;
            //图片拉伸这一条好像只可以在backgroundimage上用




        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            //灰度化
            Bitmap bmpOrg = new Bitmap(img);

            Bitmap bmpProc = new Bitmap(img.Width, img.Height);

            for (int i = 0; i < img.Width; i++) 
            {
                for (int j = 0; j < img.Height; j++) 
                {
                    Color c = bmpOrg.GetPixel(i, j);

                    int x = (c.R + c.G + c.B)/3;
                    Color cGray = Color.FromArgb(x, x, x);
                    bmpProc.SetPixel(i, j, cGray);

                }

                picProc.BackgroundImage = bmpProc;
                picProc.BackgroundImageLayout = ImageLayout.Stretch;

                //展示处理后的图片
            }

        }
    }
}
