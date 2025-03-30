namespace TechTest;

public class Solution
{
    public static int FindMissingNumbers(int[] numberArray)
    {
        for (int i = 0; i < numberArray.Length; i++)
        {
            if (!numberArray.Contains(i))
            {
                return i;
            }
        }
        return -1;
    }
}