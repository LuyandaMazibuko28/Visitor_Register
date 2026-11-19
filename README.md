# Visitor Register

A digital version of the paper register used to sign in before using a computer at a library.

## Why this project
In my hometown, you must fill in a paper register before using a library computer. This project replaces that paper with a digital form.

## What the form collects
- Name and surname
- Phone number
- Reason for visit
- Drawn signature
- Date and time (set automatically by the server when the form is submitted)

Every field is compulsory, just like on the paper register. The form will not submit if any field or the signature is empty.

## Features
- Sign-in form with a signature pad
- Validation on every field
- Visitor list showing each sign-in with the saved signature
- Visitors saved in a SQL Server database

## Built with
- C#
- ASP.NET Core MVC (.NET 9)
- Entity Framework Core
- SQL Server LocalDB
- signature_pad (JavaScript library)

## Running it locally
1. Install the .NET 9 SDK and make sure SQL Server LocalDB is available (it comes with Visual Studio).
2. Clone the repository.
3. In the project folder, run `dotnet ef database update` to create the database.
4. Run the app and open `/Visitor` in your browser.

The connection string is in `appsettings.json`.

## Status
Working version complete: a visitor can sign in, and the list shows everyone who has signed in. Times are currently stored and shown in UTC.

## Planned
- Show times in South African time
- Country code for phone numbers
- More fields to make the system more helpful