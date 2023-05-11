using SerialNumbersHD.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Header
{
    public static  class ApplicationHeaderConstructor
    {
        public static IHeaderInfo Get()
        {
            return new HeaderInfo() { 
                text = "Storage Device Information", 
                maxWidth = 100, 
                spaces = 0 
            };
        }

    }
}
