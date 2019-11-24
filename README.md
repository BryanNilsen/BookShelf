# Exercise - BookShelf App

The purpose of this exercise is to practice creating a new MVC project using Entity and Identity Frameworks.


## The BookShelf App

The goal of this application is to allow users to keep track of the books they have on their bookshelf, as well as the authors of those books.

This application is built in ASP.<span>NET</span> Core MVC with Entity and Identity Frameworks and use a SQL Server database to store data.


### Data Entities

The application has the following entities with their associated properties.

#### ApplicationUser

* First Name
* Last Name
* Full Name
* _...All `IdentityUser` properties..._


#### Author

* First Name
* Last Name
* Full Name
* Penname (_optional_)
* PreferredGenre (_optional_)
* List of Books written by this Author
* ApplicationUser who created the Author 


#### Book

* ISBN (_should be between 10 and 13 characters_)
* Title
* Genre
* Publish Date
* Author (_a book may have **only one** Author_)
* Owner (_ApplicationUser who created the Book_)


### Requirements

1. Only authenticated users should have access to any Book or Author functionality
1. New users should be able to register for an account.
1. Existing users should be able to login with an email and password.
1. A user should be able to perform all CRUD operations on an Author.
1. A user should be able to perform all CRUD operations on a Book.
1. Users should **only** be allowed to View, Edit or Delete Books and Authors that **they created**.
1. Only Authors **not associated with a Book** may be deleted.