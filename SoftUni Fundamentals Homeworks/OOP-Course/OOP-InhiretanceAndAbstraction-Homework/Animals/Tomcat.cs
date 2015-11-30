using System;

public class Tomcat : Cat
{
    public Tomcat(int age)
        : this(null, age)
    {
    }

    public Tomcat(string name, int age) 
        : base(name, age, 'm')
    {
    }
}