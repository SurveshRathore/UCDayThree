// See https://aka.ms/new-console-template for more information
int IS_FULL_TIME = 1;
int RATE_PER_HOUR = 20;
int DailyWage = 0;
int hours;

Random random = new Random();

int result = random.Next(0, 2);

if (result == IS_FULL_TIME)
{
    hours = 8;
}
else
{
    hours = 0;
}

DailyWage = hours * RATE_PER_HOUR;

Console.WriteLine("Employee Daily Wage is: " + DailyWage);

