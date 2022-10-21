using System;


public class MainClass
{
    static void Main()
    {

        Employee firstEmployee = new Employee();
        Console.Write("Введите ФИО сотрудника: ");
        firstEmployee.EmployeeName = Console.ReadLine();
        Console.Write("Введите з/п сотрудника: ");
        firstEmployee.Salary = double.Parse(Console.ReadLine());
        Console.Write("Введите сумму вычета за ребенка: ");
        firstEmployee.ChildDeduction = double.Parse(Console.ReadLine());
        
        firstEmployee.PrintResult();



    }
}