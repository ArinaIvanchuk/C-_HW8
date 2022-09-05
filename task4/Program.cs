// трехмерный массив.
int line = 2;
int columns = 2;
int cube = 2;
int anRep = 1;
int stsrtVol = 10;
Random rand = new Random();
Console.WriteLine("array coub: ");
int[,,] matrix1 = new int[line, columns, cube];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(2); k++)
        {
            matrix1[i, j, k] = stsrtVol + anRep;
            anRep++;
            Console.Write($"{matrix1[i, j, k]} ({j},{k},{i})\t");
        }
        Console.WriteLine();
    }
}

