// ARRAYS

// string[] fruits = new string[3];

// fruits[0] = "apple";
// fruits[1] = "plum";
// fruits[2] = "cherry";

string[] fruits = {"apple", "plum", "cherry"};  

Console.WriteLine(fruits[0]);

// LISTS

// List<string> colours = new List<string>(); // empty list

List<string> colours = new List<string>{"green", "blue", "pink"};

// Console.WriteLine(colours[2]);

colours.Add("grey");

colours.Remove("blue");

colours.RemoveAt(0);

// LIST METHOD
List<string> colours2 = new List<string>{"white", "red", "orange"};

colours.AddRange(colours2);

colours.Insert(0, "yellow");

Console.WriteLine(colours.Contains("orange"));

Console.WriteLine(colours.IndexOf("red"));

Console.WriteLine(colours.Count);

colours.Sort();
Console.WriteLine(colours[0]);
Console.WriteLine(colours[5]);

colours.Reverse();
Console.WriteLine(colours[0]);
Console.WriteLine(colours[5]);

colours.Clear();
Console.WriteLine(colours[0]);
