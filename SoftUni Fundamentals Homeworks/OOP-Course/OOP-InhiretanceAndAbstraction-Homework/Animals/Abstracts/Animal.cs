using System;

public abstract class Animal
{
    private string name;
    private int age;
    private char gender;
    
    public Animal(string name,int age,char gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public char Gender
    {
        get { return this.gender; }
        set { this.gender = value; }
    }
}