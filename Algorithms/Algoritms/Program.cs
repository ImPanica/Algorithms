namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Бинарный поиск
            List<int> numbers = Enumerable.Range(1, 100).ToList();
            numbers.Sort();

            Console.WriteLine($"{Binary.Binary.BinarySearchToInt(numbers, 5)}");
            Console.WriteLine($"{Binary.Binary.BinarySearchToInt(numbers, 500)}");
            Console.WriteLine($"{Binary.Binary.BinarySearchToInt(numbers, 77)}");
            Console.WriteLine($"{Binary.Binary.BinarySearchToInt(numbers, 99)}");

            List<string> sortedList = new List<string> { "apple", "banana", "cherry", "date", "fig", "grape" };
            Console.WriteLine($"Position found word: {Binary.Binary.BinarySearchToString(sortedList, "fig")}");
            Console.WriteLine($"Position found word: {Binary.Binary.BinarySearchToString(sortedList, "grape")}");
            Console.WriteLine($"Position found word: {Binary.Binary.BinarySearchToString(sortedList, "banana")}");
        }
    }
}