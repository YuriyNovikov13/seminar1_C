// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("выведение чётных чисел от 1 до N");
Console.Write("Введите число N: ");
int max = Convert.ToInt32(Console.ReadLine());
int num = 1;
while (num <= max)
{
    if (num % 2 == 0)
        Console.Write($"{num}; ");
    num = num + 1;
}
