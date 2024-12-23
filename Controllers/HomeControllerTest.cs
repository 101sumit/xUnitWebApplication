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
        //[Theory]
        //[InlineData(5,4, "5 is greater then 4 and addintion of 5 + 4 = 9")]
        //[InlineData(4,5, "4 is lesser then 5 and addintion of 4 + 5 = 9")]
        //[InlineData(5,5, "5 is equal to 5 and addintion of 5 + 5 = 10")]
        //public void HomeController_Addition_a_greater_then_b(int a, int b, string expectedResult)
        //{
        //    //Arrange
        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
            
        //    //Act
        //    string result = controller.Addition(a, b);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //}

        //[Theory]
        //[InlineData(80, "Wrong! Try a bigger number.")]
        //[InlineData(120, "Wrong! Try a smaller number.")]
        //[InlineData(100, "You guessed correct number.")]
        //public void HomeController_Index_ValidateNumber(int num, string expectedResult)
        //{
        //    //Arrange
        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Returns(true);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x => x.IsPrinterAvailable()).Returns(true);

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Once);

        //}

        //[Theory]
        //[InlineData(80, "Wrong! Try a bigger number.")]
        //[InlineData(120, "Wrong! Try a smaller number.")]
        //[InlineData(100, "You guessed correct number.")]
        //public void HomeController_Index_ValidateNumber_True_False(int num, string expectedResult)
        //{
        //    //Arrange
        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Returns(true);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x => x.IsPrinterAvailable()).Returns(false);

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Once);

        //}

        //[Theory]
        //[InlineData(80, "Wrong! Try a bigger number.")]
        //[InlineData(120, "Wrong! Try a smaller number.")]
        //[InlineData(100, "You guessed correct number.")]
        //public void HomeController_Index_ValidateNumber_False_True(int num, string expectedResult)
        //{
        //    //Arrange
        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Returns(false);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x => x.IsPrinterAvailable()).Returns(true);

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Never);

        //}

        //[Theory]
        //[InlineData(80, "Wrong! Try a bigger number.")]
        //[InlineData(120, "Wrong! Try a smaller number.")]
        //[InlineData(100, "You guessed correct number.")]
        //public void HomeController_Index_ValidateNumber_False_False(int num, string expectedResult)
        //{
        //    //Arrange
        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Returns(false);
        //    emailMockServices.Setup(x => x.SendEmail()).Verifiable();

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    printerMockServices.Setup(x => x.IsPrinterAvailable()).Returns(false);

        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);

        //    //Act
        //    string result = controller.Index(num);

        //    //Assert
        //    Assert.Equal(expectedResult, result);
        //    emailMockServices.Verify(x => x.SendEmail(), Times.Never);

        //}


        //[Fact]
        //public void HomeController_Index_ValidLargeNumber()
        //{
        //    //Arrange

        //    Mock<IEmailServices> emailMockServices = new Mock<IEmailServices>();
        //    emailMockServices.Setup(x => x.IsEmailAvailable()).Throws(new ArgumentNullException()); //Check null exception.

        //    Mock<IPrinterServices> printerMockServices = new Mock<IPrinterServices>();
        //    HomeController controller = new HomeController(emailMockServices.Object, printerMockServices.Object);
        //    string expectedResult = "Wrong! Try a bigger number.";
        //    int num = 98;

        //    //Act
        //    //string result=controller.Index(num);

        //    //Assert
        //    Assert.Throws<ArgumentNullException>(() => controller.Index(num));

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
