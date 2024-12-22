using xUnitWebApplication.Interface;

namespace xUnitWebApplication.Services
{
    public class PrinterServices : IPrinterServices
    {
        public bool IsPrinterAvailable()
        {
            return true;
        }
        public string Print(string str)
        {
            return "Print Somthing";
        }
    }
}
