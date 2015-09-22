using System;
using System.Linq;

public class LargerThanNeighbours
{
    public static void Main()
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(element => int.Parse(element)).ToArray();
        Console.WriteLine(new string('-', 25));
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers,index));
        }
    }

    public static bool IsLargerThanNeighbours(int[] numbers, int index)
    {
        bool isLarger = false;

        if (index == 0)
        {
            if (numbers[index] > numbers[index + 1])
            {
                isLarger = true;
            }
        }
        else if (index == numbers.Length - 1)
        {
            if (numbers[index] > numbers[index - 1])
            {
                isLarger = true;
            }
        }
        else
        {
            if (numbers[index] > numbers[index + 1] && numbers[index] > numbers[index - 1])
            {
                isLarger = true;
            }
        }
        return isLarger;
    }
}