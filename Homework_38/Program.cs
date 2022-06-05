

int [] nums = new int [12];
int max = 0;
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(1, 100);
    Console.Write(nums [i] + " ");
    if (nums [i] > max)
    {
        max = nums [i];
    }
}
int min = max;
for (int i = 0; i < nums.Length; i++)
{
    if (nums [i] < min)
    {
        min = nums [i];
    }
}
Console.WriteLine();
Console.WriteLine($"Максимальный элемент = {max}, Минимальный элемент ={min}");
Console.WriteLine($"Разница между ними = {max - min}");
