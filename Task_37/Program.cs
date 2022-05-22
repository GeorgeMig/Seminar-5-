int [] nums = new int [123];
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 200);
    Console.Write(nums [i] + " ");
}

Console.WriteLine();


void MultiArray (int [] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] * num.Length - 1 - i;
    }
    
}