﻿// Задача №6.
// Показать вторую цифру трёхзначного числа.

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a/10%10;       // например число 789. 789/10=78,9 остаток убираем = 78, далее 78%10=8 итого 2я цифра 8

if (a > 99 && a < 1000) 
{
Console.Write("второе число: ");
Console.WriteLine(b);
}
else Console.Write("Это не трехзначное число!");