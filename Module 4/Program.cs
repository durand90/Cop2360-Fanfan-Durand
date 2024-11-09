// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("This is awesome");

// Dictionary<int, string> rookieOfTheYear = new();

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




// public interface IEnumerator<T> : IEnumerator, IDisposable
// {
//     T Current { get; }
// }

// public interface IEnumerable<T> : IEnumerable
// {
//     IEnumerable IEnumerator<T> GetEnumerator();
// }


//
// public static int Count (IEnumerable e)
// {
//     int count = 0;
//     foreach (object element in e)
//     {
//         var subCollection = element as IEnumerable;
//         if (subCollection != null)
//         count += Count (subCollection);
//         else
//             count++;
//     }
//     return count;
// }

//
// public class MyCollection : IEnumerable
// {
//     int[] data = { 1, 2, 3, 4 };
    
//     public IEnumerator GetEnumerator()
//     {
//         foreach (int i in data)
//             yield return i;
//     }
// }


//
// public class MyGenCollection : IEnumerable<int>
// {
//     int[] data = { 1, 2, 3 };

//     public IEnumerator<int> GetEnumerator()
//     {
//         foreach (int i in data)
//             yield return i;
//     }
// }


//
// public static IEnumerable <int> GetSomeIntegers()
// {
//     yield return 1;
//     yield return 2;
//     yield return 3;
// }

////
// public class MyIntList : IEnumerable 
// {
//     int[] data = { 1, 2, 3 };
    
//     public IEnumerator GetEnumerator() => new Enumerator (this);

//     class Enumerator : IEnumerator 
//     {
//         MyIntList  collection;
//         int currentIndex = -1;

//         public Enumerator (MyIntList items) => this.collection = items;

//         public objecct Current
//         {
//             get 
//             {
//                 if (currentIndex == -1)
//                     throw new InvalidOperationException ("Enumeration not started!");
//                 if (currentIndex == collection.data.Length)
//                     throw new InvalidOperationException ("Past end of list!");
//                 return collection.data [currentIndex];
//             }
//         }
//         public bool MoveNext()
//         {
//             if (currentIndex >= collection.data.length - 1) return false;
//             return ++currentIndex < collection.data.length;
//         }
//         public void Reset() => currentIndex = -1;
//     }
// }


//
// public interface ICollection<T> : IEnumerable<T>, IEnumerable
// {
//     int Count { get; }

//     bool Contains (T item);
//     void CopyTo (T[] array, int arrayIndex);
//     bool IsReadOnly { get; }

//     void Add(T item);
//     bool Remove (T item);
//     void Clear();
// }

//
// public interface ICollection : IEnumerable 
// {
//     int Count { get; }
//     bool IsSynchronized { get; }
//     object SyncRoot { get; }
//     void CopyTo (Array array, int index);
// }

//
// public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
// {
//     T this [int index] { get; set; }
//     int indexOf (T item);
//     void Insert (int index, T item);
//     void RemoveAt (int index);
// }

// //
// public interface IList : ICollection, IEnumerable
// {
//     object thtis [int index ] { get; set; };
//     bool IsFixedSize { get; };
//     bool IsReady { get; };
//     int Add (object value);
//     void Clear();
//     bool Contains (object value);
//     int IndexOf (object value);
//     void Insert (int index, object value);
//     void Remove (object value);
//     void RemoveAt (int index);
// }


///////
// int[] myArray = { 1, 2, 3 };
// int first = myArray [0];
// int last = myArray [myArray.length - 1];


//
// void WriteFirstValue (Array a)
// {
//     Console.Write (a.Rank + "-dimensional; ");

//     int[] indexers = new int[a.Rank];
//     Console.WriteLine ("First value is " + a.GetValue (indexers));
// }

// void Demo()
// {
//     int[] oneD = { 1, 2, 3 };
//     int[,] twoD = { {5,6}, {8,9} };

//     WriteFirstValue (oneD);
//     WriteFirstValue (twoD);
// }


// //
// void WriteFirstValue<T> (T[] array)
// {
//     Console.WriteLine (array[0]);
// }



//
// int[] myArray = { 1, 2, 3 };
// foreach (int val in myArray)
//     Console.WriteLine (val);