// See https://aka.ms/new-console-template for more information


using SerialNumbersHD.HardDrives;
using SerialNumbersHD.Header;
using SerialNumbersHD.Tools;



var headerInfo = ApplicationHeaderConstructor.Get();
ApplicationHeader.Show(headerInfo);
var hardDriveFound = HardDriveList.Get();
HardDriveCheck.ShowDetails(hardDriveFound);
HardDriveListPersist.Save(headerInfo, hardDriveFound);

Console.WriteLine("\n\n\n\nPress any key to continue ...");
Console.ReadLine();

