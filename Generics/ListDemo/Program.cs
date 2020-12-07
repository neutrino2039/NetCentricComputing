using static System.Console;
using System.Collections.Generic;

var list = new List<int>();
list.Add(5); // 5
list.AddRange(new[] {10, 2, 3, 4}); // 5, 10, 2, 3, 4
list.Remove(3); // 5, 10, 2, 4
list.Insert(1, 15); // 5, 15, 10, 2, 4

list[2] = 20; // 5, 15, 20, 2, 4

WriteLine($"first item = {list[0]} \n");
WriteLine($"item count = {list.Count} \n");

foreach(var item in list)
    WriteLine(item);
