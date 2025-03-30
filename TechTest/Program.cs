namespace TechTest;

class Program
{
    static void Main(string[] args)
    {
        int[] example1 = new int[] {3, 0, 1};
        int[] example2 = new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1};

        int result1 = Solution.FindMissingNumbers(example1);
        int result2 = Solution.FindMissingNumbers(example2);

        Console.WriteLine($"example 1 excepted answer: 2, actual answer: {result1}");
        Console.WriteLine($"example 2 excepted answer: 8, actual answer: {result2}");
    }
}