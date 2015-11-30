using System;

public class Frog : Animal, ISoundProducible
{
    public Frog(int age)
        : this(null, age, '\0')
    {
    }

    public Frog(string name, int age, char gender) 
        : base(name, age, gender)
    {
    }

    public string ProduceSound()
    {
        return string.Format("Gribbit... gribbit");
    }
}