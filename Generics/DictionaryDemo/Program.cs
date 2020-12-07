using static System.Console;
using System.Collections.Generic;

var openWith = new Dictionary<string, string>();

openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith["rtf"] = "wordpad.exe"; // indexer syntax

if(openWith.ContainsKey("txt"))
    WriteLine(openWith["txt"]); // indexer syntax

// foreach(var key in openWith.Keys)
//     WriteLine($"{key} opens with {openWith[key]}");
