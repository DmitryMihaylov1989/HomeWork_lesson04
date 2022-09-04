//  Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.
int[] result = FullArray(8, 0, 100);
PrintArr(result);

int[] FullArray(int n, int min, int max)
{
  int[] array = new int[n];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(min, max);
  }
  return array;
 }

void PrintArr(int[] array)
{
  for (int i = 0; i<array.Length; i++)
  {
  Console.Write(array[i] + ","); 
  }
}