int n = new Random().Next(3, 1001);
int[] arr = new int[n];
for ( int i = 0; i < n; i++)  arr[i] = new Random().Next(1,1001);
int sum = 0;
int max = 0;
for (int count = 1; count < n-1; count++) 
{
    sum = arr[count-1]+arr[count]+arr[count+1];
    if (sum > max) max = sum; 
}
Console.WriteLine(max);