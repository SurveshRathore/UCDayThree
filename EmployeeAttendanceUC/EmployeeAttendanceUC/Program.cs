// See https://aka.ms/new-console-template for more information
int IS_FULL_TIME = 1;

Random random = new Random();

int result = random.Next(0, 2);

if (result == IS_FULL_TIME)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}

