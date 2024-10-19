using System;

class TipCalculator {

static void Main() {

Console.Write("Enter the bill amount: ");

double billAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the tip percentage: ");

double tipPercentage = Convert.ToDouble(Console.ReadLine());

double tip = billAmount * (tipPercentage / 100);

Console.WriteLine($"The tip amount is: ${tip:F2}");

}

}