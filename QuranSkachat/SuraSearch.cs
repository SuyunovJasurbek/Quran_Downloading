using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace QuranSkachat
{
    public class SuraSearch :ContinueDownloadingSura
    {
        WebClient mywebClient = new WebClient();

        string path = @"E:\Jasur\SkachatQuran";
        public   async Task Check(int NumberSura)
        {
            if (NumberSura <= 114 && NumberSura >= 1)
            {
                string[] filePaths = Directory.GetFiles(path);
                for (int i = 0; i < filePaths.Length; i++)
                {
                    if (filePaths[i] == $@"E:\Jasur\SkachatQuran\{NumberSura}.mp3")
                    {
                        Console.WriteLine($"{NumberSura}- Sura Avvaldan mavjud  ekan. ");
                        Again();
                    }
                }
                Console.WriteLine($"{NumberSura}- Sura yuklanmoqda...");
                Again();
            }
            else
            {
                Console.WriteLine(" siz kiritgan nomer bilan Sura topilmadi");
                Again();             
            }
           
        }
    }
}
