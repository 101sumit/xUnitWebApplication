namespace xUnitWebApplication.Interface
{
    public interface IPrinterServices
    {
        bool IsPrinterAvailable();
        string Print(string str);
    }
}
