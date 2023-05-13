using SerialNumbersHD.Texts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Footer
{
    public class FooterInfo : IFooterInfo
    {
        public DateTime DateTime { get; set; }

        public string text { get { return DateTime.ToString(); } set { } }

        public int spaces { get; set; }
        
    }
}
