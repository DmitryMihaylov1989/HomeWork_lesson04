// Задача 25: Напишите цикл, который принимает на 
// вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Quart(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
        result = result * numA;
    return result;
}


int quart = Quart(numA, numB);
Console.WriteLine($"Число {numA} в натуральной степени {numB} = " + quart);
