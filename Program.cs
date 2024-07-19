using System;
using CurrencyCalculatorProject;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the amout for denomination : ");
        int amount = int.Parse(Console.ReadLine());
        CurrencyCalculator calculateCurrency = new CurrencyCalculator();
        calculateCurrency.Amount = amount;
        calculateCurrency.CountCurrency(calculateCurrency.Amount);
    }
}