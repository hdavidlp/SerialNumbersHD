using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Tools
{
    public  static class HorizontalLine
    {
        private static string buildLine(string character)
        {
            string aux="";
            for(int i=1; i<=140; i++) aux+=character;
            return aux;
        }


        public static void Draw(IHeaderInfo info)
        {
            string line = buildLine("*");
            Console.WriteLine(line.Substring(1, info.maxWidth));
        }

        public static string  GetLine(IHeaderInfo info)
        {
            string line = buildLine("*");
            return line.Substring(1, info.maxWidth);
        }
    }
}
