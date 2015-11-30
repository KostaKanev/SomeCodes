public abstract class Person : IPerson
{
    private int id;
    private string firstName;
    private string lastName;

    public Person(int id, string firstName, string lastName)
    {
        this.ID = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}