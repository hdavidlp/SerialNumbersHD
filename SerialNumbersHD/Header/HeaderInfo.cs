using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialNumbersHD.Tools;

namespace SerialNumbersHD.Header
{
    public class HeaderInfo : IHeaderInfo
    {
        public string text { get; set; }

        public int spaces { get; set; }

        public int maxWidth { get; set; }
    }
}
