using System;
public delegate bool ComparisonHandler(int first, int second);
class DelegateSample
{
    public static void BubbleSort(int[] items, ComparisonHandler comparisonMethod)
    {
        int i;
        int j;
        int temp;

        if (items == null)
        {
            return;
        }

        if (comparisonMethod == null)
        {
            throw new ArgumentNullException("comparisonMethod");
        }

        for (i = items.Length - 1; i >= 0; i--)
        {
            for (j = 1; j <= i; j++)
            {
                if (comparisonMethod(items[j - 1], items[j]))
                {
                    temp = items[j - 1];
                    items[j - 1] = items[j];
                    items[j] = temp;
                }
            }
        }
    }

    public static bool GreaterThan(int first, int second)
    {
        return first > second;
    }

    public static bool AlphabeticalGreaterThan(int first, int second)
    {
        int comparison;
        comparison = (first.ToString().CompareTo(second.ToString()));
        return comparison > 0;
    }

    public static void Main()
    {
        
        int[] items = new int[5];

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine("enter an integer:");
            items[i] = int.Parse(Console.ReadLine());
        }

        //BubbleSort(items,GreaterThan);
        BubbleSort(items, AlphabeticalGreaterThan);
        Console.WriteLine("result:");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
        Console.ReadKey();
    }
}