public class Employee : Person, IPrintable
{
    public string EmployeeId { get; set; }
    public List<Address> Addresses = new List<Address>();
    public Employee()
    {
    }
    public Employee(string name, string employeeId) : base(name)
    {
        this.EmployeeId = employeeId;
    }
    

   public new string GetPrintString()
{
  return @$"{this.Name} ({this.EmployeeId})
{this.Address.Street} {this.Address.StreetNo}
{this.Address.City}"!;
}
}