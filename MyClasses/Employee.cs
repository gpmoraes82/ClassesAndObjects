namespace ClassesAndObjects;

public class Employee
{

    private int _age;
    private string? _name;
    internal string? _permition;

    public int Age
    {
        get { return _age; }
        set
        {
            _age = (value > 0) ? value : -1;
        }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            _name = (value != null) ? value : "N/A";
        }
    }

    public virtual string Permition
    {
        get { return _permition; }
        set
        {
            _permition = "0000"; // 0000 -> no permit
        }
    }

    protected Employee(string? name, int age)
    {
        Name = name;
        Age = age;
    }

}
