//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.Clear();

Console.Write("Введите число от 1 до 7: ");
int NumDay = int.Parse(Console.ReadLine());

if (NumDay == 1)
{
    Console.WriteLine("Понедельник");
}
if (NumDay == 2)
{
    Console.WriteLine("Вторник");
}
if (NumDay == 3)
{
    Console.WriteLine("Среда");
}
if (NumDay == 4)
{
    Console.WriteLine("Четверг");
}
if (NumDay == 5)
{
    Console.WriteLine("Пятница");
}
if (NumDay == 6)
{
    Console.WriteLine("Суббота");
}
if (NumDay == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Неверно");
}