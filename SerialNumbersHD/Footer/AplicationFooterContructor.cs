using SerialNumbersHD.Header;
using SerialNumbersHD.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Footer
{
    public static class AplicationFooterContructor
    {
        public static IFooterInfo Get()
        {
            return new FooterInfo()
            {
                DateTime = DateTime.Now,
                spaces = 0,
                text = DateTime.Now.ToString(),
            };
        }
    }
}
