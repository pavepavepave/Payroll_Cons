using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Employee
{
    public string EmployeeName { get; set; } //имя работника
    private const double MinimumWage = 13890; //мрот
    public double Salary { get; set; } // зарплата
    public double ChildDeduction { get; set; } //вычет за ребенка
    private double TaxesSum = 0;

    public void Taxes (double Salary,  double ChildDeduction) //налог
    {
        TaxesSum = Math.Round(((Salary - ChildDeduction) * 13 / 100),0);
    } 

   public void PrintResult()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;   
        Console.WriteLine(($"Работник: {EmployeeName}"));
        Console.WriteLine($"Сумма налога к удержанию: {TaxesSum}");
        Console.WriteLine($"Денежная выплата работнику:" + (Salary - TaxesSum));
        Console.WriteLine("ОПС: ...");
        Console.WriteLine("ОМС: ...");
        Console.WriteLine("ВНиМ: ...");
        Console.WriteLine("ФССС: ...");
    }







}

