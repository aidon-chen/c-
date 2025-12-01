namespace _20251117_Music_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //读取歌词

            FileStream fileStream = new FileStream("陈一发儿-童话镇.lrc", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            List<string> lines = new List<string>();

            string  s;

            /*while ((s = streamReader.ReadLine()) != null)
            {
                lines.Add(s);
            }
            */

            while (true) 
            {
                s = streamReader.ReadLine();

                richTextBox1.Text += s + "\n";

                if (s == null)
                {
                    break;

                }
                lines.Add(s);
            }



        }
    }
}
