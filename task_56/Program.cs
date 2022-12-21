// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] Task(int[,] matr)
{
    int[] rowArray = new int[matr.GetLength(0)];
    int summ = 0;
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
            summ+=matr[i, j];
        }
        rowArray[i] = summ;
        Console.Write(summ + " ");
        summ=0;
        Console.WriteLine();
    }
    return rowArray;
}

int findMinInArray(int[] array)
{
    int min = 999;
    int mini = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            {
                min = array[i];
                mini = i;
            }
        //Console.Write(array[i] + " ");
    }
    return mini;
}

int rows = 4;// GetNumber("Введите число строк");
int columns = 4; // GetNumber("Введите число столбцов");
int[,] matrix = GetMatrix(rows, columns);


PrintMatrix(matrix);
Console.WriteLine();
int[] taskArray = Task(matrix);
Console.WriteLine();
PrintArray(taskArray);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов массива {findMinInArray(taskArray)+1} ");

