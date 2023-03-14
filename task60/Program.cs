// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] FillArrayWithRandomNumbers(int[,,] arr, int minVal, int maxVal)
{
    int temp;
    bool check = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Random rnd = new Random();
                temp = rnd.Next(minVal, maxVal);
                check = CheckRepeats(arr, temp);
                if (check)
                {
                    arr[i, j, k] = temp;
                }
                else
                {
                    k--;
                }
            }
        }

    }
    return arr;
}

bool CheckRepeats(int[,,] arr, int value)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i,j,k] == value)
                {
                    return false;
                }
            }
        }
    }
    return true;
}

void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(2); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int WriteNumbers(string txt)
{
    Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

int column = WriteNumbers("Введите длину первого измерения: ");
int row = WriteNumbers("Введите длину второго измерения: ");
int number1 = WriteNumbers("Введите длину третьего измерения: ");
int miNum = WriteNumbers("Введите минимальное значение (не менее 10): ");
int maxNum = WriteNumbers("Введите максимальное значение (не более 99): ");
int[,,] array = new int[number1, row, column];
array = FillArrayWithRandomNumbers(array, miNum, maxNum);
PrintMatrix(array);
Console.WriteLine();