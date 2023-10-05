using System;
namespace LoanApplication{
class Program{

public static void Main(string[] args){

    try
    {
  
    Console.WriteLine("Enter the expected loan amount:");
    double loanAmount = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your Annual income:");
    double annualIncome = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the loan duration:");
    double duration = Convert.ToInt32(Console.ReadLine());

    
    
    if (annualIncome < 200000)
    {
        Console.WriteLine("Application rejected. Insufficient annual income.");
    }
    else if (loanAmount < 100000)
    {
        Console.WriteLine("Application rejected. Expected loan amount is below the crieteria.");
    }
    else if (loanAmount > 200000)
    {
        Console.WriteLine("Application rejected. Expected loan amount is above the crieteria.");
    }
    else if (duration > 10)
    {
        Console.WriteLine("Application rejected. The loan duration should be less than 10 years.");
    }
    else
    {
        System.Console.WriteLine("Application accepted.");
    }
    }

     catch(FormatException)
    {
        System.Console.WriteLine("Error : Non-numeric value entered.");
    } 
   

   
}
    
}
}