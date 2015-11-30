using System;

public class Dog : Animal, ISoundProducible
{
    public Dog(int age)
        : this(null, age, '\0')
    {
    }

    public Dog(string name, int age, char gender) 
        : base(name, age, gender)
    {
    }

    public string ProduceSound()
    {
        return string.Format("Woof... woof");
    }
}