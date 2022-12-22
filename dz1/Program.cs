// По двум заданным числам проверять является ли первое квадратом второго
void isFirstNumberSquareOfSecond(float num1, float num2) 
{
    Console.WriteLine("Является ли " + num1 + " квадратом " + num2 + "?");
    if (num1 == num2 * num2) 
    {
        Console.WriteLine("Да, является");
    } else 
    {
        Console.WriteLine("Нет, не является");
    }
}

isFirstNumberSquareOfSecond(16, 4);
isFirstNumberSquareOfSecond(36, 5);
