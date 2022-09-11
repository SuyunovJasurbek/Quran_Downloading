using System.Diagnostics;
using System.Net;
namespace QuranSkachat
{
    public class QuranDownloads :ContinueDownloadingSura
    {
        public async Task Downloads(int NumberSura)
        {
            
                if (NumberSura <= 114 && NumberSura >= 1)
                {
                    WebClient mywebClient = new WebClient();
                    mywebClient.DownloadFile($"https://server7.mp3quran.net/s_gmd/{NumberSura:D3}.mp3", $@"E:\Jasur\SkachatQuran\{NumberSura}.mp3");
                    Console.WriteLine(" Siz kiritgan Sura yuklab olindi");
                    Again();
                }
                else
                {
                    Console.WriteLine(" Siz kiritgan nomer bilan Sura topilmadi");
                    Again();
                }
           
        }
    }
}
