using static System.Console;
using System.Collections.Generic;

var stack = new Stack<char>();

string text = "hello world";

foreach(var character in text)
    stack.Push(character);

while(stack.Count > 0)
    Write(stack.Pop());

WriteLine();

