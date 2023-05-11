using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialNumbersHD.Texts;
using SerialNumbersHD.Tools;

namespace SerialNumbersHD.Header
{
    public static class ApplicationHeader
    {
        public static void Show(IHeaderInfo info)
        {
            HorizontalLine.Draw(info);
            TextManage.Center(info);
            HorizontalLine.Draw(info);
        }
    }
}
