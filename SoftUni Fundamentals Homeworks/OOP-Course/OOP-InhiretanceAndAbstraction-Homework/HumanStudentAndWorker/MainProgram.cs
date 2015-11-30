using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainProgram
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Worker> workers = new List<Worker>();
        Random rand = new Random();

        //Randomize faculty number and salary
        for (int i = 0; i < 10; i++)
        {
            int randomFacNum = rand.Next(10000, 1000000000);
            students.Add(new Student(randomFacNum));
            
            int randSalary = rand.Next(1000, 2000);
            workers.Add(new Worker(randSalary, 10));
        }

        //Order students and workers by faculty numbers and salaries
        var orderedStudents = students.OrderBy(student => student.FacultyNumber);
        var orderedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());

        Console.WriteLine("Ordered students by faculty number.");
        foreach (var item in orderedStudents)
        {
            Console.WriteLine("Faculty number: {0}", item.FacultyNumber);
        }
        Console.WriteLine("\nDescending ordered workers by money per hour.");
        foreach (var item in orderedWorkers)
        {
            Console.WriteLine("Money per hour: {0:F2}", item.MoneyPerHour());
        }
    }
}