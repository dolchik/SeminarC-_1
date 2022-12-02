// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = 0;

if (number1 > 0)
{
    number2 = number1 * -1;
    while (number2 <= number1)
    {
        Console.Write($"{number2}, ");
        number2++;
    }
}
else 
{
    number2 = number1 * -1;
    while (number1 <= number2)
    {
        Console.Write($"{number1}, ");
        number1++;
    }
}

