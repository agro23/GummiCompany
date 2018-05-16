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
    public class ProductControllerTest : Controller
    {

        Mock<IProductRepository> mock = new Mock<IProductRepository>();
        EFProductRepository db = new EFProductRepository(new GummiTestDbContext());

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public void SetUpTheMockDb()
        {

            mock.Setup(m => m.Products).Returns(new Product[]
            {
            new Product {ProductId = 1, Name = "Gummy Hat", Cost = 12, Description = "A tasty hat" },
            new Product {ProductId = 2, Name = "Gummy Shoe", Cost = 13, Description = "A yummy shoe" },
            new Product {ProductId = 3, Name = "Gummy Iron", Cost = 14, Description = "A jiggly iron" }
            }.AsQueryable());
            //ViewResult indexView = new ProductsController(mock.Object).Index() as ViewResult;
            ViewResult indexView = new ProductsController(mock.Object).Index() as ViewResult;


        }

        //public void Dispose()
        //{
        //    mock.Object.RemoveAll();
        //    db.RemoveAll();
        //}

        //[TestMethod]
        //public void ProductsController_IndexModelContainsCorrectData_List()
        //{
        //    //Arrange
        //    SetUpTheMockDb();

        //    ProductsController controller = new ProductsController(db);
        //    IActionResult actionResult = controller.Index();
        //    ViewResult indexView = controller.Index() as ViewResult;

        //    //Act
        //    var result = indexView.ViewData.Model;

        //    //Assert
        //    Assert.IsInstanceOfType(result, typeof(List<Product>));
        //}


        [TestMethod]
        public void ProductsController_IndexModelContainsCorrectData_List()
        {
            //Arrange
            SetUpTheMockDb();
            ViewResult indexView = new ProductsController(mock.Object).Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Product>));
        }


        [TestMethod]
        public void Mock_GetViewResultIndex_ActionResult()
        {
            //Arrange
            SetUpTheMockDb();
            ProductsController controller = new ProductsController(mock.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }



        [TestMethod]
        public void Mock_IndexModelContainsProduct_Collection()
        {
            // Arrange
            SetUpTheMockDb();
            ProductsController controller = new ProductsController(mock.Object);
            Product testProduct = new Product();
            testProduct.Name = "Gummi Bear";
            testProduct.ProductId = 1;

            // Act
            ViewResult indexView = controller.Index() as ViewResult;
            List<Product> collection = indexView.ViewData.Model as List<Product>;

            // Assert
            CollectionAssert.Contains(collection, testProduct);
        }
        [TestMethod]
        public void Mock_PostViewResultCreate_ViewResult()
        {
            // Arrange
            Product testProduct = new Product
            {
                ProductId = 1,
                Name = "Gummi Bear"
            };

            SetUpTheMockDb();
            ProductsController controller = new ProductsController(mock.Object);

            // Act
            var resultView = controller.Create(testProduct);


            // Assert
            Assert.IsInstanceOfType(resultView, typeof(RedirectToActionResult));

        }

        [TestMethod]
        public void ProductController_AddsProductToIndexModelData_Collection()
        {
            // Arrange
            SetUpTheMockDb();

            ProductsController controller = new ProductsController(mock.Object);
            Product testProduct = new Product();
            testProduct.Description = "test product";

            // Act
            controller.Create(testProduct);
            ViewResult indexView = new ProductsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Product>;

            // Assert
            CollectionAssert.Contains(collection, testProduct);
        }

        [TestMethod]
        public void ProductController_IndexModelContainsCorrectData_List()
        {
            //Arrange
            ProductsController controller = new ProductsController(mock.Object);
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Product>));
        }


        [TestMethod]
        public void Mock_GetDetails_ReturnsView()
        {
            // Arrange
            Product testProduct = new Product
            {
                ProductId = 1,
                Name = "Gummi Bear"
            };

            SetUpTheMockDb();
            ProductsController controller = new ProductsController(mock.Object);

            // Act
            var resultView = controller.Details(testProduct.ProductId) as ViewResult;
            var model = resultView.ViewData.Model as Product;

            // Assert
            Assert.IsInstanceOfType(resultView, typeof(ViewResult));
            Assert.IsInstanceOfType(model, typeof(Product));
        }

        [TestMethod]
        public void DB_CreatesNewEntries_Collection()
        {
            // Arrange
            SetUpTheMockDb();
            ProductsController controller = new ProductsController(mock.Object);
            Product testProduct = new Product();
            testProduct.Name = "Gummi Bear";

            // Act
            controller.Create(testProduct);
            var collection = (controller.Index() as ViewResult).ViewData.Model as List<Product>;

            // Assert
            CollectionAssert.Contains(collection, testProduct);
        }


    }
}

