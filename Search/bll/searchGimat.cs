using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class searchGimat
    {
        public static int countPsukim;
        public static int finalSum;
        public static int sumAsci(String str)
        {
            int sum = 0, index = 0;
            while (index < str.Length)
            {
                //אותיות א-י
                if (((byte)str[index]) >= 208 && ((byte)str[index]) <= 217)
                    sum += ((byte)str[index]) - 207;
                //אותיות ק-ת
                else if (((byte)str[index]) >= 231 && ((byte)str[index]) <= 234)
                    sum += (((byte)str[index]) % 10) * 100;
                //אותיות כ,ל,ם
                else if (((byte)str[index]) >= 219 && ((byte)str[index]) <= 221)
                    sum += ((((byte)str[index]) - 207) % 10) * 10;
                //אותיות נ-ע,ף
                else if (((byte)str[index]) >= 224 && ((byte)str[index]) <= 227)
                    sum += (((byte)str[index]) % 10 + 1) * 10;
                //אותיות פ,צ
                else if (((byte)str[index]) == 228 || ((byte)str[index]) == 230)
                    sum += (((byte)str[index]) / 10 % 10 + ((byte)str[index]) / 100 + 4) * 10;
                //אותיות מ, ן
                else if (((byte)str[index]) >= 222 && ((byte)str[index]) <= 223)

                    sum += (((((byte)str[index]) % 10) + (((byte)str[index]) / 10 % 10)) * 10);
                //אות ך
                else if (((byte)str[index]) == 218)
                    sum += 20;
                //אות ץ
                else if (((byte)str[index]) == 229)
                    sum += 90;
                index++;
            }
            return sum;


        }
      
        public static List<torah> searchG(string text)

        {   finalSum = 0;
            List<torah> TextJson = bll.splitTanach.deserializeJson();
      
            List<torah> SearchResultGimat = new List<torah>();
         
            int textAsci = sumAsci(text);
            foreach (var item in TextJson)
            {
               
                string p = item.pasuk.Substring(item.pasuk.IndexOf("פסוק") + 8);
             
                if (sumAsci(p) == textAsci) { 
                    SearchResultGimat.Add(item); 
                }
            }
            finalSum += textAsci;
            return SearchResultGimat;
          
        }
    }
}
