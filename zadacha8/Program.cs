// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число больше 0");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;

while (index <= number)
{
    if (index % 2 == 0)
    {
        Console.Write(index + " ");
    }
    index++;
}
if (number == 1)
    Console.WriteLine("Нет четных чисел");
else if (number <= 0)
    Console.WriteLine("Число не соответствует условию");