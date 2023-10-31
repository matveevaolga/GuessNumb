using System.ComponentModel.DataAnnotations;
using Test;

//int int_input, k;
//Console.WriteLine("Введите число: ");
//string input = Console.ReadLine();
//try
//{
//    int_input = int.Parse(input);
//    Console.WriteLine("Введите число цифр k: ");
//    k = int.Parse(Console.ReadLine());
//}
//catch (FormatException)
//{
//    Console.WriteLine("Введено не число");
//    return;
//}

//int len = input.Length;

//if (len < k)
//{
//    Console.WriteLine("Введенное k превышает длину данного числа");
//    return;
//}

//while (len > k)
//{
//    len--;
//    int_input /= 10;
//}

//Console.WriteLine($"Результат: {int_input}");
//int a = 14;
//Console.Write("{0,3:f4}", a * 1000);
//{Индекс,Выравнивание:Спецификатор формата}
//int[] a = { 1, 2, 3 };
//if (a != null) Console.WriteLine(a);
//else; 
static bool IsGuessNumber(int target)
{
    int input = int.Parse(Console.ReadLine());
    return input == target;
}

static int GetRandomNumber()
{
    Random random = new();
    int target = random.Next(0, 100);

    return target;
}

static void Game()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Попытка {i + 1}:");
    }
  
    if (IsGuessNumber(target))
    {
        Console.WriteLine("Вы угадали!");
        target = -1;
    }
  
    if (target != -1) Console.WriteLine($"Вы не угадали, заданное число - {target}");
}

Game();