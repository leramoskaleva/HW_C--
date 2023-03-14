// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер 
//строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
return matrix;
}


int Summin(int[,] matrix)
{
    int sumTempo = 0;
    int sum = 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumTempo = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < 1) sum += matrix[i, j];

            sumTempo += matrix[i, j];
        }

        if (sumTempo < sum)
        {
            sum = sumTempo;
            index = i;
        }
    }
    return index;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
    Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов на строке {Summin(matrix) + 1}");