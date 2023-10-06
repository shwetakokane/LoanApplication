using System;

namespace LoanApplication{
class Program{

public static void Main(){

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
         Console.WriteLine("Application rejected . Minimum loan amount to be sanctioned is 100000. ");
        
    }

    else if (loanAmount > 1000000)
    {
         Console.WriteLine("Application rejected . Maximum loan amount to be sanctioned is 1000000. ");
        
    }
    else if (duration < 1){
         
        Console.WriteLine("Application rejected. Minimum loan duration is 1 year.");
    }
    else if (duration > 10){
         
        Console.WriteLine("Application rejected. Maximum loan duration is 10 years.");
    }
    else{
        
        System.Console.WriteLine("Application accepted.");
    }

    }
    
    catch (FormatException)
    {
        System.Console.WriteLine("Please enter valid input.");
    }
}
}
}

