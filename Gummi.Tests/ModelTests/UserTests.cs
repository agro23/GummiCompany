using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gummi.Models;

namespace Gummi.Tests.ModelTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void GetName_ReturnsUserName_String()
        {
            //Arrange
            var myUser = new User();
            myUser.Name = "Sam";

            //Act
            var result = myUser.Name;

            //Assert
            Assert.AreEqual("Sam", result);
        }
    }
}