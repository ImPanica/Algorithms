using Algorithms.Sort;

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

            // Сортировка выбором
            int[] arrayInt = new[] { -5, 12, 0, 19, 150, 99999, 3, -323 };
            int[] arrayInt2 = new[] { 35, 102, -50, -19, 10, 33, 75, 0 };
            int[] sortArray = Selection.SelectionSort(arrayInt, true);
            int[] sortArray2 = Selection.SelectionSort(arrayInt2);
            foreach (var i in sortArray)
            {
                Console.Write($"{i}\t");
            }

            Console.WriteLine();
            foreach (var i in sortArray2)
            {
                Console.Write($"{i}\t");
            }

            //
        }
    }
}