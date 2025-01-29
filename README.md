Custom IEnumerable Implementation in C#

This project demonstrates how to implement a custom IEnumerable and IEnumerator in C#. The example includes a custom list (MyCustomList) that implements IEnumerable, and an iterator (SingleSearch) that implements IEnumerator.

Features

Implements a custom iterable collection.

Demonstrates the IEnumerable and IEnumerator interfaces.

Uses a simple integer array to showcase iteration.

Code Overview

The main components of this project are:

MyCustomList: Implements IEnumerable and returns an instance of SingleSearch.

SingleSearch: Implements IEnumerator to iterate over an integer array.

Program.cs: Demonstrates how to iterate over MyCustomList using foreach.

Usage

To run this project, simply compile and execute the C# code in a .NET environment.

Example Output

Hello, World!
1
2
3
4
5

How It Works

MyCustomList provides an enumerator (SingleSearch) when GetEnumerator() is called.

SingleSearch keeps track of the current index and provides iteration functionality.

The MoveNext() method moves through the elements, and Current returns the current element.

The Reset() method resets the iterator to its initial position.

Installation & Execution

Clone the repository:

git clone [https://github.com/your-username/your-repo.git](https://github.com/abolfazlshs80/Custom-IEnumerable-Implementation-in-C-)

Navigate to the project folder:

cd your-repo

Compile and run the C# program:

dotnet run

License

This project is licensed under the MIT License.

Contributing

Feel free to fork this repository and submit pull requests for improvements or additional features!

