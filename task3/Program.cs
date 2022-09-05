//произведение матриц.

Console.Clear();
int[,] Matrix(int line = 3, int colum = 3)
{
    int[,] matrix = new int[line, colum];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    return matrix;
}
System.Console.WriteLine("first matrix");

int[,] matrix1 = Matrix();
System.Console.WriteLine();
System.Console.WriteLine("second matrix");
System.Console.WriteLine();

int[,] matrix2 = Matrix();
int line = 3;
int columns = 3;
System.Console.WriteLine();
Console.WriteLine("product of matrices: ");
int[,] matrix3 = new int[line, columns];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
        }
        Console.Write($"{matrix3[i, j]}\t");
    }
    Console.WriteLine();
}

