
//наименьшая сумма в строке.
int line = 3;
int sum = 0;
Random rand2 = new Random();
int[] array = new int[line];
int [,] MatrixSumLine(int row =3, int col =3)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = new Random() .Next(1, 9);
            sum = sum + matrix[i,j];
            Console.Write($"{matrix[i, j]}\t");   
        }
        array[i] = sum;
        Console.WriteLine();
        sum = 0;
        
    }
    return matrix;
}
int [,] matrix = MatrixSumLine();

Console.WriteLine();
int minRow = array[0];
int minSum = 1;
for (int k = 1; k < line; k++)
{
    if (array[k]<minRow)
    {
        minRow = array[k];
        minSum = k+1;
    }
}
Console.WriteLine($"the line with lowest sum is {minSum}");
