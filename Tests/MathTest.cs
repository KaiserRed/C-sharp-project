using NUnit.Framework;
using Moq;
using WebApi.Controllers;
using ClassLibrary;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace MathTest
{
    public class MathControllerTests
    {
        private Mock<IMathService> _mathServiceMock;
        private MathController _mathController;

        [SetUp]
        public void Setup()
        {
            _mathServiceMock = new Mock<IMathService>();
            _mathController = new MathController(_mathServiceMock.Object);
        }
        
        [Test]
        public async Task SumTest1()
        {
            var a = 6;
            var b = 1;
            var expectedOutput = 7;
            _mathServiceMock.Setup(service => service.Sum(a, b)).Returns(a + b);
            var result = _mathController.Sum(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task SumTest2()
        {
            var a = 999999999;
            var b = 1;
            var expectedOutput = 1000000000;
            _mathServiceMock.Setup(service => service.Sum(a, b)).Returns(a + b);
            var result = _mathController.Sum(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }
        
        [Test]
        public async Task SumTest3()
        {
            var a = 10506.5;
            var b = -0.25;
            var expectedOutput = 10506.25;
            _mathServiceMock.Setup(service => service.Sum(a, b)).Returns(a + b);
            var result = _mathController.Sum(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task SumTest4()
        {
            var a = 0;
            var b = 13;
            var expectedOutput = 13;
            _mathServiceMock.Setup(service => service.Sum(a, b)).Returns(a + b);
            var result = _mathController.Sum(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }   

        [Test]
        public async Task SubTest1()
        {
            var a = 0;
            var b = 13;
            var expectedOutput = -13;
            _mathServiceMock.Setup(service => service.Substracion(a, b)).Returns(a - b);
            var result = _mathController.Substracion(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task SubTest2()
        {
            var a = 901.5;
            var b = 900.25;
            var expectedOutput = 1.25;
            _mathServiceMock.Setup(service => service.Substracion(a, b)).Returns(a - b);
            var result = _mathController.Substracion(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task MultTest1()
        {
            var a = 5;
            var b = 5;
            var expectedOutput = 25;
            _mathServiceMock.Setup(service => service.Multiplication(a, b)).Returns(a * b);
            var result = _mathController.Multiplication(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task MultTest2()
        {
            var a = 900;
            var b = 0;
            var expectedOutput = 0;
            _mathServiceMock.Setup(service => service.Multiplication(a, b)).Returns(a * b);
            var result = _mathController.Multiplication(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }    

        [Test]
        public async Task MultTest3()
        {
            var a = 300;
            var b = -0.5;
            var expectedOutput = -150;
            _mathServiceMock.Setup(service => service.Multiplication(a, b)).Returns(a * b);
            var result = _mathController.Multiplication(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }
        [Test]
        public async Task DivTest1()
        {
            var a = 24;
            var b = 6;
            var expectedOutput = 4;
            _mathServiceMock.Setup(service => service.Division(a, b)).Returns(a / b);
            var result = _mathController.Division(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task DivTest2()
        {
            var a = 100;
            var b = -25;
            var expectedOutput = -4;
            _mathServiceMock.Setup(service => service.Division(a, b)).Returns(a / b);
            var result = _mathController.Division(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }         

        [Test]
        public async Task DivTest3()
        {
            var a = -6.25;
            var b = 2.5;
            var expectedOutput = -2.5;
            _mathServiceMock.Setup(service => service.Division(a, b)).Returns(a / b);
            var result = _mathController.Division(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task DivTest4()
        {
            var a = 77;
            var b = 0;
            _mathServiceMock.Setup(service => service.Division(a, b)).Throws(new DivideByZeroException("Division by zero is prohibited"));

            var result = await Task.Run(() => _mathController.Division(a, b) as BadRequestObjectResult);

            Assert.That(result.Value, Is.EqualTo("Division by zero is prohibited"));
        }

        [Test]
        public async Task PowTest1()
        {
            var a = 2;
            var b = 10;
            var expectedOutput = 1024;
            _mathServiceMock.Setup(service => service.Pow(a, b)).Returns(Math.Pow(a, b));
            var result = _mathController.Pow(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task PowTest2()
        {
            var a = 4;
            var b = 0.5;
            var expectedOutput = 2;
            _mathServiceMock.Setup(service => service.Pow(a, b)).Returns(Math.Pow(a, b));
            var result = _mathController.Pow(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }
        
        [Test]
        public async Task PowTest3()
        {
            var a = 5;
            var b = -1;
            var expectedOutput = 0.2;
            _mathServiceMock.Setup(service => service.Pow(a, b)).Returns(Math.Pow(a, b));
            var result = _mathController.Pow(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task PowTest4()
        {
            var a = 8;
            var b = 0;
            var expectedOutput = 1;
            _mathServiceMock.Setup(service => service.Pow(a, b)).Returns(Math.Pow(a, b));
            var result = _mathController.Pow(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task PowTest5()
        {
            var a = 1999;
            var b = 1;
            var expectedOutput = 1999;
            _mathServiceMock.Setup(service => service.Pow(a, b)).Returns(Math.Pow(a, b));
            var result = _mathController.Pow(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public async Task PowTest6()
        {
            var a = 0;
            var b = 5;
            var expectedOutput = 0;
            _mathServiceMock.Setup(service => service.Pow(a, b)).Returns(Math.Pow(a, b));
            var result = _mathController.Pow(a, b) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }
    }            
}
