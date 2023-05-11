using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Texts
{
    public class LeftMessage:IMessage
    {
        public string text { get; set; }
        public int spaces { get; set; }

    }
}
