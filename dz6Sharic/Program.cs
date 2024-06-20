using System;

public class Program
{
    public static void Main()
    {
        string str = "Alex";
        for (int i = 0; i < Factorial(str.Length); i++)
        {
            str = NextPermutation(str);
            Console.WriteLine(str + "\t|" + (i + 1));
        }
    }

    public static string NextPermutation(string str)
    {
        char[] chars = str.ToCharArray();
        int n = chars.Length;
        int i = n - 2;
        while (i >= 0 && chars[i] >= chars[i + 1])
        {
            i--;
        }
        if (i >= 0)
        {
            int j = n - 1;
            while (chars[j] <= chars[i])
            {
                j--;
            }
            Swap(chars, i, j);
        }
        Reverse(chars, i + 1, n - 1);
        return new string(chars);
    }

    private static void Swap(char[] chars, int i, int j)
    {
        char temp = chars[i];
        chars[i] = chars[j];
        chars[j] = temp;
    }

    private static void Reverse(char[] chars, int start, int end)
    {
        while (start < end)
        {
            Swap(chars, start, end);
            start++;
            end--;
        }
    }

    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
