/*string s = Console.ReadLine();
Console.WriteLine(s);
Stack<int> stuck = new Stack<int>();
stuck.Push(10);
stuck.Push(20);
stuck.Push(30);
stuck.Push(69);
stuck.Push(100);

foreach(int i in stuck)
{
    Console.WriteLine(i);
}*/
using System.Collections.Generic;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Hourly("Chalar", 4));
        employees.Add(new Monthly("Cabints", "21-1-haha"));

        foreach (Employee e in employees) 
        {
            Console.WriteLine(e);
        }
    }
}

class Employee
{
    public int Salary { get; set; }
    public string Name { get; set; }

    /// <summary>
    /// Employee Constructor
    /// </summary>
    /// <param name="name">The name of the Employee.</param>
    public Employee(string name) 
    {
        this.Name = name;
        this.Salary = 0;
    }

    public override string ToString()
    {
        return this.Name + " " + this.Salary;
    }
}

class Hourly : Employee
{
    public int HoursWorked { get; set; }

    /// <summary>
    /// Sample
    /// </summary>
    /// <param name="name">xxx</param>
    /// <param name="hoursWorked">yyyy</param>
    public Hourly(string name, int hoursWorked) : base("Hourly - " + name) 
    {
        this.HoursWorked = hoursWorked;
    } 
}

class Monthly : Employee
{
    public string ID { get; set; }

    public Monthly(string name, string id) : base(id +" - "+ name) 
    {
        this.ID = id;
    }
}