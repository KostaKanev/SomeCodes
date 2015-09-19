using System;
using System.Collections.Generic;
using System.Linq;
public class LongestIncreasingSequence
{
    public static void Main() //Kosta.Kanev
    {
        //Using a few methods and lambda expression to convert input string to int array
        int[] numbers = Console.ReadLine().Split().Select(element => int.Parse(element)).ToArray();
        
        var sequences = new List<List<int>>();
        sequences.Add(new List<int>());
        int lastElement = 1;
        for (int index = 0, currentSequence = 0; index < numbers.Length; index++, lastElement++)
        {
            //Next two IFs - Check the last element whether can be added to the current sequence or need new collection for it
            if (lastElement == numbers.Length && numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
            {
                sequences[currentSequence].Add(numbers[lastElement - 1]);
                break;
            } 
            else if(lastElement == numbers.Length)
            {
                sequences.Add(new List<int>()); 
                currentSequence++;
                sequences[currentSequence].Add(numbers[index]);
                break;
            }
            
            //If element isn't the last, check element on position INDEX and INDEX + 1 for bigger
            if (numbers[index + 1] > numbers[index])
            {
                sequences[currentSequence].Add(numbers[index]);
            }
            //If element on position INDEX + 1 is smaller than element on INDEX, make new collection for a next sequence
            else
            {
                sequences[currentSequence].Add(numbers[index]);
                sequences.Add(new List<int>());
                currentSequence++;
            }
        }

        //Searching for biggest sequence
        var longestSequence = new List<int>();
        longestSequence = sequences[0];
        for (int i = 0; i < sequences.Count; i++)
        {
            //Remove sequence if count == 0 //BUG FIX :P
            if (sequences[i].Count == 0)
            {
                sequences.Remove(sequences[i]);
            }
            //Check longest sequence
            if (sequences[i].Count > longestSequence.Count)
            {
                longestSequence = sequences[i];
            }
        }
        //Print all sequences and Longest to last line
        for (int i = 0; i < sequences.Count; i++)
        {
            Console.WriteLine(string.Join(" ", sequences[i]));
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
    }
}
