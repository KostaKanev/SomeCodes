using System;

public abstract class Cat : Animal, ISoundProducible
{
    public Cat(string name, int age, char gender)
        : base(name, age, gender)
    {
    }

    public string ProduceSound()
    {
        return string.Format("Meow... ");
    }
}