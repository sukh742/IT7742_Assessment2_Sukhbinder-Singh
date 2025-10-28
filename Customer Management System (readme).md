**Customer Management System (readme)**



\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*

Project Introduction

\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*



This project is made for learning how to build a small system using the Model-View-Controller (MVC) pattern.

It helps to manage customer information and bank account data in a simple way.

The project is divided into two parts:



CustomerManagementApp – the main program with forms and controllers.



CustomerManagementTests – a test project to check if the code works correctly.



\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*

Task 1 – Customer Information Manager

\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*



In this part, a small Windows Form was made to add, update, delete, and clear customer details.

It uses a controller class to connect the form (View) with the data (Model).

The design follows the company style, with labels, text boxes, buttons, and a data grid.

All customer data stays in memory only.

The controller checks input and shows error messages if something is missing.

The form updates the table every time a new customer is added or removed.



\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*

Task 2 – Unit Tests and Exception Handling

\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*

This part is for testing and making the code more reliable.

An exception class called FailedWithdrawalException was created to handle errors when money is withdrawn but the account has no balance.

It gives a clear message and the type of account that failed.

Then, MSTest was used to write and run several tests for the Account class.



The test cases passed as follows:



Deposit increases balance.



Deposit throws an error for a negative number.



Withdraw works correctly when there is enough balance.



Withdraw throws FailedWithdrawalException if there is not enough money.



The Info method shows account details correctly.



All five tests passed successfully.



\*\*\*\*\*\*\*\*\*\*\*\*\*

Tools Used

\*\*\*\*\*\*\*\*\*\*\*\*\*

C# (.NET Framework 4.7.2)



Visual Studio 2022



MSTest Test Framework



Windows Forms APP





