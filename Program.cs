
// // console print
// Console.WriteLine("Hello, World!");

// // data types
// string name = "Uberth";
// char note = 'A';
// int age = 32;
// float distance = 1.2F;
// double PI = 3.14159;
// decimal money = 367.234567M;
// bool isValid = true;

// //Literal variables
// var userName = "snipsx";
// var userAge = 32;
// var isLogged = false;

// Operations over numbers

// Obtain divition with decimal point
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");


// convert temporarily to decimal
int first = 7;
int second = 5;
decimal q = (decimal)first / (decimal)second;
Console.WriteLine(q);

// Modulus
// Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
// Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// ARRAY

// Create
string[] names = ["Jhon", "Bertrand", "Linus", "Uberth"];

// Read

foreach( var userName in names ){
    Console.WriteLine(userName);
}