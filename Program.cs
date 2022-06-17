Console.WriteLine("Enter number you want to check for Perfect number");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int x = 1; x <= n/2; x++)
{
    if(n%x==0)
    {
        sum = sum + x;
    }
}
if(sum==n)
{
    Console.WriteLine("Perfect number");
}
else
{
    Console.WriteLine("Not a perfect number");
}
