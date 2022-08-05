// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());


// int result = 0;

// for (int i = 0; i <=result; i++)
// {
//     result+= a%10;
//     a = a / 10;
// }
// Console.WriteLine(result);
int b = 0;
int Method (int a)
{
    int result = 0;
    for (int i = 0; i <=result; i++)
    {
    result+= a%10;
    a = a / 10;
    }
    return result;
}
void PrintB(int b)
{
    Console.WriteLine($"Сумма цифр в числе {a} = " + b);
}

b = Method(a);
PrintB(b);
