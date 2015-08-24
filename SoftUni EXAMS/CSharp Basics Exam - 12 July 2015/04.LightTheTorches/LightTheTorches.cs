using System;
using System.Text;

public class LightTheTorches
{
    public static void Main()
    {
        int roomsCount = int.Parse(Console.ReadLine());

        string text = Console.ReadLine();
        char[] basement = new char[roomsCount];

        for (int room = 0, roomIndex = 0 ; room < basement.Length; room++)
        {
            basement[room] = text[roomIndex];
            if (roomIndex == text.Length - 1)
            {
                roomIndex = 0;
            }
            else
            {
                roomIndex++;
            }
        }
        string[] command = Console.ReadLine().Split(' ');

        int initialPosition = roomsCount / 2;
        int currentPos = initialPosition;
        int pos = currentPos;
        while (command[0] != "END")
        {
            if (command[0] == "RIGHT")
            {
                for (int i = int.Parse(command[1]); i >= 0; i--)
                {
                    if (currentPos == roomsCount - 1)
                    {
                        currentPos = -1;
                    }
                    currentPos++;
                    pos = currentPos;
                }
                if (basement[pos] == 'L')
                {
                    basement[pos] = 'D';
                }
                else
                {
                    basement[pos] = 'L';
                }
            }
            else if (command[0] == "LEFT")
            {
                for (int i = int.Parse(command[1]); i >= 0; i--)
                {
                    
                    if (currentPos % roomsCount <= 0)
                    {
                        currentPos = roomsCount;
                    }
                    currentPos--;
                    pos = currentPos;
                }
                if (basement[pos] == 'L')
                {
                    basement[pos] = 'D';
                }
                else
                {
                    basement[pos] = 'L';
                }
            }
            
            command = Console.ReadLine().Split(' ');
        }
        int countOfDarkRooms = 0;
        for (int i = 0; i < basement.Length; i++)
        {
            if (basement[i] == 'D')
            {
                countOfDarkRooms++;
            }
        }

        Console.WriteLine(countOfDarkRooms * 'D');
    }
}