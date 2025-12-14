
Create an Employee class with the following specifications
1.	Employee Name as string.
2.	Basic Salary, HRA, DA, TAX, Gross Pay and Net salary as decimal.
3.	Calculate the HRA (15% of Basic Salary), DA (10% of Basic Salary), Gross Pay (Basic Salary + HRA + DA), Tax (8% of Gross Pay) and Net Pay (Gross Pay – Tax).
4.	A Constructor to allow to define the Employee Name and Basic Salary.
5.	A method CalculateNetPay to calculate the HRA, DA, Tax, Gross and Net Pay values using the criteria mentioned in Point 4.
6.	A method Display to Display the Salary structure.
_________________________________________________________________________________________________________
Create a new class called “Stock” which contains the following
1.	A String for the stock name
2.	A String for the stock symbol
3.	A double storing the previous closing price of the stock
4.	A double storing the current closing price of the stock
5.	A constructor that allows you to define a stock's name, symbol, previous closing price and current closing price
6.	A method getChangePercentage() that returns the percentage change from the previous closing price to the current closing price
_____________________________________________________________________________________________________________
Create a new class called “RandomHelper” which contains the following:
1.	A static method called randint that accepts two integers and returns a random integer between them.
Make sure that the numbers are inclusive (i.e., if you call randomint(1,10) you should be able to generate both 1 and 10).
2.	A static method called randdouble that accepts two integers and returns a random double between them.
For this method, you should be able to generate numbers such that 1 <= x < 10 for the method call randdouble(1,10).
3.	Call your method from another class without instantiating the class
(i.e., call it just like you would call Math.random() since your methods are defined to be static).
