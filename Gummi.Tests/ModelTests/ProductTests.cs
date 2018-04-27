using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gummi.Models;

namespace Gummi.Tests.ModelTests
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void GetName_ReturnsProductName_String()
        {
            //Arrange
            var myProduct = new Product();
            myProduct.Name = "Impala";

            //Act
            var result = myProduct.Name;

            //Assert
            Assert.AreEqual("Impala", result);
        }

        [TestMethod]
        public void ObjectsEqual_ReturnsResult_Bool()
        {
            //Arrange

            // Make two Products

            //Act

            // Give each Product some property definitions

            //Assert

            // Assert.AreEqual(obj1, obj2);
        }

        [TestMethod]
        public void ProductAverageRating_ReturnsCorrectResult_Int()
        {
            //Arrange

            var myProduct = new Product();
            // Give it five Reviews
            // This is going to require using a Mock database

            //Act

            // Give each Review an average from the set 1,2,3,4,5
             var testAverage = 3;
             var reviewAverage = myProduct.getAverageRating();

            //Assert

             Assert.AreEqual(testAverage, reviewAverage);
        }
    }
}