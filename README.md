# PetSitter

PetSitter is a web application that facilitates the scheduling of pet sitting services through role-based authentication. The platform allows users to register as either customers or sitters. Customers can conveniently book pet sitting services, while sitters can view their scheduled bookings.

## Table of Contents

- [Technical Skills](#Technical Skills)
- [Features](#Features)
- [Installation](#Installation)
- [Configuration](#Configuration)
- [Updating the Database](#Updating the Database)
- [Usage](#Usage)
- [Demo](#Demo)
- [WireFrame](#WireFrame)
- [ERD](#ERD)

## Technical Skills

**Language**:
<img alt="C#" src="https://img.shields.io/badge/Language-C%23-blue">

**Framework & Libraries**:
<img alt="Built with Blazor" src="https://img.shields.io/badge/Built%20with-Blazor-blueviolet.svg">
<img alt="ASP.NET MVC 6" src="https://img.shields.io/badge/ASP.NET-MVC6-blue">
<img alt="Entity Framework" src="https://img.shields.io/badge/Entity-Framework-green">
<img alt="Identity Framework" src="https://img.shields.io/badge/Framework-Identity-5c2d91">
<img alt="jQuery" src="https://img.shields.io/badge/Library-jQuery-blue?logo=jquery&logoColor=white">
<img alt="AJAX" src="https://img.shields.io/badge/Language-AJAX-4b4b4b">

**CSS and CSS Frameworks**:
<img alt="CSS" src="https://img.shields.io/badge/Language-CSS-blueviolet">
<img alt="Bootstrap" src="https://img.shields.io/badge/Framework-Bootstrap-563d7c">

**Other tools and services**:
<img alt="PayPal API" src="https://img.shields.io/badge/API-PayPal-003087">
<img alt="SendGrid" src="https://img.shields.io/badge/Service-SendGrid-00a9e0">
<img alt="reCAPTCHA" src="https://img.shields.io/badge/Security-reCAPTCHA-brightgreen">

**Database**:
<img alt="Microsoft SQL Server" src="https://img.shields.io/badge/Database-Microsoft%20SQL%20Server-blue?logo=microsoft-sql-server&logoColor=white">

**Cloud**:
<img src="https://img.shields.io/badge/Microsoft%20Azure-0089D6?logo=microsoft-azure&logoColor=white&style=flat-square" alt="Microsoft Azure badge">

## Features

**User Registration:** The platform allows for registration of both customers and sitters. During registration, users are required to provide personal details such as first name, last name, email, phone number, city, postal code, street address, and account type (either customer or sitter) for both customer and sitter registration.

**Booking System:** Customers can easily book a pet sitter service, select the dates with available sitter for the service, and provide additional information about their pets. Sitters can review their scheduled bookings, confirm them, and view customer contact information.

**Search:** Customers can search for available sitters by location, availability, and pet type.

**Reviews:** Customers can rate and leave reviews for sitters, which can be publicly viewed by other customers. Sitters, in turn, can view their overall rating, as well as individual ratings and comments from customers.

**Customer Profile:** Customers have access to a dedicated profile page where they can manage their personal information, view their upcoming bookings, and add, modify or remove pet information.

**Sitter Dashboard**: Sitters can view a dashboard that shows the number of upcoming and completed bookings, as well as the total number of reviews they have received so far. They can also see the customer's name, booking ID, pet type, start date, and end date.

**Admin Dashboard**: Administrators have access to a dashboard that allows them to view and re-assign user roles, and view the entire list of users along with their information, including user ID, first name, and last name. The dashboard also includes search functionality to find specific users.

## Installation

1. Clone the repository using git clone https://github.com/YHKimmm/PetSitter.git

2. Open the solution file PetSitter.sln in Visual Studio

3. Restore the NuGet packages

4. uild the solution

## Configuration

This application's configuration and strings such as mssql connection string, sendgrid api key, recaptcah site key and secret key are stored in secrets.json file.

Update the connection string in the appsettings.json file to point to your database.


## Updating the Database

To update the database with any pending Entity Framework migrations, follow these steps:

1. Open the Package Manager Console in Visual Studio by going to `Tools > NuGet Package Manager > Package Manager Console`

2. Make sure that the Default Project dropdown is set to the project that contains your Entity Framework DbContext

3. In the Package Manager Console, type the following command and press Enter:
  `update-database -Context PetSitterContext`
  `update-database -Context ApplicationDbContext`
  
4. You can now run your ASP.NET MVC application and verify that it is using the updated database schema

## Usage

1. Run the application

2. Register as a customer or sitter

3. Search for available sitters and book a pet sitting service

4. Review your upcoming bookings on the dashboard

## Demo
https://petsitter20230420102802.azurewebsites.net/

## WireFrame

## ERD




