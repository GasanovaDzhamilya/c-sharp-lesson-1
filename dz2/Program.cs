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

Console.WriteLine("");
Console.WriteLine("***");
Console.WriteLine("");

//По заданному номеру дня недели вывести его название
void dayOfWeekByNumber(int number)
{
    Console.WriteLine(number + " - это какой день недели?");

    if ((number < 1) | (number > 7)) {
      Console.WriteLine("Нет такого дня недели!!!"); 
    }

    if (number == 1)
    {
      Console.WriteLine("понедельник");  
    }

    if (number == 2)
    {
      Console.WriteLine("Вторник");  
    }

    if (number == 3)
    {
      Console.WriteLine("Среда");  
    } 

    if (number == 4)
    {
      Console.WriteLine("Четверг");  
    } 
    
    if (number == 5)
    {
      Console.WriteLine("Пятница");  
    } 
    
    if (number == 6)
    {
      Console.WriteLine("Суббота");  
    } 

    if (number == 7)
    {
      Console.WriteLine("Воскресенье");  
    } 
}

dayOfWeekByNumber(1);
dayOfWeekByNumber(2);
dayOfWeekByNumber(6);
dayOfWeekByNumber(4);
dayOfWeekByNumber(9);