Address Book Project
This project is a simple address book implemented in C#. It provides a user-friendly console interface for managing addresses, including the ability to add, search, update, and remove entries. The project demonstrates fundamental concepts of object-oriented programming, error handling, and the use of custom exceptions.

Features
Add Address: Allows users to add new addresses with first name, last name, street, city, postal code, and phone number.
Search Address: Offers various search criteria (name, street, city, phone number) to quickly find addresses.
Update Address: Enables users to update existing address details based on the phone number.
Remove Address: Deletes addresses from the list using the phone number.
Show All Addresses: Lists all stored addresses and displays their details.
Technologies
Programming Language: C#
Development Environment: Visual Studio / Visual Studio Code
.NET Version: .NET 5.0 or higher
Structure
The project is organized into several classes to encapsulate different functionalities:

Person: Abstract base class for persons containing first and last name.
Address: Represents an address with the appropriate properties.
AddressManager: Manages addresses with methods for adding, searching, updating, and removing entries.
Exceptions: Custom exceptions for specific error cases related to addresses.
