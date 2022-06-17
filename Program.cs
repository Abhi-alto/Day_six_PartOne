Console.WriteLine("Enter how many fibonacci numbers you want");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
Console.WriteLine(a);
Console.WriteLine(b);
for (int x = 1; x <= n - 2; x++)
{
    int sum = a + b;
    a = b;
    b = sum;
    Console.WriteLine(sum);
}

