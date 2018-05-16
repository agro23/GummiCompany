# Gummi Bear Kingdom

### By Andy Grossberg

## Description
A .Net application and a database as a marketing front end for a candy company.

## Rules

Today I'll be using ASP.NET Core to build a basic web app. I'll be building this same project for the next two Fridays.
UPDATE:

## Objectives

**Phase One Objectives**
*    Can a user add, view, and delete items?
*    Are form and route helpers present and functioning?
*    Does the app use a Layout file for styling across the app?
*    Does the project include a detailed README?
*    Is the database written code-first, with clear migration instruction?

**Phase Two Objectives**
*    Can a user post a review for a product as well as view all reviews for a product? Is the average rating displayed for each product?
*    Does the landing page contain the top three products?
*    Does the test project include the required unit tests and do they pass?
*    Have changes to the database been made using migrations?

**Like to haves**

*    Add a Blog section, where contributors may post blog posts discussing chosen topics. Posts should have a title, author, and text-body. The newest blog post should appear at the top of the blog page.
*    Allow users to add tags to blog posts. Use a many-to-many relationship to do this (each blog can have many tags and each tag can be applied to many blogs).
*   Allow users to add a picture for a Product. You can use URLs (easier) or pursue research and discover how to include images in your database (harder).

### Site Specs

**Database**

* The database should be built code-first. They want to have simple setup on the Gummi Bear Kingdom servers, so I'll need to have a simple database migration set up and ready to run.
* UPDATE 4/27/18: The site should have functionality to review products so the database should include a one-to-many relationship between Products and Reviews.
- Products: must have a name, cost, and description.
- Reviews must have an author, content body, and rating (1-5).
- Migrations are used to update the database from last week.

**Landing Page**

* This is the main page, which includes some information about Gummi Bear Kingdom, and allows access to other areas of the site: An About, and Products Page
	- The top three products by number of reviews will be listed here.

**Products**

* The Products section will contain a list of products offered by Gummi Bear Kingdom. There will be a few "dummy" products, but not too many.
	- Products will have a _name_, _cost_, and _description_.

* Each product will have its own Details page where its information is displayed as well as its reviews.

**Testing**

I will use a mock database for testing controller and model functions before using the live test database to test for integration. Required database setup information is below in this README.

The site will include the following functionality and their corresponding tests:

* Fully functioning Product model with tests for: - X
	- The constructor
	- Equals()
	- Method for returning an average rating

* Fully functioning Review model with tests for: - X
	- The constructor
	- Equals()
	- Method for checking if rating is between 1-5 -- N/A THE FORM LIMITS THE INPUT
	- Method for checking if the Review’s content_body contains less than 255 characters. -- N/A THE FORM LIMITS THE INPUT

* Products can be created, retrieved, updated, and removed from the database, as demonstrated by integration tests for:
	- Create()
	- Index()
	- Update()
	- Delete()
	- DeleteAll()
	(Using TEST database)

* Reviews are properly retrieved from and saved to the database with tests for:
	- Index()
	- Create()
	(Using TEST database)

* All controller methods return the correct ActionResult (usually ViewResult or RedirectToActionResult) and Model datatype for each method. With tests for:
	- GET and POST for each route.
	(Using mock database)

**Styling**

* This should be a well-styled site I'm proud to show potential employers. After core functionality is in place, any extra time will be spent on styling.

* If I need inspiration, I will choose a site online with a style I like and build a style for my app based on it. However, I will then include a link to the site that styles are based on here in the README.md.

## User Stories
There will ultimately be two levels of user for this site: Administrator and Reader. However, at the outset, it is assumed every user is an Admin to avoid spending time bogged down with authorization programming.

**All Users**
*    A user should be able to click on a link on the Landing page that takes them to a page that lists all available Products.
*    A user should be able to click on each Product and see its Details.

**Admin**
*    An admin should be able to add and remove individual Products, as well as delete all Products.
	- All users are Admin to begin with

## Specifications

* Data Models are created

* UPDATE: 4/27 -- add properties to Product models

* UPDATE: 4/27 -- add Reviews model

* CRUD for Products

* UPDATE: 4/27 -- create CRUD for Reviews

* **UPDATE: 4/27 -- create one-to-many relationship between Reviews and Products**

* UPDATE: 4/27 -- Add User Model

* UPDATE: 4/27 -- User CRUD

* UPDATE: 4/27 -- User Controller

* UPDATE: 4/27 -- User View

* UPDATE: 4/27 -- User one-to-many on Reviews

* TESTING ************************************************

* Model testing with (mock or test database?)   
	- UPDATE: 4/27 -- Product Model Tests _(3/3)_
	- UPDATE: 4/27 -- Review Model Tests _(4/4)_

* Controller Testing with mock database

* Models and Controllers work

* Integration testing with models and controllers using test database
	- CRUD

* *********************************************************

* Add Views

* MVC working

* UPDATE: 4/27 -- Validate Form inputs? (The form traps for length 255 and rating 1-5)

* Layout is present for styling

* Pretty up the UI

* Refactor code as needed.

## Methodology and Comments

I started with the travel blog website as my example template because it is constructed to be a blog. I adapted the Experiences/Locations/People into individual models for Users, Reviews, and Products but they ended up having no relation to their originators from the Travel site. I got CRUD up and running and did some work with styles the first week and I started some tests during this second week. Unfortunately I ran into migration errors that have eaten into my time. I will complete the project during the upcoming weeks. I still have to implement user sign up, adding reviews to products, seeing the top three products on the site's landing page, and a few other things.
UPDATE: Product reviews are in, the products can be averaged, the top three products are visible. Finishing up the tests.

## Technologies Used

* HTML
* CSS
* Javascript
* jQuery
* C#
* .NET (ASP) Core
* mySQL

## Dependencies and plugins

**Dependencies**
TBD

## Setup/Installation Requirements
Clone the repository from https://github.com/agro23/GummiCompany
Migrate the database using Entity Framework (cd to the Gummi directory and dotnet ef database update)
Run the program using Visual Studio

## Future expansion
 I could always put user authentication back in and then separate the Admins from Users. There are always more tests that can be run. Also I'd like to implement a more clean method of showing the reviews.

## Known Bugs and Issues

There are no known bugs or issues at this time other than the program not having user authentication enabled and the styling could be much better.

## Support and contact details

**Contact the author at andy.grossberg@gmail.com**

## License
Licensed for use under the GNU GPL. (c) 2018 Andy Grossberg
