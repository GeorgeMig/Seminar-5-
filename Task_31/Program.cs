
int [] nums = new int [12];
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(-9, 10);
    Console.Write(nums [i] + " ");
}

int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < nums.Length; i++)
{
    if(nums[i] <0) sumNegative += nums [i];
    else sumPositive += nums [i];
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных = {sumPositive}");
Console.WriteLine($"Сумма отрицательных = {sumNegative}");