using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.Texts
{
    public interface IMessage
    {
        string text { get; }
        int spaces { get; }
        virtual int maxWidth { get { return text.Length; } }
    }
}
