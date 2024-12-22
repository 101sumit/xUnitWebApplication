namespace xUnitWebApplication.Interface
{
    public interface IEmailServices
    {
        bool IsEmailAvailable();
        string SendEmail();
    }
}
