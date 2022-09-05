//сортировка массива по убыванию.
int InputData(string message)
{
    System.Console.Write(message);                    
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result;                                    
}

int[,] Matrix(int numLine, int numColumns)         
{
    Random rand = new Random();
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = rand.Next(1, 9);    
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] array = Matrix(InputData("input lines  "),InputData("input columns  "));
Console.WriteLine("first matrix: ");
ShowMatrix(array);

for (var i = 0; i < array.GetLength(0); i++)
    for (var j = 0; j < array.GetLength(1); j++)
        for (var k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, j] >= array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
Console.WriteLine("Sort matrix: ");
ShowMatrix(array);

