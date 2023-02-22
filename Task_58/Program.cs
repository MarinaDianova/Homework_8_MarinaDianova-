// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

bool Validation(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
    else
    {
        System.Console.WriteLine("Данные матрицы нельзя перемножить! Число столбцов первой матрицы должно быть равно числу строк второй.");
        System.Console.WriteLine();
        return false;
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] prod = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                prod[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return prod;
}

int rows1 = ReadInt("Введите количество строк матрицы 1: ");
int cols1 = ReadInt("Введите количество столбцов матрицы 1: ");
System.Console.WriteLine();
var myMatrix1 = GenerateMatrix(rows1, cols1);
PrintMatrix(myMatrix1);
System.Console.WriteLine();

int rows2 = ReadInt("Введите количество строк матрицы 2: ");
int cols2 = ReadInt("Введите количество столбцов матрицы 2: ");
System.Console.WriteLine();
var myMatrix2 = GenerateMatrix(rows2, cols2);
PrintMatrix(myMatrix2);
System.Console.WriteLine();

if (Validation(myMatrix1, myMatrix2))
{
    System.Console.WriteLine("Произведение двух матриц:");
    PrintMatrix(MultiplyMatrix(myMatrix1, myMatrix2));
    System.Console.WriteLine();
}