using SerialNumbersHD.Texts;
using SerialNumbersHD.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Footer
{
    public class ApplicationFooter
    {
        public static void Show( IFooterInfo info)
        {

            TextManage.AnchorLeft(info);
        }
    }
}
