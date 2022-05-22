int [] nums = new int [12];
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 10);
    Console.Write(nums [i] + " ");
}

Console.Write("Введите число => ");
int find = int.Parse(Console.ReadLine());
for (int i = 0; i < nums.Length; i++)
{
    if (nums [i] == find)
    {
        Console.Write("Да");
        break;
    }
    
}