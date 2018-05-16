using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gummi.Controllers;
using Gummi.Models;
using Gummi.Models.Repositories;
using Gummi.Tests.ModelTests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Gummi.Tests.ControllerTests
{
    [TestClass]
    public class ReviewsControllerTest : Controller
    {

        Mock<EFReviewRepository> mock = new Mock<EFReviewRepository>();
        EFReviewRepository db = new EFReviewRepository(new GummiDbContext());

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public void SetUpTheMockDb()
        {
            // public Review(int productId, string author, string content, int rating)
           
            mock.Setup(m => m.Reviews).Returns(new Review[]
            {
                new Review {ReviewId = 1, Author = "Gummy Manny", Content = "I liked it.", Rating = 5, ProductId = 1 },
                new Review {ReviewId = 2, Author = "Gummy Moe", Content = "I hated it.", Rating = 1, ProductId = 1 },
                new Review {ReviewId = 3, Author = "Gummy Jack", Content = "It's okay.", Rating = 3, ProductId = 2 }
            }.AsQueryable());
            //    new Review {Author = "Gummy Manny", Content = "I liked it.", 5},
            //    new Review {Author = "Gummy Moe"},
            //    new Review {Author = "Gummy Jack"}
            //}.AsQueryable());

            ViewResult indexView = new ReviewsController(mock.Object).Index() as ViewResult;

        }

        //public void Dispose()
        //{
        //    mock.Object.RemoveAll();
        //    db.RemoveAll();
        //}

        //[TestMethod]
        //public void Mock_GetViewResultIndex_ActionResult()
        //{
        //    //Arrange
        //    Mock<EFReviewRepository> mock1 = new Mock<EFReviewRepository>();
        //    ReviewsController controller = new ReviewsController(mock1.Object);

        //    //Act
        //    var result = controller.Index();

        //    //Assert
        //    Assert.IsInstanceOfType(result, typeof(ActionResult));
        //}

        //[TestMethod]
        //public void ReviewsController_IndexModelContainsCorrectData_List()
        //{
        //    //Arrange
        //    SetUpTheMockDb();;
        //    ViewResult indexView = new ReviewsController(mock.Object).Index() as ViewResult;

        //    //Act
        //    var result = indexView.ViewData.Model;

        //    //Assert
        //    Assert.IsInstanceOfType(result, typeof(List<Review>));
        //}

        //[TestMethod]
        //public void Mock_IndexModelContainsReview_Collection() // Confirms presence of known entry
        //{
        //    // Arrange
        //    SetUpTheMockDb();;
        //    ReviewsController controller = new ReviewsController(mock.Object);
        //    Review testReview = new Review();
        //    testReview.Author = "Tester McTestFace";
        //    testReview.ReviewId = 1;

        //    // Act
        //    ViewResult indexView = controller.Index() as ViewResult;
        //    List<Review> collection = indexView.ViewData.Model as List<Review>;

        //    // Assert
        //    CollectionAssert.Contains(collection, testReview);
        //}


        //[TestMethod]
        //public void Mock_PostViewResultCreate_ViewResult()
        //{
        //    // Arrange
        //    Review testReview = new Review
        //    {
        //        ReviewId = 1,
        //        Author = "Gummi Bear"
        //    };

        //    SetUpTheMockDb();
        //    ReviewsController controller = new ReviewsController(mock.Object);

        //    // Act
        //    var resultView = controller.Create(testReview);


        //    // Assert
        //    Assert.IsInstanceOfType(resultView, typeof(RedirectToActionResult));

        //}


        //[TestMethod]
        //public void Mock_GetDetails_ReturnsView()
        //{
        //    // Arrange
        //    Review testReview = new Review
        //    {
        //        ReviewId = 1,
        //        Author = "Muffin Man"
        //    };

        //    SetUpTheMockDb();
        //    ReviewsController controller = new ReviewsController(mock.Object);

        //    // Act
        //    var resultView = controller.Details(testReview.ReviewId) as ViewResult;
        //    var model = resultView.ViewData.Model as Review;

        //    // Assert
        //    Assert.IsInstanceOfType(resultView, typeof(ViewResult));
        //    Assert.IsInstanceOfType(model, typeof(Review));
        //}


        //[TestMethod]
        //public void DB_CreatesNewEntries_Collection()
        //{
        //    // Arrange
        //    ReviewsController controller = new ReviewsController(db);
        //    Review testReview = new Review();
        //    testReview.Author = "Gummi Bear";

        //    // Act
        //    controller.Create(testReview);
        //    var collection = (controller.Index() as ViewResult).ViewData.Model as List<Review>;

        //    // Assert
        //    CollectionAssert.Contains(collection, testReview);
        //}


    }
}







