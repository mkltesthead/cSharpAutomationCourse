using System;

class variableScopeLineOfCreditCheck
{
    // Instance variables
    private int salary;
    private int creditScore;

    public void GetUserCreditInfo()
    {
        Console.WriteLine("Enter your salary:");
        salary = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your credit score:");
        creditScore = Convert.ToInt32(Console.ReadLine());
    }

    public void CheckQualification()
    {
        int requiredSalary = 25000;
        int requiredCreditScore = 700;

        if (salary > requiredSalary && creditScore >= requiredCreditScore)
        {
            Console.WriteLine("Congratulations! You are accepted.");
        }
        else
        {
            Console.WriteLine("Sorry, you are rejected.");
            Console.WriteLine($"The required credit score is {requiredCreditScore} and your credit score is {creditScore}");
            Console.WriteLine($"The required salary must be more than {requiredSalary} and your salary is {salary}");
        }
    }

    public static void Main(string[] args)
    {
        variableScopeLineOfCreditCheck app = new variableScopeLineOfCreditCheck();

        app.GetUserCreditInfo();
        app.CheckQualification();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}