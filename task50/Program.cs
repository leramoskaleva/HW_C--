// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(2, 10);
        }
    }
return matrix;
}

void SearchValue (int[,] matr, int number)
{
  bool search = true;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (number == matr[i, j])
      {
        search = false;
        break;
      }
    }
  }
  if (search)
  {
    System.Console.Write($" {number} Ваш элемент отсутствует в массиве ");
  }
  else
  {
    System.Console.Write(number);
  }
}

void SearchIndex(int[,] matr, int Index1, int Index2)
{
  bool search = true;
  int num = 0;
  if (Index1 <= matr.GetLength(0) && Index2 <=matr.GetLength(1))
  {
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i, j] == matr[Index1, Index2])
      {
        search = false;
        num = matr[i, j];
      }
    }
  }
  if (search)
  {
    System.Console.Write("Введите другой адрес");
  }
  else
  {
    System.Console.WriteLine($"Ответ:{num}");
  }
  }
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

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

System.Console.WriteLine("Чтобы искать по индексу элемента, введите 1");
System.Console.WriteLine("Чтобы искать по значению элемента, введите 2");
int swit = Convert.ToInt32(Console.ReadLine());

switch (swit)
{
  case 1:
    System.Console.Write("Введите первый индекс: ");
    int index1 = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите второй индекс: ");
    int index2 = Convert.ToInt32(Console.ReadLine());
    SearchIndex(matrix, index1, index2);
    break;
  
  case 2:
    System.Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    SearchValue(matrix, number);
    break;
  
  default:
    System.Console.WriteLine("Неверный ввод!");
    System.Console.Write("Введите число 1 или 2");
    break;
}

