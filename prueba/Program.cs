using System.Collections.Generic;
using System.Runtime.ExceptionServices;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew NOW!");
    
}
else if(daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.\nRenew now and save 10%!");
    discountPercentage = 10;
}
else if(daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
    discountPercentage = 20;

}
else if(daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{
     Console.WriteLine();
}

// Your code goes here