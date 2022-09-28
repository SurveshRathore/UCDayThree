// See https://aka.ms/new-console-template for more information
int IS_FULL_TIME = 1;
int RATE_PER_HOUR = 20;
int DAYS_IN_MONTH = 20;
int MonthlyWage = 0;
int TOTAL_HOURS = 100;
int hours = 0;
int days = 0;

Random random = new Random();

while (hours <= TOTAL_HOURS || days <= DAYS_IN_MONTH)
{
    int result = random.Next(0, 2);
    if (result == IS_FULL_TIME)
    {
        hours += 8;
        days++;
    }
    else
    {
        hours += 4;
        days++;
    }

}

MonthlyWage = hours * RATE_PER_HOUR;

Console.WriteLine("Employee Monthly Wage is: " + MonthlyWage);

