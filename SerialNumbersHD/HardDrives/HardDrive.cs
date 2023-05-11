using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.HardDrives
{
    public class HardDrive
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string SerialNo { get; set; }
        public override string ToString()
        {
            return $"Model \t: {Model} \t Type \t: {Type} \t SerialNo \t:{SerialNo}";
        }

    }
}
