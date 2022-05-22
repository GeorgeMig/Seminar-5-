int [] nums = new int [123];
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 200);
    Console.Write(nums [i] + " ");
}

Console.WriteLine();

int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums [i] >= 10 && nums [i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"Количество чисел = {count}");
