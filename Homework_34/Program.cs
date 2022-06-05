//ПРОГРАММА, ПОЗВОЛЯЮЩАЯ ОПРЕДЕЛИТЬ КОЛИЧЕСТВО ЧЕТНЫХ ЧИСЕЛ В МАССИВЕ

int [] nums = new int [12];
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(1, 100);
    Console.Write(nums [i] + " ");
}
int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 == 0) 
    {
        count++;
    }
}

Console.WriteLine ($"Количество четных чисел в массиве = {count}");


