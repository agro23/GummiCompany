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

            var myProduct1 = new Product();
            var myProduct2 = new Product();

            //Act
            myProduct1.Name = "Impala";
            myProduct2.Name = "Impala";

            //Assert

            Assert.AreEqual(myProduct1, myProduct2);
        }

        //[TestMethod]
        //public void ProductAverageRating_ReturnsCorrectResult_Int()
        //{
        //    //Arrange

        //    // Make a Product
        //    var myProduct = new Product(1, "King Size Gummi Bear", 55, "The biggest gummi bear you've ever seen!");

        //    // Give it three Reviews
        //    var review1 = new Review(1, "Bazooka Joe", "I like candy.", 5);
        //    var review2 = new Review(1, "Fred Derf", "This could have been better. It was okay.", 3);
        //    var review3 = new Review(1, "Dawn Don", "It was scary. Who eats that much candy?", 1);

        //    //Act

        //    // Give each Review an average from the set 1,2,3,4,5
        //     var testAverage = 3;
        //     var reviewAverage = myProduct.getAverageRating();

        //    //Assert

        //     Assert.AreEqual(testAverage, reviewAverage);
        //}
    }
}