using System;
using System.Collections.Generic;

// Create a new dictionary
Dictionary<string, int> personAges = new Dictionary<string, int>();

// Add some key-value pairs
personAges.Add("John", 30);
personAges.Add("Alice", 25);
personAges.Add("Bob", 40);


// Update a value
personAges["John"] = 31;
System.Console.WriteLine(personAges["John"]); // Outputs: 31

// Remove a key-value pair
personAges.Remove("Alice");

// Check if a key exists
if (personAges.ContainsKey("Bob")) {
	System.Console.WriteLine("Bob is in the dictionary");
}

// Iterate over the dictionary
foreach (var pair in personAges) {
	System.Console.WriteLine($"Name: {pair.Key}, Age: {pair.Value}");
}

