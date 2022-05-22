int [] nums = new int [12];
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(-9, 10);
    Console.Write(nums [i] + " ");
}

Console.WriteLine();
for (int i = 0; i < nums.Length; i++)
{
    nums [i] = nums [i] * - 1;
    Console.Write (nums [i] + " ");
}
