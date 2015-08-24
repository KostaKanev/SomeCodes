using System;
using System.Collections.Generic;
public class DecryptTheMessages
{
    public static void Main()
    {
        string command = Console.ReadLine();
        List<char> list = new List<char>();
        List<List<char>> allMessages = new List<List<char>>();

        while (command != "START" && command != "start")
        {
            command = Console.ReadLine();
        }
        while (command != "END" && command != "end")
        {
            command = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(command))
            {
                command = null;
                continue;
            }
            for (int i = 0; i < command.Length && command != "END" && command != "end"; i++)
            {
                if ((command[i] >= 'A' && command[i] <= 'M') ||
                    (command[i] >= 'a' && command[i] <= 'm'))
                {
                    list.Add((char)(command[i] + 13));
                }
                else if ((command[i] >= 'N' && command[i] <= 'Z') ||
                    (command[i] >= 'n' && command[i] <= 'z'))
                {
                    list.Add((char)(command[i] - 13));
                }
                else if (command[i] >= '0' && command[i] <= '9')
                {
                    list.Add((char)(command[i]));
                }
                else if (command[i] == '+')
                {
                    list.Add(' ');
                }
                else if (command[i] == '%')
                {
                    list.Add(',');
                }
                else if (command[i] == '&')
                {
                    list.Add('.');
                }
                else if (command[i] == '#')
                {
                    list.Add('?');
                }
                else if (command[i] == '$')
                {
                    list.Add('!');
                }
            }
            if (command != "END" && command != "end")
            {
                allMessages.Add(list);
                list = new List<char>();    
            }
        }
        if (allMessages.Count == 0)
        {
            Console.WriteLine("No message received.");
        }
        else
        {
            Console.WriteLine("Total number of messages: {0}" , allMessages.Count);
        }
        
        foreach (var message in allMessages)
        {
            char[] messages = message.ToArray();
            char[] reversedMessage = new char[messages.Length];

            for (int i = 0; i < messages.Length; i++)
            {
                reversedMessage[i] = messages[(messages.Length - 1) - i];
                Console.Write(reversedMessage[i]);
            }
            Console.WriteLine();
        }
    }
}
