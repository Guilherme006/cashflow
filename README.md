## About the Project

This **API**, developed using **.NET 8**, adopts the principles of **Domain-Driven Design (DDD)** to offer a structured and effective solution for managing personal expenses. The main objective is to allow users to record their expenses, detailing information such as title, date and time, description, amount and payment type, with the data being stored securely in a **MySQL** database.

The **API** architecture is based on **REST**, using standard **HTTP** methods for efficient and simplified communication. Furthermore, it is complemented by **Swagger** documentation, which provides an interactive graphical interface so that developers can easily explore and test endpoints.

Among the NuGet packages used, **AutoMapper** is responsible for mapping between domain objects and request/response, reducing the need for repetitive and manual code. **FluentAssertions** are used in unit tests to make checks more readable, helping you write clear and understandable tests. For validations, **FluentValidation** is used to implement validation rules in a simple and intuitive way in request classes, keeping the code clean and easy to maintain. Finally, the **EntityFramework** acts as an ORM (Object-Relational Mapper) that simplifies interactions with the database, allowing the use of .NET objects to manipulate data directly, without the need to deal with SQL queries.

![hero-image]

### Features

- **Domain-Driven Design (DDD):** Modular structure that facilitates understanding and maintenance of the application domain.
- **Unit Testing:** Comprehensive testing with FluentAssertions to ensure functionality and quality.
- **Report Generation:** Ability to export detailed reports to **PDF** and **Excel**, offering a visual and effective analysis of expenses.
- **RESTful API with Swagger Documentation:** Documented interface that makes integration and testing easier for developers.

### Built with

![badge-dot-net]
![badge-windows]
![badge-visual-studio]
![badge-mysql]
![badge-swagger]

## Getting Started

To get a working local copy, follow these simple steps.

### Requirements

- Visual Studio version 2022+ or Visual Studio Code
- Windows 10+ or ​​Linux/MacOS with [.NET SDK][dot-net-sdk] installed
- MySQL Server

### Installation

1. Clone the repository:

    ```sh
    git clone https://github.com/Guilherme006/cashflow.git
    ```

2. Fill in the information in the `appsettings.Development.json` file.
3. Run the API and enjoy your testing :)


<!-- Links -->
[dot-net-sdk]: https://dotnet.microsoft.com/en-us/download/dotnet/8.0

<!-- Images -->
[hero-image]: /images/heroimage.png

<!-- Badges -->
[badge-dot-net]: https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=fff&style=for-the-badge
[badge-windows]: https://img.shields.io/badge/Windows-0078D4?logo=windows&logoColor=fff&style=for-the-badge
[badge-visual-studio]: https://img.shields.io/badge/Visual%20Studio-5C2D91?logo=visualstudio&logoColor=fff&style=for-the-badge
[badge-mysql]: https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge
[badge-swagger]: https://img.shields.io/badge/Swagger-85EA2D?logo=swagger&logoColor=000&style=for-the-badge
