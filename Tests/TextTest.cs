using NUnit.Framework;
using Moq;
using WebApi.Controllers;
using ClassLibrary;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace TextTest
{
    public class TextControllerTests
    {
        private Mock<ITextService> _textServiceMock;
        private TextController _textController;

        [SetUp]
        public void Setup()
        {
            _textServiceMock = new Mock<ITextService>();
            _textController = new TextController(_textServiceMock.Object);
        }

        [Test]
        public void ToUpperTest1()
        {
            var input = "hello";
            var expectedOutput = "HELLO";

            _textServiceMock.Setup(service => service.ToUpper(input)).Returns(input.ToUpper());
            var result = _textController.ToUpper(input) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ToUpperTest2()
        {
            var input = "good morninG";
            var expectedOutput = "GOOD MORNING";
            _textServiceMock.Setup(service => service.ToUpper(input)).Returns(input.ToUpper());

            var result = _textController.ToUpper(input) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }    

        [Test]
        public void ToUpperTest3()
        {
            var input = "good morning";
            var expectedOutput = "HELLO";
            _textServiceMock.Setup(service => service.ToUpper(input)).Returns(input.ToUpper());

            var result = _textController.ToUpper(input) as OkObjectResult;

            Assert.That(result.Value != expectedOutput);
        }     

        [Test]
        public void ToUpperTest4()
        {
            var input = "";
            var expectedOutput = "";
            _textServiceMock.Setup(service => service.ToUpper(input)).Returns(input.ToUpper());

            var result = _textController.ToUpper(input) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ToUpperTest5()
        {
            var input = "";
            var expectedOutput = "  ";
            _textServiceMock.Setup(service => service.ToUpper(input)).Returns(input.ToUpper());

            var result = _textController.ToUpper(input) as OkObjectResult;

            Assert.That(result.Value != expectedOutput);
        } 

        [Test]
        public void ToUpperTest6()
        {
            var input = "123hello";
            var expectedOutput = "123HELLO";
            _textServiceMock.Setup(service => service.ToUpper(input)).Returns(input.ToUpper());

            var result = _textController.ToUpper(input) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        } 

        [Test]
        public void ConcatStringsTest1()
        {
            var str1 = "hello";
            var str2 = "world";
            var expectedOutput = "helloworld";
            _textServiceMock.Setup(service => service.Concat(str1, str2)).Returns(str1 + str2);

            var result = _textController.Concat(str1, str2) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }

        [Test]
        public void ConcatStringsTest2()
        {
            var str1 = "Testing my ";
            var str2 = " skills ";
            var expectedOutput = "Testing my  skills ";
            _textServiceMock.Setup(service => service.Concat(str1, str2)).Returns(str1 + str2);

            var result = _textController.Concat(str1, str2) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }
                [Test]
        public void ConcatStringsTest3()
        {
            var str1 = "Hi";
            var str2 = "";
            var expectedOutput = "Hi";
            _textServiceMock.Setup(service => service.Concat(str1, str2)).Returns(str1 + str2);

            var result = _textController.Concat(str1, str2) as OkObjectResult;

            Assert.That(result.Value, Is.EqualTo(expectedOutput));
        }
    }
}
