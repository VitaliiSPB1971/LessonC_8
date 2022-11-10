// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
int strock = InputNumbers("Введите число: ");
int stolbec = InputNumbers("Введите число: ");

int[,] array = new int[strock, stolbec];
randomArray(array);
printArray(array);

int minSumStrock = 0;
int sumStrock = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumStrock = SumElements(array, i);
    if (sumStrock > tempSumStrock)
    {
        sumStrock = tempSumStrock;
        minSumStrock = i;
    }
}

Console.WriteLine($"\n{minSumStrock + 1} - строка с наименьшей суммой {sumStrock} ");


int SumElements(int[,] array, int i)
{
    int sumStrock = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumStrock += array[i, j];
    }
    return sumStrock;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void randomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(100);
        }
    }
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
