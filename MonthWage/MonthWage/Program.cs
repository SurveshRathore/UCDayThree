// See https://aka.ms/new-console-template for more information
int IS_FULL_TIME = 1;
int RATE_PER_HOUR = 20;
int DAYS_IN_MONTH = 20;
int MonthlyWage = 0;
int hours;

Random random = new Random();

int result = random.Next(0, 2);

if (result == IS_FULL_TIME)
{
    Console.WriteLine("Full-time Employee.");
    hours = 8;
}
else
{
    Console.WriteLine("Part-time Employee.");
    hours = 4;
}

MonthlyWage = hours * RATE_PER_HOUR * DAYS_IN_MONTH;

Console.WriteLine("Employee Monthly Wage is: " + MonthlyWage);

