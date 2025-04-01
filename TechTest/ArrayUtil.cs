namespace TechTest;

public abstract class ArrayUtil
{
    public static int FindMissingNumber(int[] numberArray)
    {
        for (int i = 0; i < numberArray.Length; i++)
        {
            if (!numberArray.Contains(i))
            {
                return i;
            }
        }
        return numberArray.Length;
    }
}