// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int number = 4;
int[,] spiralMass = new int[number, number];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMass.GetLength(0) * spiralMass.GetLength(1))
{
    spiralMass[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < spiralMass.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= spiralMass.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > spiralMass.GetLength(1) - 1)
        j--;
    else
        i--;
}

printArray(spiralMass);

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
