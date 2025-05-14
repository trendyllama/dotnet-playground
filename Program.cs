// See https://aka.ms/new-console-template for more information

class Program
{
    static void LinqExample()
    {

        List<int> numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        IEnumerable<string> evens = from number in numbers
                                 where number > 5 && number % 2 == 0
                                 orderby number descending
                                 select $"{number}";

        foreach (string even in evens)
        {
            Console.WriteLine(even);
        }
    }
    static void Main(string[] args)
    {
        LinqExample();
    }
}