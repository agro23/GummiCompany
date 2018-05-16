using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gummi.Models;

namespace Gummi.Tests.ModelTests
{
    [TestClass]
    public class ReviewTests
    {
        [TestMethod]
        public void GetAuthor_ReturnsReviewAuthor_String()
        {
            //Arrange
            var myReview = new Review();
            myReview.Author = "Dean";

            //Act
            var result = myReview.Author;

            //Assert
            Assert.AreEqual("Dean", result);
        }
    
        [TestMethod]
        public void ObjectsEqual_ReturnsResult_Bool()
        {
            //Arrange

            // Make two Reviews
            Review review1 = new Review();
            Review review2 = new Review();

            //Act

            // Give each Review some property definitions
            review1.Author = "Fred Derf";
            review2.Author = "Fred Derf";
            //Assert

             Assert.AreEqual(review1, review2);
        }

        [TestMethod]
        public void ReviewRatingIsBetween1and5_ReturnsTrue_Bool()
        {
            // **************************************************************
            // Unnecessary because the form itself limits the input.
            // **************************************************************

            //Arrange

            // Make a review

            //Act

            // Try to give it an "a";
            // Try to give it a 0;
            // Try to give it a -1;
            // Try to give it a 6;

            //Assert

            //Assert.AreEqual(testAverage, reviewAverage);
        }

        [TestMethod]
        public void ReviewContentLengthUnder255Char_ReturnsTrue_Bool()
        {   
            // **************************************************************
            // Unnecessary because the form itself limits the input.
            // **************************************************************

            //Arrange
            // create a Review for a product

            //Act
            // Get the length of the Review content

            //Assert
            //Assert that it's less than 255 char
        }
    
    
    }
}