using SerialNumbersHD.Texts;

namespace SerialNumbersHD.Footer
{
    public interface IFooterInfo: IMessage
    {
        DateTime DateTime { get; set; }
    }
}