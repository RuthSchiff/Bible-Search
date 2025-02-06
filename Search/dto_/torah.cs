using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class torah:tanach 
    {
     
        public string sefer { get; set; }
        public string parasha { get; set; }

        public override string ToString()
        {

            return count+" "+ "\n"+ sefer + "\n" + perek + "\n" + pasuk + "\n" ;
        }


    }
}
