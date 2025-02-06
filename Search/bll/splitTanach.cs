using dal;
using dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class splitTanach
    {
        private static List<dto.tanach> l = new List<dto.tanach>();
        public static List<dto.tanach> SplitTanach()
        {
            l = new List<dto.tanach>();
            string[] chumashim = dal.dalClass1.tanach.Split('$');
            for (int i = 1; i < chumashim.Length; i++)
            {
                int si1 = chumashim[i].IndexOf("~") + 1;
                string ss1 = chumashim[i].Substring(si1);
                int si2 = ss1.IndexOf("פרק");
                string ss2 = ss1.Substring(0, si2);

                string[] parashot = chumashim[i].Split('^');
                for (int j = 1; j < parashot.Length; j++)
                {
                    int a1 = parashot[j].IndexOf("~");
                    int a2 = parashot[j].IndexOf("!");
                    string c2 = "";
                    if (a1 < a2)
                    {
                        c2 = parashot[j].Substring(0, a1);
                    }
                    else
                    {
                        c2 = parashot[j].Substring(0, a2);
                    }

                    string[] prakim = parashot[j].Split('~');
                    for (int n = 1; n < prakim.Length; n++)
                    {
                        string[] psukim = prakim[n].Split('!');
                        for (int k = 0; k < psukim.Length; k++)
                        {
                            string pas = psukim[k].Replace("{", "פסוק-");
                            pas = pas.Replace("}", ":  ");
                            l.Add(new dto.torah()
                            {
                                sefer = ss2,
                                parasha = c2,
                                perek = prakim[n].Substring(prakim[n].IndexOf("פרק"), prakim[n].IndexOf("!") - 8),
                                pasuk = pas,
                                count = ""
                            });
                        }
                    }
                }
            }
            string updatedJson = JsonConvert.SerializeObject(l);
            StreamWriter sw = new StreamWriter(@"C:\Users\רותי שיף\Documents\הנדסאים\C#\SEARCH\Search\dal\bin\Debug\tanachJson.json");
            sw.WriteLine(updatedJson);
            sw.Close();
            return l;
        }

        public static List<torah> deserializeJson()
        {
            string tJson = File.ReadAllText(@"C:\Users\רותי שיף\Documents\הנדסאים\C#\SEARCH\Search\dal\bin\Debug\tanachJson.json");
            List<torah> lJson = JsonConvert.DeserializeObject<List<torah>>(tJson);
            return lJson;
        }

       
    }

}
