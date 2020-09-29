using AWEVideoPlayer.Model;
using AWEVideoPlayer.ModelView.APIHELPER;
using AWEVideoPlayer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWEVideoPlayer.ModelView
{
    public class AWEVM
    {
        static int currentNumber = 0;

        public string Title { get => Titels(); }
        public string ProfilImage { get => onepic(); }
        public string Prewpic { get => oneprewpic(); }
        public int MovieDuration { get => Duration(); }
        public string tUrl { get => targeturl(); }
      


   

        public static string onepic()
        {

            List<string> pics = new List<string>();
            foreach (var item in Api.loadedData.data.videos)
            {
                pics.Add(@"http:" + item.profileImage);
            }

            string a = pics.ElementAt(currentNumber);


            return a;
        }
        public string oneprewpic()
        {

            List<string> pics = new List<string>(0);
            foreach (var item in Api.loadedData.data.videos)
            {

                foreach (string item2 in item.previewImages)
                {
                    pics.Add(@"http:" + item2);
                    break;
                }
            }

            string a = pics.ElementAt(currentNumber);
            return a;
        }
        public string Titels()
        {
            List<string> titels = new List<string>();
            foreach (var item in Api.loadedData.data.videos)
            {
                titels.Add(item.title);
            }
            string a = titels.ElementAt(currentNumber);
            return a;
        }
        public int Duration()
        {
            List<int> duration = new List<int>();
            foreach (var item in Api.loadedData.data.videos)
            {
                duration.Add(item.duration);
            }
            int a = duration.ElementAt(currentNumber);

            return a;
        }
        public string ids()
        {
            List<string> ids = new List<string>();
            foreach (var item in Api.loadedData.data.videos)
            {
                ids.Add(item.id);
            }
            string a = ids.ElementAt(currentNumber);
            return a;
        }
        public string targeturl()
        {
            List<string> urls = new List<string>();
            foreach (var item in Api.loadedData.data.videos)
            {
                urls.Add($"http:" + item.targetUrl);
            }
            string a = urls.ElementAt(currentNumber);
            currentNumber++;
            return a;
        }

    }
}
