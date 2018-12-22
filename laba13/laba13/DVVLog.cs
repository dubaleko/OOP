using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba13
{
    class DVVLog
    {
        public static void AddNote(string utility, string path)
        {
            StreamWriter logFile = new StreamWriter("dvvlogfile.txt", true);
            logFile.WriteLine($"{utility} : {path} : {DateTime.Now}");
            logFile.Close();
        }
        public static void Count(string path)
        {
            int res = 0;
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                res = sr.ReadLine().Count();
            }
           Console.WriteLine("Count info:"+res);
        }
        public static void PrintInfo(string path)
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Battle"))
                    Console.WriteLine(line);

                }
            }
        }

        public static void  Upgrade(string path, int  date)
        {
            string mypath = "file.txt";
            using (var ss = new StreamWriter(mypath))
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                char[] str;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.ToCharArray();
                    int j = 0, k = 0;
                    while (k != 3)
                        while (str[j] != ':')
                        {
                            j++;
                            if (str[j] == ':')
                            {
                                k++;
                                if (k != 3)
                                    j++;
                            }
                        }
                    j = j + 13;
                    int m = 0;
                    char[] newstr = new char[2];
                    while (str[j] != ':')
                    {
                        newstr[m] = str[j];
                        j++; m++;
                    }

                    if (newstr[1] == '\0')
                    {
                        if (newstr[0] == date)
                        {

                            ss.WriteLine(str);
                        }
                    }
                    else
                    {
                        string x = newstr[0].ToString();
                        string y = newstr[1].ToString();
                        string z = String.Concat(x, y);
                        string data = Convert.ToString(date);
                        if (z == data)
                        {
                            ss.WriteLine(str);
                        }
                    }
                }
            }
            FileInfo fileInf = new FileInfo(mypath);
            fileInf.CopyTo(path, true);
            fileInf.Delete();
        }
    }
}
