using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

Action printMessage = () => WriteLine("Hello");
printMessage();

Action<string> greet = name => WriteLine($"Hello {name}!");
greet("World");

Func<int, int> square = n => n * n;
WriteLine(square(2));
WriteLine(square(10));

Func<double, double, double> areaOfRectangle = (l, b) => l * b;
WriteLine(areaOfRectangle(20, 4));


var list = new List<int>() { 1, 2, 3, 4, 5 };

list.ForEach(value => Write(value + " ")); // Action delegate as a parameter
WriteLine();

var squares = list.Select(n => n * n); // Func delegate as a parameter
WriteLine(string.Join(", ", squares));

var cubes = list.Select(n => n * n * n);
WriteLine(string.Join(", ", cubes));

var odds = list.Where(n => n % 2 == 1);
WriteLine(string.Join(", ", odds));

var evens = list.Where(n => n % 2 == 0); // Func delegate as a parameter
WriteLine(string.Join(", ", evens));

var sum = list.Aggregate((accumulator, n) => accumulator + n); // Func delegate as a parameter
WriteLine($"sum = {sum}");

var product = list.Aggregate((accumulator, n) => accumulator * n);
WriteLine($"product = {product}");