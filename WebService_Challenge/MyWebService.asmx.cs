using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

namespace WebService_Challenge
{
    [WebService(Namespace = "LemonWay")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    //[System.Web.Script.Services.ScriptService]
    public class MyWebService : WebService
    {

        [WebMethod]
        public double Fibonacci(int n)
        {
            Logger.Initialize();
            Logger.Log("Call Web Service " + System.Reflection.MethodBase.GetCurrentMethod().Name + ".", LogType.Info);
            double res = 0;
            double k = 1;

            try
            {
                Thread.Sleep(2000);

                if (n < 1 || n > 100)
                    return -1;

                for (int i = 1; i <= n; i++)
                {
                    double temp = res;
                    res = k;
                    k = temp + k;
                }
            }
            catch (Exception exc)
            {
                Logger.Log("Error calling Web Service " + System.Reflection.MethodBase.GetCurrentMethod().Name + ". Exception : " + exc.Message, LogType.Error);
                throw exc;
            }

            return res;
        }

        [WebMethod]
        public string XmlToJson(string xml, bool indented)
        {
            Logger.Initialize();
            Logger.Log("Call Web Service " + System.Reflection.MethodBase.GetCurrentMethod().Name + ".", LogType.Info);
            string res = string.Empty;

            try
            {
                Thread.Sleep(2000);

                var xDoc = XDocument.Parse(xml);
                foreach (var desc in xDoc.Descendants())
                    desc.RemoveAttributes();

                XmlDocument xmlDoc = new XmlDocument();
                using (var xmlReader = xDoc.CreateReader())
                {
                    xmlDoc.Load(xmlReader);
                }

                Newtonsoft.Json.Formatting indentValue = indented ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None; ;
                res = JsonConvert.SerializeXmlNode(xmlDoc, indentValue);
            }
            catch (XmlException xmlExc)
            {
                Logger.Log("Error calling Web Service " + System.Reflection.MethodBase.GetCurrentMethod().Name + ". Input XML is not well formed : " + xmlExc.Message, LogType.Error);
                res = "Bad Xml format";
            }
            catch (Exception exc)
            {
                Logger.Log("Error calling Web Service " + System.Reflection.MethodBase.GetCurrentMethod().Name + ". Exception : " + exc.Message, LogType.Error);
                throw exc;
            }

            return res;
        }

    }
}
