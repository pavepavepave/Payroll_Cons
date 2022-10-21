using System;


public class MainClass
{
    static void Main()
    {
        Console.Write("Введите количество работников: ");
        Employee[] worker = new Employee[int.Parse(Console.ReadLine())];

        for (int i = 0; i < worker.Length; ++i)
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
        Console.ReadKey();








      



    }
}