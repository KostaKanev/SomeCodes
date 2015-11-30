using System;

public class Kitten : Cat
{
    public Kitten(int age)
         : this(null, age)
    {
    }
    public Kitten(string name, int age)
        : base(name,age, 'f')
    {
    }
}
