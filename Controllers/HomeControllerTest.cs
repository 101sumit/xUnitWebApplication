using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using xUnitWebApplication.Controllers;
using xUnitWebApplication.Interface;
using xUnitWebApplication.Services;

namespace xUnitWebApplications.Tests.Controllers
{
    public class HomeControllerTest
    {
        //[Fact]
        //public void HomeController_Index_ValidLargeNumber()
        //{
        //    //Arrange
           
        //    Mock<IEmailServices> emailMockServices= new Mock<IEmailServices>();
        //    emailMockServices.Setup(x=>x.IsEmailAvailable()).Returns(true);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices= new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x=>x.IsPrinterAvailable()).Returns(true);
        //    printerMockServices.Setup(x => x.Print(It.IsAny<string>())).Verifiable();

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
        //    string expectedResult = "Wrong! Try a bigger number.";
        //    int num = 98;

        //    //Act
        //    string result=controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Once);
        //    printerMockServices.Verify(x => x.Print("Print Somethinggg"), Times.Once);

        //}
        //[Fact]
        //public void HomeController_Index_ValidSmallerNumber_Without_SendEamil()
        //{
        //    //Arrange

        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Returns(false);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x => x.IsPrinterAvailable()).Returns(true);
        //    printerMockServices.Setup(x => x.Print(It.IsAny<string>())).Verifiable();

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
        //    string expectedResult = "Wrong! Try a smaller number.";
        //    int num = 102;

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Never);
        //    printerMockServices.Verify(x => x.Print("Print Somethinggg"), Times.Once);

        //}
        //[Fact]
        //public void HomeController_Index_ValidNumber_Without_Email_And_Print()
        //{
        //    //Arrange

        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Returns(false);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x => x.IsPrinterAvailable()).Returns(false);
        //    printerMockServices.Setup(x => x.Print(It.IsAny<string>())).Verifiable();

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
        //    string expectedResult = "You guessed correct number.";
        //    int num = 100;

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Never);
        //    printerMockServices.Verify(x => x.Print("Print Somethinggg"), Times.Never);

        //}
        //[Fact]
        //public void HomeController_Index_ValidLargeNumber_Without_Print()
        //{
        //    //Arrange

        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Returns(true);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x => x.IsPrinterAvailable()).Returns(false);
        //    printerMockServices.Setup(x => x.Print(It.IsAny<string>())).Verifiable();

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
        //    string expectedResult = "Wrong! Try a bigger number.";
        //    int num = 98;

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Once);
        //    printerMockServices.Verify(x => x.Print("Print Somethinggg"), Times.Never);

        //}
        //[Fact]
        //public void HomeController_Index_ValidSmallNumber()
        //{
        //    //Arrange
        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
        //    string expectedResult = "Wrong! Try a smaller number.";
        //    int num = 102;

        //    //Act
        //    string result = controller.Index(num);

        //    //assert
        //    Assert.Equal(expectedResult, result);
        //}

        //[Fact]
        //public void HomeControlleer_Index_ValidCorrect()
        //{
        //    //Arrange
        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
        //    string expectedResult = "You guessed correct number.";
        //    int num = 100;

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //}
    }
}
