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
    }
}