int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (n != 0)
{
    count += n % 10;
    n /= 10;
}
Console.WriteLine(count);
