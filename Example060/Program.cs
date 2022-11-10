// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Write("Введите число первого измерения:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число второго измерения:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число третьего измерения:");
int number3 = Convert.ToInt32(Console.ReadLine());
int[,,] inputArray(int number1, int number2, int number3)
{
    int[,,] array = new int[number1, number2, number3];
    for (int i = 0; i < number1; i++)
    {
        for (int j = 0; j < number2; j++)
        {
            int k = 0;
            while (k < number3)
            {
                int element = new Random().Next(10, 99 + 1);
                if (checkElement(array, element)) continue;
                array[i, j, k] = element;
                k++;
            }
        }
        Console.WriteLine();
    }
    return array;
}
bool checkElement(int[,,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return false;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] array_res = inputArray(number1, number2, number3);
PrintArray(array_res);
