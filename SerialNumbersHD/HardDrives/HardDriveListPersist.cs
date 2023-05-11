using SerialNumbersHD.Texts;
using SerialNumbersHD.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.HardDrives
{
    public static class HardDriveListPersist
    {
        public static void Save(IHeaderInfo headerInfo, ArrayList hardDrives)
        {
            try
            {

                StreamWriter sw = new StreamWriter("harddriveinfo.txt");

                sw.WriteLine(HorizontalLine.GetLine(headerInfo));
                sw.WriteLine(TextManage.GetCenter(headerInfo));
                sw.WriteLine(HorizontalLine.GetLine(headerInfo));

                sw.WriteLine("{0,-50} {1,-10} {2}", "Model", "Type", "SN");

                foreach (HardDrive item in hardDrives)
                {
                    sw.WriteLine("{0,-50} {1,-10} {2}", item.Model, item.Type, item.SerialNo);
                }
                sw.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
