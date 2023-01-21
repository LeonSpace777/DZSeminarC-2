// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while (num < 1000)
    {
        int num1 = (num % 10);
        System.Console.Write("Третьей цифрой числа является: ");
        System.Console.WriteLine(num1);
        break;
    }
}
else
{
    System.Console.WriteLine("Третьей цифры нет");
}
if (num > 999)
{
    while (num > 999)
    {
        num = num / 10;
    }
    System.Console.WriteLine($"Третьей цифрой является: {num % 10}");
}