using System;


public class MainClass
{
    static void Main()
    {
        Console.Write("Введите количество работников: ");
        Employee[] worker = new Employee[int.Parse(Console.ReadLine())];

        for (int i = 0; i < worker.Length; ++i)
        {
            worker[i] = new Employee(); 
            Console.Write("Введите ФИО сотрудника: ");
            worker[i].EmployeeName = Console.ReadLine();
            Console.Write("Введите з/п сотрудника: ");
            worker[i].Salary = double.Parse(Console.ReadLine());
            Console.Write("Введите сумму вычета за ребенка: ");
            worker[i].ChildDeduction = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
        }

        for (int i = 0; i < worker.Length; i++)
        {
            worker[i].PrintResult();
        }
        Console.ReadKey();


       
    }
}