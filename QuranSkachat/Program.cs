using System;
using System.Diagnostics;
using System.Net;

namespace QuranSkachat
{
    class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("|-------------------- Bulimlarni Tanlang ----------------------|");
            Console.WriteLine("|                                                              |");
            Console.WriteLine("|                                                              |");
            Console.WriteLine("|               ___                        ___                 |");
            Console.WriteLine("|--------------| 1 |----------------------| 2 |----------------|");
            Console.WriteLine("|              ~~~~~                      ~~~~~                |");
            Console.WriteLine("|  |`````````````````````|     |````````````````````````````|  |");
            Console.WriteLine("|--|SAYTDAN SURA YUKLASH |-----| YUKLANGAN SURALARNI KURISH |--|");
            Console.WriteLine("|   ``````````````````````     ``````````````````````````````  |");
            Console.WriteLine("|                                                              |");
            Console.WriteLine("|                                                              |");
            Console.WriteLine("|                                                              |");
            Console.WriteLine("|-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=|");
            int q=int.Parse(Console.ReadLine());
            switch(q)
            {
                case 1:
                    {
                        Console.WriteLine("Yuklab olmoqchi bulgan Sura nomerini kiriting");
                        int n = int.Parse(Console.ReadLine());
                        SuraSearch search = new SuraSearch();
                        search.Check(n);
                        QuranDownloads quranDownloads = new QuranDownloads();
                        quranDownloads.Downloads(n);
                    }
                     break;
                case 2:
                    {
                        WebClient mywebClient = new WebClient();
                        string path = @"E:\Jasur\SkachatQuran";
                        string[] filePaths =Directory.GetFiles(path);
                        for (int i = 0; i < filePaths.Length; i++)
                        {
                            Console.WriteLine(filePaths[i]);
                        }
                    }
                    break;
            }
          
        }
    }
}