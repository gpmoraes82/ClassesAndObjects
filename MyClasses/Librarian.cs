namespace ClassesAndObjects;

public class Librarian : Employee
{
    private string? _employeeId;

    public string EmployeeId
    {
        get { return _employeeId; }
        set
        {
            _employeeId = (value != null) ? value : null;
        }
    }

    public override string Permition
    {
        get { return "0101"; }
    }

    internal Librarian(string name, int age, string employeeId) : base(name, age)
    {
        EmployeeId = employeeId;
    }


}
