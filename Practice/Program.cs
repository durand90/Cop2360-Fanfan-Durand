// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");




// }




using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new dictionary where the key is a string and the value is an int
        Dictionary<string, int> ageDictionary = new Dictionary<string, int>();

        // Add some key-value pairs to the dictionary
        ageDictionary.Add("John", 30);
        ageDictionary.Add("Alice", 25);
        ageDictionary.Add("Bob", 35);

        // Access values using keys
        Console.WriteLine("John's age: " + ageDictionary["John"]);
        Console.WriteLine("Alice's age: " + ageDictionary["Alice"]);

        // Check if a key exists
        if (ageDictionary.ContainsKey("Bob"))
        {
            Console.WriteLine("Bob's age: " + ageDictionary["Bob"]);
        }

        // Update a value by key
        ageDictionary["Alice"] = 26;  // Changing Alice's age
        Console.WriteLine("Updated Alice's age: " + ageDictionary["Alice"]);

        // Iterate over the dictionary
        Console.WriteLine("\nAll entries in the dictionary:");
        foreach (KeyValuePair<string, int> entry in ageDictionary)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }

        // Remove an entry by key
        ageDictionary.Remove("Bob");

        // Check if the removal was successful
        Console.WriteLine("\nAfter removing Bob:");
        foreach (KeyValuePair<string, int> entry in ageDictionary)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }
}
