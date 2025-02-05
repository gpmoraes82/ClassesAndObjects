namespace ClassesAndObjects;

public class Employee
{

    private int _age;
    private string? _name;

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
    
    protected Employee(string? name, int age){
        Name = name;
        Age = age;
    }
    
}
