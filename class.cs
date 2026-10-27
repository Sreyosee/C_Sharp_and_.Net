using System;

Student student = new Student();

student.Name = "Prapti";
student.Mark = 85;
student.Introduce();
class Student

{
    public string Name = "";
    public int Mark;

    public void Introduce()
    {
        Console.WriteLine("My name is " + Name);
        Console.WriteLine("My mark is " + Mark);
    }
   
}
