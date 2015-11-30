using System;

public class Student : Human
{
    private int facultyNumber;

    public Student(int facultyNum) : this(null, null)
    {
        this.FacultyNumber = facultyNum;
    }
    
    public Student(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public int FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            if (value.ToString().Length > 10 || value.ToString().Length < 5)
            {
                throw new ArgumentOutOfRangeException("Faculty number lenght must be in range [5...10] characters");
            }

            this.facultyNumber = value;
        }
    }
}