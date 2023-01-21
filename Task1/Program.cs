// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


System.Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (99 < num && num < 1000)

{
    int num1 = (num / 10 % 10);
    System.Console.Write($"Второй цифрой числа является: ");
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine("Введено не трёхзначное число"); 
}