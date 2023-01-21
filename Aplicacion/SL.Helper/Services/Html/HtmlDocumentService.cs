using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Services.Html
{
    public static class HtmlDocumentService
    {
        public static string GetHtmlDocument(string htmlName, string RootPath)
        {
            string body = string.Empty;
            //string pathTemplates = Path.Combine(ServerInfoHelper.MapPath(RootPath), "Templates");
            using (StreamReader sr = new StreamReader(Path.Combine(Path.Combine((string)AppDomain.CurrentDomain.GetData("InfraestructuraRootPath"), htmlName))))
            {
                body = sr.ReadToEnd();
            }
            return body;
        }
        public static string GetHtmlDocument(string htmlName, string RootPath, List<string> replace)
        {
            string body;
            int count = 0;
            //string pathTemplates = Path.Combine(ServerInfoHelper.MapPath(RootPath), "Templates");
            using (StreamReader sr = new StreamReader(Path.Combine(((string)AppDomain.CurrentDomain.GetData("InfraestructuraRootPath"))+ "\\Templates\\", htmlName)))
            {
                body = sr.ReadToEnd();
            }
            replace.ForEach(x => { body = body.Replace("{" + count + "}", x); count++; });

            return body;
        }
    }
}
