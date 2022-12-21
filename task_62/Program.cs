// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + $"({i},{j}) ");
        }
        Console.WriteLine();
    }
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rowsCount, columnsCount];
    int S = 0;

    // int[] Y = {0,0,0,0,1,1,1,1,2,2,2,2,3,3,3,3};
    // int[] X = {0,1,2,3,0,1,2,3,0,1,2,3,0,1,2,3};

    //         1 2 3 4  5 6 7 8  9 10 11 12  13 14 15 16
    int[] Y = {0,0,0,0, 1,2,3,3, 3,3, 2, 1,  1, 1, 2, 2};
    int[] X = {0,1,2,3, 3,3,3,2, 1,0, 0, 0,  1, 2, 2, 1};
    

    //Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[Y[S], X[S]] = S+1;
            S++;
             //rand.Next(leftRange, rightRange) + 1;
        }
    }
    return matr;
}

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);

