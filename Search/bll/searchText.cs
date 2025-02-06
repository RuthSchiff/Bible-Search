using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class searchText
    {
        
        public static int finalCount;
        public static List<torah> searchT(string word)
        {
            List<tanach> TextJson = bll.splitTanach.SplitTanach();
            List<torah> SearchResultWord = new List<torah>();
            finalCount = 0;
            foreach (var item in TextJson)
            {
                int beginIndex = 0, count = 0;
                string p = item.pasuk.Substring(item.pasuk.IndexOf("פסוק") + 8);
                while (p.IndexOf(word, beginIndex) != -1)
                    if (p.IndexOf(word, beginIndex) != -1)
                    {
                        count++;
                        beginIndex = p.IndexOf(word, beginIndex) + 1;
                    }
                if (count > 0)
                {
                    finalCount += count;
                    item.count = "(" + count + ")";
                    SearchResultWord.Add(item as torah);
                }

            }

            return SearchResultWord;
        }
        public static string countWord(string word)
        {

            string st = "";
            st = "מספר התוצאות בסהכ: " + finalCount;
            return st;
        }

        public static string countPsukim(string word)
        {

            string st = "";
            st = "מספר הפסוקים בהם מופיע נתון החיפוש: " + searchT(word).Count;
            return st;
        }

    }
}
