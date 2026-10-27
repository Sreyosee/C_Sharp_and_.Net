using System;

string name = "Prapti";
int age = 23;
double height = 1.60;
bool isStudent = true;

age = 24;

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height);
Console.WriteLine("Student: " + isStudent);

// Pi = 3.14; // This would cause an error.
const double Pi = 3.14159;

double radius = 5;
double area = Pi * radius * radius;

Console.WriteLine("Area: " + area);