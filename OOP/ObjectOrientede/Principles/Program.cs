using System;
using System.Collections.Generic;

namespace Principles;

class Program
{
    static void Main(string[] args)
    {
        List<IPerson> persons = new()
        {
            new Person { FirstName = "John", LastName = "Doe" },
            new Manager { FirstName = "Kevin", LastName = "Zilas" },
            new Staff { FirstName = "Mathais", LastName = "Schal" }
        };

        List<IEmployee> employees = new();

        foreach (var person in persons)
        {
            employees.Add(new Employee().Create(person));
        }

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Username: {employee.userName} | Email: {employee.email}");
        }

        b b = new c();
        
        b.

    }
}

class a
{
    public string A { get; set; }
}

class b : a
{
    public string B { get; set; }
}

class c : b
{
    public string C { get; set; }
}


public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName  { get; set; }
}

class Staff : IPerson
{
    public string FirstName { get; set; }
    public string LastName  { get; set; }
}

class Manager : IPerson
{
    public string  FirstName { get; set; }
    public string  LastName  { get; set; }
    public IPerson Person    { get; set; }
}

public class Person : IPerson
{
    public string FirstName { get; set; }
    public string LastName  { get; set; }
}

public interface IEmployee
{
    string userName  { get; set; }
    string email     { get; set; }
    string FirstName { get; set; }
    string LastName  { get; set; }
    IEmployee Create(IPerson person);
}

public class Employee : Person, IEmployee
{
    public string userName { get; set; }
    public string email    { get; set; }

    public IEmployee Create(IPerson person)
    {
        Employee employee = new Employee()
        {
            userName = person.FirstName[..3] + person.LastName[1..],
            email = person.FirstName[..1] + person.LastName + "@dikson.com",
        };

        return employee;
    }
}