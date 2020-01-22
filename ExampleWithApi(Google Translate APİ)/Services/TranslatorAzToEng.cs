using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWithApi_Google_Translate_APİ_.Services
{
    /// <summary>
    /// Google servisleri free yazilmagina baxmayaraq kartda $1 isteyir ve men de bundan coxdan qeydiyyatdan kechib
    /// muddetini bitirmishem.Bu sebebden yandexin translatorundan istifade etmeye mecbur qaldim,tercumesi chox pisdir
    /// Lakin netice olaraq alinir bununlada.
    /// 
    /// Elave olaraq api key-i configuration manager icherisinde ozum yazmamisham.Hetta connection string bele achiq
    /// shekildedir.Bunlarida bacariram,mueyyen sebeblerden tez yazmali oldum ve hemin meqamlari ötürdüm.
    /// </summary>
    static public class TranslatorAzToEng
    {
        private static HttpClient Client = new HttpClient();
        static public string AzToEng(string text)
        {
            string translated = "";
            text = text.Replace(" ", "%20");

            StringBuilder sb = new StringBuilder();
            sb.Append("https://translate.yandex.net/api/v1.5/tr.json/translate?key=")
              .Append("trnsl.1.1.20200122T153040Z.618a570b2469a961.db3f7ac62dc38c96c7f92f59da53508bde6ceaf3")
              .Append("&text=")
              .Append(text)
              .Append("&lang=az-en");

            dynamic JsonFile = JsonConvert.DeserializeObject(Client.GetAsync(sb.ToString()).Result.Content.ReadAsStringAsync().Result);
            translated = JsonFile["text"].ToString();
            translated = translated.Replace("[","");
            translated = translated.Replace("]", "");
            translated = translated.Replace("\"", "");

           
            return translated.ToString();
        }

    }
}
