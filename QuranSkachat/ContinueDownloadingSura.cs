using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuranSkachat
{
    public  class ContinueDownloadingSura
    {
      protected async Task Again()
        {
            Console.WriteLine("Yuklab olmoqchi bulgan Sura nomerini kiriting");
            int n = int.Parse(Console.ReadLine());
            SuraSearch search = new SuraSearch();
            search.Check(n);
            QuranDownloads quranDownloads = new QuranDownloads();
            await quranDownloads.Downloads(n);
        }
       
    }
}
