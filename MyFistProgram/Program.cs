// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine("This is awesome");

Dictionary<int, string> rookieOfTheYear = new();

// rookieOfTheYear.Add(2000, "Mike Miller");
// rookieOfTheYear.Add(2001, "Jane Doe");
// rookieOfTheYear.Add(2002, "Jane Doe");
// rookieOfTheYear.Add(2003, "John Smith");

// Console.WriteLine(rookieOfTheYear[2002]);

// public interface IEnumerator 
// {
//     bool MoveNext();
//     object Current { get; }
//     void Reset();
// }

// string s = "Hello";

// GetEnumerator();
// IEnumerator rator = s.GetEnumerator();

// while (rator.MoveNext())
// {
//     char c = (char) rator.Current;
//     Console.Write (c + ".");
// }

// string s = "Hello";

// foreach (char c in s)
//     Console.Write (c + ".");




public interface IEnumerator<T> : IEnumerator, IDisposable
{
    T Current { get; }
}

public interface IEnumerable<T> : IEnumerable
{
    IEnumerable IEnumerator<T> GetEnumerator();
}