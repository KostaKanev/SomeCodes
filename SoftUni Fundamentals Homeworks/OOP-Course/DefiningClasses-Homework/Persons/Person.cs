using System;

public class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age) : this(name, age, null)
    {
    }

    public Person(string name, int age,string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Can't accept NULL or EMPTY name");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("The Age must be in range from 1 to 100");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            if (!value.Contains("@") || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid Email Address");
            }
            else
            {
                this.email = value;
            }
        }
    }
    
    public override string ToString()
    {
        return String.Format("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
    }
}