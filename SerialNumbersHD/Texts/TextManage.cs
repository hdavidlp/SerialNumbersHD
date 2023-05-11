using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Texts
{
    public static class TextManage
    {

        public static string GetCenter(IMessage info)
        {
            int spaces = info.maxWidth / 2 - info.text.Length / 2;
            for (int i = 0; i < spaces; i++)
                Console.Write(" ");
            return info.text;
        }

        public static void Center(IMessage info)
        {
            //int spaces = info.maxWidth / 2 - info.text.Length / 2;
            //for (int i = 0; i < spaces; i++)
            //    Console.Write(" ");
            Console.WriteLine(GetCenter(info));
        }

        public static void AnchorLeft(IMessage info)
        {
            for (int i = 0; i < info.spaces; i++)
                Console.Write(" ");
            Console.Write(info.text);
        }

        public static void NewLine()
        {
            Console.WriteLine();
        }


    }
}
