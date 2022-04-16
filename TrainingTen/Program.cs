using System;
using System.Globalization;
using TrainingTen.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i =0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (c/i): ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(answer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new CompanyPayer(name, anualIncome, numberEmployees));
                }
            }

            double Totaltaxes = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Payer payer in list)                
            {
                double taxes = payer.Taxes();
                Console.WriteLine(payer.Name + ": $" + taxes.ToString("F2", CultureInfo.InvariantCulture));

                Totaltaxes = taxes;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + Totaltaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}