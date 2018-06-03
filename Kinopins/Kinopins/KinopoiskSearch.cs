using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
namespace Kinopins
{
    public class KinopoinsExseption : Exception
    {
        public KinopoinsExseption(string message)
            :base (message)
        {

        }
    }
    public class KinopoiskSearch
    {
        private string _html;
        private Image _cover;

        private readonly string BaseUrl;

        public KinopoiskSearch()
        {
           // BaseUrl = @"https://www.kinopoisk.ru/index.php?kp_query={0}";
            BaseUrl = @"https://www.kinopoisk.ru/index.php?first=yes&kp_query={0}";
        }

        public bool DownloanHtml(string movieName)
        {

            _cover = null;
            try
            {
                _html = HTMLDowloanHelper.DowloanHTML(string.Format(BaseUrl, movieName) , Encoding.GetEncoding(1251));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool FindCover()
        {
            if (string.IsNullOrEmpty(_html))
                throw new KinopoinsExseption("Код HTML не был загружен");

            TextSearch ts = new TextSearch(_html);

           /* XmlDocument doc = new XmlDocument();
            doc.LoadXml(_html);*/
            ts.skip("<!-- tns-counter.ru -->");
            ts.skip("src=\"https://st.kp.yandex.net/images/film_iphone/");
            string ImageFileName = "https://st.kp.yandex.net/images/film_iphone/" + ts.ReadTo("\"");
            return false;
        }
    }
}
