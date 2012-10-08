Provides simple-to-use Every<T> and ForEvery<T> extension methods in C#.

var data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
data.Every(3); // 3, 6, 9
data.ForEvery(3, x => Console.WriteLine(x)); // writes 3, 6, 9 to the console