// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int strock = InputNumbers("Введите число строк 1-й матрицы: ");
int stolbec = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int stolbec2 = InputNumbers("Введите число столбцов 2-й матрицы: ");

int[,] firstMass = new int[strock, stolbec];
randomArray(firstMass);
Console.WriteLine($"\nПервая матрица:");
printArray(firstMass);

int[,] secondMass = new int[stolbec, stolbec2];
randomArray(secondMass);
Console.WriteLine($"\nВторая матрица:");
printArray(secondMass);

int[,] resultMass = new int[strock, stolbec2];

MultiplyMass(firstMass, secondMass, resultMass);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
printArray(resultMass);

void MultiplyMass(int[,] firstMass, int[,] secondMass, int[,] resultMass)
{
    for (int i = 0; i < resultMass.GetLength(0); i++)
    {
        for (int j = 0; j < resultMass.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMass.GetLength(1); k++)
            {
                sum += firstMass[i, k] * secondMass[k, j];
            }
            resultMass[i, j] = sum;
        }
    }
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
            array[i, j] = new Random().Next(10);
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
