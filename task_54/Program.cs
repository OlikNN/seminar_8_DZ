// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matr = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange) + 1;
        }
    }
    return matr;
}


void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void BubbleSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int t = array[j + 1];
                array[j + 1] = array[j];
                array[j] = t;
            }
}

void Task(int[,] matr)
{
    int[] rowArray = new int[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        //    Console.Write(matr[i, j] + " ");
            rowArray[j] = matr[i, j];
        }
        BubbleSort(rowArray);
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(rowArray[j] + " ");
        }
        Console.WriteLine();
    }
}

int rows = 4;// GetNumber("Введите число строк");
int columns = 4; // GetNumber("Введите число столбцов");
int[,] matrix = GetMatrix(rows, columns);


PrintMatrix(matrix);
Console.WriteLine();

Task(matrix);