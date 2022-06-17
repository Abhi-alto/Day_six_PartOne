Console.WriteLine("Enter a positive number ");
int n = Convert.ToInt32(Console.ReadLine());
int rev = 0;
int num = n;
while(num!=0)
{
    rev = (rev * 10) + (num%10);
    num = num / 10;
}
Console.WriteLine("Reverse of " + n + " = " + rev);