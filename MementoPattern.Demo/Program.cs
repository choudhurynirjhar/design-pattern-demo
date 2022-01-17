using MementoPattern.Demo;

var employee = new Employee { Id =1, Name = "Employee", Age = 25, Phone = "123" };
var employeeManager = new EmployeeManager();

employeeManager.AddMemento(1,employee.Create());

Console.WriteLine($"Initial State: {employee.Name}, {employee.Age}, {employee.Phone}");

employee.Phone = "34567";
employeeManager.AddMemento(1, employee.Create());
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");

employee.Age = 35;
employeeManager.AddMemento(1, employee.Create());
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");

employee.Undo(employeeManager.GetMemento(1));
employee.Undo(employeeManager.GetMemento(1));
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");

employee.Undo(employeeManager.GetMemento(1));
Console.WriteLine($"{employee.Name}, {employee.Age}, {employee.Phone}");