// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 21);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + "(" + i + ")" + "\t");
    }
    System.Console.WriteLine();
}


int[] MinimalSums(int[,] matrix)
{
    int[] sums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sums[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sums[i] = sums[i] + matrix[i, j];
        }
    }
    return sums;
}

int MinimalString(int[] array, out int minI)
{
    minI = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            minI = i;
        }
    }
    return minI;
}

metka:
int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
if (rows == cols)
{
    System.Console.WriteLine("Ввод некорректный! Количество строк и столбцов не должно совпадать.");
    goto metka;
}
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

System.Console.WriteLine();
int[] sumsArray = MinimalSums(myMatrix);
System.Console.WriteLine("Построчные суммы (номер строки):");
PrintArray(sumsArray);
System.Console.WriteLine();
System.Console.WriteLine($"Минимальная сумма в {MinimalString(sumsArray, out int minI)} строке массива");
System.Console.WriteLine();

