Console.WriteLine("Enter a number you want to check for Perfect number");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);                //If user enter negative numbers
int c = 0;                      //counter to count factors
if (n != 0 && n != 1)
{
    for (int x = 2; x <= n / 2; x++)
    {
        if (n % x == 0)
        {
            c++;
            break;
        }
    }
    if (c == 0)
    {
        Console.WriteLine("Prime number");
    }
    else
    {
        Console.WriteLine("Not a prime number");
    }
}
else
{
    Console.WriteLine("Neither prime nor composite");
}