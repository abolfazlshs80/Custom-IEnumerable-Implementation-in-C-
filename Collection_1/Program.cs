// See https://aka.ms/new-console-template for more information

using System.Collections;

Console.WriteLine("Hello, World!");
MyCustomList mylist = new MyCustomList();
var list = mylist.GetEnumerator();
while (list.MoveNext())
{
    int a =(int) list.Current;
    Console.WriteLine(a);
}






public class MyCustomList : IEnumerable
{

    public IEnumerator GetEnumerator()
    {
        return new SingleSearch(new int[] { 1, 2, 3, 4, 5 });
    }
}

public class SingleSearch : IEnumerator
{
    public int[] numbers;
    private int index = -1;

    public SingleSearch(int[] numbers)
    {
        this.numbers = numbers;
    }
    public bool MoveNext()
    {
        if (index==numbers.Length-1)
        {
            return false;
        }
        else
        {
            index++;
            return true;
        }
    }

    public void Reset()
    {
       index= -1;
    }

    public object Current
    {
        get { return numbers[index]; }
    }
}
