# Custom IEnumerable Implementation in C#

This project demonstrates how to implement a custom `IEnumerable` and `IEnumerator` in C#.

## Features
- Implements a custom iterable collection.
- Demonstrates the `IEnumerable` and `IEnumerator` interfaces.
- Uses a simple integer array to showcase iteration.

## Code Overview
The main components of this project are:
- `MyCustomList`: Implements `IEnumerable` and returns an instance of `SingleSearch`.
- `SingleSearch`: Implements `IEnumerator` to iterate over an integer array.
- `Program.cs`: Demonstrates how to iterate over `MyCustomList` using a loop.

## Source Code
```
MyCustomList mylist = new MyCustomList();
var list = mylist.GetEnumerator();
while (list.MoveNext())
{
    int a =(int) list.Current;
    Console.WriteLine(a);
}
