// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] GetMatrix(int rowsCount, int columnsCount, int layerCount)
{
    int[,,] matr = new int[rowsCount, columnsCount, layerCount];
    int start = 10;
    //Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = start;
                start++;
            }
        }
    }
    return matr;
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i, j, k] + $"({i},{j},{k}) " );
            }
            Console.WriteLine();
        }
    }
}

int X = 2;
int Y = 2;
int Z = 2;

int[,,] matrix = GetMatrix(X, Y, Z);
PrintMatrix(matrix);


