using xUnitWebApplication.Interface;

namespace xUnitWebApplication.Services
{
    public class EmailServices : IEmailServices
    {
        public bool IsEmailAvailable()
        {
            return true;
        }

        public string SendEmail()
        {
            return "Send Email";
        }
    }
}
