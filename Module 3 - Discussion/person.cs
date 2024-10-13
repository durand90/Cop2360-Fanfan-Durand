
// Base class: Person
public class Person
{
    public string Name { get; set; }
    public string Age { get; set; }

    public string Height {get: set}

    public void Walking()
    {
        Console.WriteLine("This Peson is walking");
    }

    public void StopWalking()
    {
        Console.WriteLine("This Person has stopped");
    }
}

// Derived class: student (inherits from Person)
public class Student : Person
{
    public int NumberOfClasses { get; set; }

    // Method specific to student classes
    public void FullTimeStudent()
    {
        Console.WriteLine("This is a full time student");
    }

    // Method overriding the base class Walking method
    public new void Walking()
    {
        Console.WriteLine("This Person is walking really fast");
    }
}

// Testing the classes
public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the student class
        Student newStudent = new Student();
        student.Name = "John";
        student.Age = "25";
        student.NumberOfClasses = 4;

        // Call methods from both the base and derived class
        student.walking(); // Overridden method in Student class
        student.StopWalking();        // Student-specific method
        student.FullTimeStudent();   // Inherited method from Person class

        // Output basic car details
        Console.WriteLine("Name: {student.Name}, Age: {student.age}, classes: {stdent.FullTimeStudent}");
    }
}