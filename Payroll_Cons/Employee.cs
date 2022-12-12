using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Employee
{
    public string EmployeeName { get; set; } //имя работника
    const double MinimumWage = 13890; //мрот
    public double Salary { get; set; } // зарплата
    public double ChildDeduction { get; set; } //вычет за ребенка
    private double TaxesSum = 0; //налог
    private double EmployeePayment = 0; //зп на руки
    private double PensionInsurance = 0; //опс
    private double MedicalInsurance = 0; //омс
    private double DisabilityContribution = 0; //вним
    private double SocialInsurance = 0; //ФСС

    public void Taxes (double Salary,  double ChildDeduction) //налог и сумма выплаты зп на руки
    {
        TaxesSum = Math.Round(((Salary - ChildDeduction) * 13 / 100),0);
        EmployeePayment = Salary - TaxesSum;
    } 

    public void Pension(double Salary, double MinimumWage) //опс
    {
        if (Salary <= MinimumWage && Salary >= 0)
            PensionInsurance = Math.Round((Salary * 22 / 100),2);
        else if (Salary > MinimumWage)
            PensionInsurance = Math.Round((MinimumWage * 22 / 100 + (Salary - MinimumWage) * 10 / 100),2);
        else
            Console.WriteLine("Ошибка");
    }

    public void Medical(double Salary, double MinimumWage) //омс
    {
        if (Salary <= MinimumWage && Salary >= 0)
            MedicalInsurance = Salary * 5.1 / 100;
        else if (Salary > MinimumWage)
            MedicalInsurance = MinimumWage * 5.1 / 100 + (Salary - MinimumWage) * 5 / 100;
        else
            Console.WriteLine("Ошибка");
    }

    public void Disability(double Salary, double MinimumWage) //вниим
    {
        if (Salary >= MinimumWage)
            DisabilityContribution = Math.Round((2.9 / 100 * MinimumWage),2);
        else if (Salary <= MinimumWage)
            DisabilityContribution = Math.Round((2.9 / 100 * Salary),2);
        else
            Console.WriteLine("Ошибка");
    }

    public void Social(double Salary) => SocialInsurance = Math.Round((Salary * 0.002), 2);  //фсс
    
    public void PrintResult()
    {
        Taxes(Salary, ChildDeduction);
        Pension(Salary, Employee.MinimumWage);
        Medical(Salary, Employee.MinimumWage);
        Disability(Salary, Employee.MinimumWage);
        Social(Salary);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(($"Работник: {EmployeeName}"));
        Console.WriteLine(($"Зарплата: {Salary}"));
        Console.WriteLine($"Сумма налога к удержанию: {TaxesSum}");
        Console.WriteLine($"Денежная выплата работнику: {EmployeePayment}");
        Console.WriteLine($"ОПС: {PensionInsurance}");
        Console.WriteLine($"ОМС: {MedicalInsurance}");
        Console.WriteLine($"Взнос по ВНиМ: {DisabilityContribution}");
        Console.WriteLine($"ФСС: {SocialInsurance}");
        Console.WriteLine("-------------------------------------------------------------");
        Console.ResetColor();
    } //выводим результат







}

