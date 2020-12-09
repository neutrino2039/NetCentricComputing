using static System.Console;

var numbers = new List<int>();
numbers.Add(5);
numbers.Add(10);
numbers[1] = 20;
numbers.Add(50);

//WriteLine(numbers[1]);

for (int i = 0; i < numbers.Count; i++)
    WriteLine(numbers[i]);

var words = new List<string>();
words.Add("Hello");
words.Add("World");
words[0] = "Hello Again";

//WriteLine(words[0]);

for (int i = 0; i < words.Count; i++)
    WriteLine(words[i]);
