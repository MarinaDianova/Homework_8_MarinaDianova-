// Задача 62: Заполните спирально массив 4 на 4. (Универсального размера). Заполнение числами от 1 до n.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    int i = 0;
    int j = 0;

    // for (i = 0; i < matrix.GetLength(0); i++)
    // {
    //     if (i == 0)
    //     {
    //         matrix[i, 0] = 1;
    //         for (j = 1; j < matrix.GetLength(1); j++) //Нулевой верхний горизонтальный ряд 
    //         {
    //             matrix[i, j] = matrix[i, j - 1] + 1;
    //         }
    //     }
    //     if (i != 0 && j == cols - 1) // Последний вертикальный столбец
    //     {
    //         for (i = 1; i < rows; i++)
    //         {
    //             matrix[i, j] = matrix[i-1, j] + 1;
    //         }
    //     }
    //     else if (i == rows - 1 && j != cols - 1) //Нижний горизонтальный ряд 
    //     {
    //         for (j = cols - 2; j >= 0; j--)
    //         {
    //             matrix[i, j] = matrix[i, j + 1] + 1;
    //         }
    //     }
    //     else if (i != 0 && i != rows - 1 && j == 0) // Нулевой вертикальный столбец
    //     {
    //         for (i = rows - 2; i > 0; i--)
    //         {
    //             matrix[i, j] = matrix[i + 1, j] + 1;
    //         }
    //     }
    //     else if (i == 1 && j != 0 && j != cols - 1) //Средний горизонтальный ряд 
    //     {
    //         for (j = 1; j > cols - 2; j++)
    //         {
    //             matrix[i, j] = matrix[i, j-1] + 1;
    //         }
    //     }
    //     else if (i != 0 && i != rows - 1 && j == rows - 1) // Средний вертикальный столбец
    //     {
    //         for (i = rows - 2; i > 0; i--)
    //         {
    //             matrix[i, j] = matrix[i + 1, j] + 1;
    //         }
    //     }
    //     //    else if (i == 1 && j != 0 && j != cols - 1) //Последний горизонтальный ряд 
    //     // {
    //     //     for (j = 1; j > cols - 2; j++)
    //     //     {
    //     //         matrix[i, j] = matrix[i, j-1] + 1;
    //     //     }
    //     // }

    // }

    int iStart = 0, iEnd = rows - 1, jStart = 0, jEnd = cols - 1;
    matrix[i, j] = 1;

    for (i = 0; i < iEnd; i++)
    {
        for (j = 1; j <= jEnd; j++)
        {
            if (i == iStart) // Нулевой верхний горизонтальный ряд 
            {
                //matrix[i, j] = 1;

                matrix[i, j] = matrix[i, j - 1] + 1;

            }
            if (i != iStart && j == jEnd) // Последний вертикальный столбец
            {
                for (i = iStart + 1; i <= iEnd; i++)
                {
                    matrix[i, j] = matrix[i - 1, jEnd] + 1;
                }
            }
            else if (i == iEnd && j != jEnd) //Нижний горизонтальный ряд 
            {
                for (j = jEnd - 1; j >= jStart; j--)
                {
                    matrix[i, j] = matrix[i, j + 1] + 1;
                }
            }
            else if (i != iStart && i != iEnd && j == jStart) // Нулевой вертикальный столбец
            {
                for (i = iEnd - 1; i > iStart; i--)
                {
                    matrix[i, j] = matrix[i + 1, j] + 1;
                }
            }


        }

        // iStart += 1;
        // iEnd -= 1;
        // jStart += 1;
        // jEnd -= 1;
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


int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);


