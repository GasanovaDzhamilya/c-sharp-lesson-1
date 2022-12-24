// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int number = new Random().Next(10, 99);

Console.WriteLine("Число: " + number);

if (number / 10 > number % 10)
{
        Console.WriteLine("Первая цифра больше");
} else if (number / 10 == number % 10)
{
        Console.WriteLine("Цифры одинаковы");
} else
{
        Console.WriteLine("Вторая цифра больше");
}
