using System;
using System.Collections.Generic;

string[] a = { "jakarta", "manila", "bangkok" };
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
}

Console.WriteLine("---------------");

List<string> b = new List<string>();
b.Add("a");
b.Add("b");
b.Add("c");
b.Remove("b");
for (int i = 0; i < b.Count; i++)
{
    Console.WriteLine(b[i]);
}

Console.WriteLine("---------------");

int[] c = new int[] { 5, 3, 2, 8, 11, -2 };
for (int i = 0; i < c.Length; i++)
{
    Console.WriteLine(c[i]);
}

Console.WriteLine("hello world");
Console.WriteLine("hello world");
