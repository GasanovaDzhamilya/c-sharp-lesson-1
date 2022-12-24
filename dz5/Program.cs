// Задача №5. 
// Показать последнюю цифру трёхзначного числа.


Console.Write("Введите пожалуйста трёхзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a % 10;

if (a>99&&a<1000)
{
    // Console.Write("Последня цифра: ");
    // Console.Write(b);
    string str = $"Последняя цифра: {b}";
    Console.Write(str);

}
else Console.Write("Это не трех значное число");
