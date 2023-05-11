using SerialNumbersHD.Texts;
using SerialNumbersHD.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.HardDrives
{
    public static class HardDriveCheck
    {
        public static void ShowDetails(ArrayList hardDrives)
        {

            Console.Write("{0,-50} {1,-10} {2}\n", "Model", "Type", "SN");

            foreach (HardDrive item in hardDrives)
            {
                Console.WriteLine("{0,-50} {1,-10} {2}", item.Model, item.Type, item.SerialNo);
            }
        }
    }
}
