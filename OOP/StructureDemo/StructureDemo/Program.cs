using static System.Console;

var p1 = new PointClass(1, 2);
WriteLine($"p1 = {p1}");

var p2 = p1;
WriteLine($"p2 = {p2}");

WriteLine();

p1.x = 5;
WriteLine($"p1 = {p1}");
WriteLine($"p2 = {p2}");

WriteLine();

var p3 = new PointStruct(1, 2);
WriteLine($"p3 = {p3}");

var p4 = p3;
WriteLine($"p4 = {p4}");

WriteLine();

p3.x = 5;
WriteLine($"p3 = {p3}");
WriteLine($"p4 = {p4}");