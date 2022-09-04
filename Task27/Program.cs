// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12)

Console.WriteLine("Введите целое число: ");
int sum = 0;

int n = Convert.ToInt32(Console.ReadLine());
while (n > 0)
{
sum += n % 10;
n = n / 10;
}
Console.WriteLine("сумма цифр этого числа =  " + sum);
