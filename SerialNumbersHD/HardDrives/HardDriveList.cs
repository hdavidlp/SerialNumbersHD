using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumbersHD.HardDrives
{
    public class HardDriveList
    {
        public static ArrayList Get()
        {
            ArrayList hardDriveDetails = new ArrayList();
            ManagementObjectSearcher moSearcher = new
            ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in moSearcher.Get())
            {
                HardDrive hd = new HardDrive();
                hd.Model = wmi_HD["Model"].ToString();
                hd.Type = wmi_HD["InterfaceType"].ToString();
                hd.SerialNo = wmi_HD["SerialNumber"].ToString();
                hardDriveDetails.Add(hd);
            }

            return hardDriveDetails;
        }
    }
}
