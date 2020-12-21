using System;
using static System.Console;

Action<string> greet = name => WriteLine($"Hello {name}!");

greet("Jane");
