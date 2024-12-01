// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// int x = 12 * 30;
// System.Console.WriteLine (x);

using System;
using System.Runtime;

// int x = 12 * 30;
// Console.WriteLine (x);

// Console.WriteLine (FeetToInches(30));
// Console.WriteLine (FeetToInches(100));

// int FeetToIches (int feet)
// {
//     int inches = feet * 12;
//     return inches;
// }

//

// SayHello();

// void SayHello()
// {
//     Console.WriteLine("Hello, World");
// }

//
// string message = "hello world";
// string upperMessage = message.ToUpper();
// Console.WriteLine (upperMessage);

// int x = 2022;
// message = message + x.ToString();
// Console.WriteLine (message);

//
// bool simpleVar = false;
// if (simpleVar)
//     Console.WriteLine ("This will not print");

// int x = 5000;
// bool lessThanAMile = x < 5280;
// if (lessThanAMile)
//     Console.WriteLine ("This will print");

//
// unitConverter feetToInchesConverter = new UnitConverter (12);
// unitConverter milesToFeetConverter = new unitConverter (5280);

// Console.WriteLine (feetToInchesConverter.Convert(30));
// Console.WriteLine (feetToInchesConverter.Convert(100));

// Console.WriteLine (feetToInchesConverter.Convert(
//     milesToFeetConverter.Convert(1)));

// public class UnitConveter
// {
//     int ratio;

//     public UnitConverter (int unitRatio)
//     {
//     ratio = unitRatio;
//     }
//     public int Convert (int unit)
//     {
//     return unit * ratio;
//     }
// }

//
// Panda p1 = new Panda ("Pan Dee");
// Panda p2 = new Panda ("Pan Dah");

// Console.WriteLine (p1.Name);
// Console.WriteLine (p2.Name);

// Console.WriteLine (Panda.Population);

// public class Panda
// {
//     public string Name;
//     public static int Population;

//     public Panda (string n)
//     {
//         Name = n;
//         Population = Population + 1;
//     }
// }


// important //
// using System;
// using animals;

// Panda p = new Panda ("Pan Dee");
// Console.WriteLine (p.Name);

// Namespace Animals
// {
//     public class Panda
//     {
//         ...
//     }
// }

//very important//
// using System;

// class Program
// {
//     static void Main()  //Program entry point * will return a number even though it is void.
//     {
//         int x = 12 * 30;
//         Console.WriteLine (x);
//     }
// }


//also important//
// using System;

// class Program
// {
//     static void Main (string[] args) //program entry point but will accept an array with strings
//     {
//         string x = "money, bacon";
//         Console.WriteLine (x);
//     }
// }


// int x = 3;
// LocalMethod();

// void LocalMethod() { Console.WriteLine (x); }