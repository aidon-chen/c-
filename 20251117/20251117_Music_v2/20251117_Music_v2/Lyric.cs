using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251117_Music_v2
{
    class LyricLine
    {
        public double time;
        public string text;
    }

    //封装歌词与时间的类
    //存放类的时候注意层级

    internal class Lyric
    {
        // List<string> lines  = new List<string>();这个就舍弃

        public List<LyricLine> lines = new List<LyricLine>();

        

        public void Load(string fileName)
        {
            lines.Clear();

            FileStream fileStream = new FileStream(fileName, FileMode.Open);


            //进程使用中？
            StreamReader streamReader = new StreamReader(fileStream);

            //解码器
            Encoding encode = Encoding.GetEncoding("GB2312");

            //重新指定解码器
            streamReader = new StreamReader(fileStream, encode);



            string s;

            /*while ((s = streamReader.ReadLine()) != null)
            {
                lines.Add(s);
            }
            */

            while (true)
            {
                s = streamReader.ReadLine();


                if (s == "")
                {
                    continue;
                }
                //解决换行的空字符串出现问题

                if (s == null)
                {
                    break;

                }

                //string sTime = s.Substring(0, 10);

                string sMinute = s.Substring(1, 2);
                string sSecond = s.Substring(4, 5);

                //分别提取分钟和秒钟

                double dTime = int.Parse(sMinute) * 60 + double.Parse(sSecond);

                //转换为总秒数，字符串转换为数字

                string sText = s.Substring(10);
                //分割字符串存储到子字符串，0开始，读取10个字符

                LyricLine lyricLine = new LyricLine();
                lyricLine.time = dTime;
                lyricLine.text = sText;

               

                lines.Add(lyricLine);

                




            }


            streamReader.Close();
            fileStream.Close();

            //关闭文件



        }

        

    }

   
}
