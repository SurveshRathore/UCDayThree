// See https://aka.ms/new-console-template for more information
int IS_FULL_TIME = 1;
int RATE_PER_HOUR = 20;
int hours = 0;
int dailyWage = 0;


Random random = new Random();
int result = random.Next(0, 2);

switch (result)
{
    case 1:
        hours = 8;
        break;
    default:    
        hours = 4;
        break;
}



dailyWage = hours * RATE_PER_HOUR;

Console.WriteLine("Employee Daily Wage is: " + dailyWage);

