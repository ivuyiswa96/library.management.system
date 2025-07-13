# **Library Management System**

This is a Library Management System that allows you to **create**, **retrieve**, **search**, and **delete** books.

---

## **Requirements**

To run the project, you need the following:

- .NET Core SDK (latest version)
- Visual Studio 2022 or the latest available version
- Local SQL Server instance
- IIS (optional for hosting)

---

## **Technologies Used**

- ASP.NET Core
- Blazor Server
- Entity Framework Core (Code-First)
- SQL Server
- xUnit for unit testing

---

## **Setup Instructions**

This system uses **Entity Framework Core** and the **Code-First approach**, so you are required to run the following commands before starting:

```powershell
Add-Migration InitialCreate
Update-Database

## **How to Use the System**

Once the migration is done and the app is running, the **dashboard screen will appear**.

- Click the **Add** button to add a new book.
- The page will refresh and show the latest added record.
- You can add as many records as you want.
- Use the **search bar** to find a book by its title.
- Click **Delete** to remove a book record from the list.

# Unit Testing

This project includes a dedicated unit testing project to ensure the functionality of the Library Management System.

## Running the Tests

To run the unit tests:

1. Open the testing project in **Visual Studio**.
2. Go to the menu and select **Test > Test Explorer**.
3. Run all tests to validate that the system behaves as expected.

## Test Coverage

The unit tests cover the following core functionalities:

- Creating a book  
- Retrieving a book by ID  
- Updating a book  
- Deleting a book  

These tests are implemented using the **xUnit** testing framework.

