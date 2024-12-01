// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

public class Contractor
{
    public string ContractorName { get; set; }
    public int ContractorNumber { get; set; }
    public DateTime StartDate { get; set; }

    public Contractor(string name, int number, DateTime startDate)
    {
        ContractorName = name;
        ContractorNumber = number;
        StartDate = startDate;
    }

    public string GetContractorName()
    {
        return ContractorName;
    }

    public void setContractorName(string name)
    {
        ContractorName = name;
    }

    public int GetContractorNumber()
    {
        return ContractorNumber;
    }

    public void SetContractorNumber (int number)
    {
        ContractorNumber = number;
    }

    public DateTime GetStartDate()
    {
        return StartDate;
    }

    public void SetStartDate(DateTime startDate)
    {
        StartDate = startDate;
    }
}



public class Subcontractor : Contractor
{
    public int Shift { get; set; }
    public double HourlyRate { get; set; }

    public Subcontractor(string name, int number, DateTime startDate, int shift, double hourlyRate) : base(name, number, startDate)
    {
        Shift = shift;
        HourlyRate = hourlyRate;
    }

    public int GetShift()
    {
        return Shift;
    }

    public void SetShift(int shift)
    {
        Shift = shift;
    }

    public double GetHourlyRate()
    {
        return HourlyRate;
    }
    public void SetHourlyRate(double hourlyRate)
    {
        HourlyRate = hourlyRate;
    }

    public double CalculatePay(int hoursWorked)
    {
        double pay = HourlyRate * hoursWorked;

        if (Shift == 2)
        {
            pay *= 1.03;
        }
        return  pay;
    }
}


class  Program
{
    static void Main()
    {
        List<Subcontractor> subcontractors = new List<Subcontractor>();
        string continueInput = "y";

        while (continueInput.ToLower() == "y")
        {
            Console.WriteLine("Enter Subcontrator Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Contractor Number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Start Date (YYYY-MM-DD):");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Shift (1 for Day, 2 for Night):");
            int shift = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Hourly Rate:");
            double hourlyRate = double.Parse(Console.ReadLine());

            Subcontractor subcontractor = new Subcontractor(name, number, startDate, shift, hourlyRate);

            subcontractors.Add(subcontractor);

            Console.WriteLine("Do you want to enter another subcontractor? (y/n):");
            continueInput = Console.ReadLine();
        }

        foreach (var sub in subcontractors)
        {
            Console.WriteLine($"Contractor Name: {sub.ContractorName}, Shift: {(sub.Shift == 1 ? "Day" : "Night")}, Hourly Rate: {sub.HourlyRate}");
            Console.WriteLine("Enter hours worked for pay calculation:");
            int hoursworked = int.Parse(Console.ReadLine());

            double pay = sub.CalculatePay(hoursworked);
            Console.WriteLine($"Pay for {sub.ContractorName}: ${pay:F2}");
        }
    }
}