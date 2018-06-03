using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Xml;

namespace Kinopins
{
   public class HTMLDowloanHelper

    {
       public static string DowloanHTML(string Uri)
       {
         return DowloanHTML( Uri , Encoding.UTF8);
       }
       public static string DowloanHTML(string Uri, Encoding encoding)
       {
           HttpWebRequest request = WebRequest.Create(Uri) as HttpWebRequest; //запрос
           request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.181 Safari/537.36";
           request.Accept = "text/html,application/xhtml+xml,application/xml; q=0.9,*/*;q=0.8";
           request.Headers.Set("accept-language", "ru-ru,ru; q=0.8,en-us; q=0.6, en; q=0.4");
           request.Headers.Set("accept-charset", "windows-1251 , utf-8; q=0.7,*,q=0.7");
           request.KeepAlive = true;
           HttpWebResponse response = request.GetResponse() as HttpWebResponse; // ответ

           StreamReader sr = new StreamReader(response.GetResponseStream() ,encoding);
           sr.ReadLine();
           string html = sr.ReadToEnd();

           return html;
       }
    }
}
