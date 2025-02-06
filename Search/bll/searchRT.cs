using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class searchRT
    {
        public static List<torah> searchPasukByRT(string word)

        {
            List<torah> TextJson = bll.splitTanach.deserializeJson();

            List<torah> ResultsRT = new List<torah>();

            char charBegin = word[0];
            char charEnd = word[word.Length - 1];
            foreach (var item in TextJson)
            {
                char begin, end;
                if (item.pasuk[item.pasuk.IndexOf("פסוק") + 11] == ' ')
                    begin = item.pasuk[item.pasuk.IndexOf("פסוק") + 12];
                else
                    begin = item.pasuk[item.pasuk.IndexOf("פסוק") + 11];
                end = item.pasuk[item.pasuk.Length - 4];
                if (begin==charBegin&& end == charEnd)
                    ResultsRT.Add(item);

            }
            return ResultsRT;
        }
    }
}

