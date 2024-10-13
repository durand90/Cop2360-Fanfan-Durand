
// Base class: Peson
public class Person
{
    public string Name { get; set; }
    public string Age { get; set; }

    public string Height {get: set}

    public void StartWalking()
    {
        Console.WriteLine("Peson start walking");
    }

    public void StopWalking()
    {
        Console.WriteLine("Person stopped");
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

    // Method overriding the base class StartWalking method
    public new void StartWalking()
    {
        Console.WriteLine("Person is running");
    }
}

// Testing the classes
public class Program
{
    public static void Main(string[] args)
    {
        // Create an instance of the Car class
        Student newStudent = new Student();
        student.Name = "John";
        student.Age = "25";
        student.NumberOfClasses = 4;

        // Call methods from both the base and derived class
        myCar.StartEngine(); // Overridden method in Student class
        myCar.Honk();        // Student-specific method
        myCar.StopEngine();   // Inherited method from Person class

        // Output basic car details
        Console.WriteLine("Make: {myCar.Make}, Model: {myCar.Model}, Doors: {myCar.NumberOfDoors}");
    }