using System;
using System.Collections.Generic;
using System.Linq;

public class MainProgram
{
    public static void Main()
    {

        //ProduceSound() test
        /*Kitten kitten = new Kitten("Kitten", 5);
        Console.WriteLine("{0} says {1}", kitten.Name, kitten.ProduceSound());
        
        Tomcat tom = new Tomcat("Tomcat",2);
        Console.WriteLine("{0} says {1}", tom.Name, tom.ProduceSound());
        
        Dog dogie = new Dog("Dogie", 5, 'm');
        Console.WriteLine("{0} says {1}", dogie.Name, dogie.ProduceSound());
        
        Frog frogie = new Frog("Frogie", 3, 'f');
        Console.WriteLine("{0} says {1}", frogie.Name, frogie.ProduceSound());
        */

        var animals = MakeListOfAnimals();
        var orderedAnimalsByAge = animals.OrderBy(animal => animal.Age);
        Console.WriteLine("Ordered animals by age");
        foreach (var item in orderedAnimalsByAge)
        {
            Console.WriteLine("Animal Type: {0} Age: {1}", item, item.Age);
        }
    }

    public static List<Animal> MakeListOfAnimals()
    {
        List<Animal> animals = new List<Animal>();
        Random rand = new Random();

        for (int i = 0; i < 15; i += 4)
        {
            int randomAge = rand.Next(1, 16);
            animals.Add(new Kitten(randomAge));

            randomAge = rand.Next(1, 16);
            animals.Add(new Tomcat(randomAge));

            randomAge = rand.Next(1, 16);
            animals.Add(new Dog(randomAge));

            randomAge = rand.Next(1, 16);
            animals.Add(new Frog(randomAge));
        }
        return animals;
    }
}