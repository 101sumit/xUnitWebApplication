using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xUnitWebApplication.Interface;

namespace xUnitWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IEmailServices _emailServices;
        private readonly IPrinterServices _printerServices;
        

        public HomeController(IEmailServices emailServices, IPrinterServices printerServices)
        {
            _emailServices = emailServices;
            _printerServices = printerServices;
        }

        [HttpGet("Index")]
        public string Index(int num)
        {
            if (_emailServices.IsEmailAvailable())
            {
                _emailServices.SendEmail();
            }
            if (_printerServices.IsPrinterAvailable())
            {
                _printerServices.Print("Print Somethinggg");
            }
            if (num<100)
            {
                return "Wrong! Try a bigger number.";
            }
            else if(num>100)
            {
                return "Wrong! Try a smaller number.";
            }
            else
            {
                return "You guessed correct number.";
            }
            
        }
        [HttpGet("Addition")]
        public string Addition(int a, int b)
        {
            if (a > b)
                return $"{a} is greater then {b} and addintion of {a} + {b} = {a+b}";
            else if (a < b)
                return $"{a} is lesser then {b} and addintion of {a} + {b} = {a+b}";
            else
                return $"{a} is equal to {b} and addintion of {a} + {b} = {a+b}";
        }
    }
}
