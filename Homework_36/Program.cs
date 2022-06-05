//ПРОГРАММА, ПОЗВОЛЯЮЩАЯ ОПРЕДЕЛИТЬ СУММУ ЧИСЕЛ, СТОЯЩИХ НА НЕЧЕТНЫХ ПОЗИЦИЯХ В МАССИВЕ

int [] nums = new int [12];
int sum = 0;
Random numRnd = new Random ();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(1, 100);
    Console.Write(nums [i] + " ");
    if (i % 2 == 0)
    {
        sum = sum + nums[i];
    }
}

Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции = {sum}");