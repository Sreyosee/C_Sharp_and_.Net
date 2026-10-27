using System;

int a = 10;
int b = 3;

// Arithmetic
Console.WriteLine(a + b); 
Console.WriteLine(a - b); 
Console.WriteLine(a * b); 
Console.WriteLine((double)a / b); 
Console.WriteLine(a % b); 

// Comparison
Console.WriteLine(a > b);  
Console.WriteLine(a == b); 
Console.WriteLine(a != b); 

// Logical: AND, OR, NOT
Console.WriteLine(a > 5 && b < 5); 
Console.WriteLine(a < 5 || b < 5); 
Console.WriteLine(!(a > b));      

// Assignment and increment
a += 2; 
Console.WriteLine("a: " + a);

a++;    
b--;   
Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);