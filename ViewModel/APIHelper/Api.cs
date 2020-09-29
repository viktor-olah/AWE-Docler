using AWEVideoPlayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWEVideoPlayer.ModelView.APIHELPER
{
    public class Api
    {

        public const string BASE_URL = "https://pt.potawe.com";
        public const string AUTOCOMPLETE_ENDPOINT = "/api/video-promotion/v1/list?psid={0}&pstool=421_1&accessKey=47eb7dbeffb6a4e42ba6ca67fb920a3b&ms_notrack=1&campaign_id=&type=&sexualOrientation=straight&forcedPerformers=&limit=25&primaryColor={1}&labelColor={2}&clientIp={3}";

        public const string PSID = "Oviktor92";
        public const string PRIMARY_COLOR = "%23C41616";
        public const string LABEL_COLOR = "%23212121";
        public const string CLIENT_IP = "127.0.0.1";        // localhost

       
        public static AWE loadedData = JSONAPI();


        public static AWE JSONAPI()
        {
            string url = BASE_URL + string.Format(AUTOCOMPLETE_ENDPOINT, PSID, PRIMARY_COLOR, LABEL_COLOR, CLIENT_IP);

            WebClient jsoncode = new WebClient();
            jsoncode.Encoding = Encoding.UTF8;
            string jsonstring = jsoncode.DownloadString(url);


            AWE load = JsonConvert.DeserializeObject<AWE>(jsonstring);

            return load;
        }


    }
}
