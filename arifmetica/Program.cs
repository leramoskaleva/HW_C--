// Вывести на экран число  с точностью до сотых.

//Console.Write("Введите число: ");
//double number = Convert.ToDouble(Console.ReadLine());
//double result1 = Math.Round(number,2);// Округление
//System.Console.WriteLine(result1);

// Вывести на экран число e (основание натурального логарифма) с точностью до десятых.

//Console.Write("Введите число: ");
//double number = Convert.ToDouble(Console.ReadLine());
//double result1 = Math.Log(number);    
//System.Console.WriteLine($"{Math.Round(result1,1)}");

// Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Вы ввели число: {number}");

// Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».

//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"{number} вот какое число вы ввели");

// Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.

//int a = 1;
//int b = 13;
//int c = 49;
//Console.WriteLine($"{a} {b} {c}");

// Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.

//int a = 7;
//int b = 15;
//int c = 100;
//Console.WriteLine($"{a}  {b}  {c}");

// Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.

//Console.Write ("Введите число а ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write ("Введите число b ");
//int b = Convert.ToInt32(Console.ReadLine());
//Console.Write ("Введите число c ");
//int c = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"{a}  {b}  {c}");

//Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.

//Random rnd = new Random();
//int a = rnd.Next();
//int b = rnd.Next();
//int c = rnd.Next();
//int d = rnd.Next();

//Console.WriteLine($"{a} {b} {c}");

// Вывести на экран числа 50 и 10 одно под другим.

//int a = 50;
//int b = 10;
//Console.WriteLine($"{a}\n{b}");

// Вывести на экран числа 5, 10 и 21 одно под другим.
//int a = 5;
//int b = 10;
//int c = 21;
//Console.WriteLine($"{a}\n{b}\n{c}");

//Составить программу вывода на экран «столбиком» четырех любых чисел.
//Random rnd = new Random();
//int a = rnd.Next();
//int b = rnd.Next();
//int c = rnd.Next();
//int d = rnd.Next();

//Console.WriteLine($"{a}\n{b}\n{c}\n{d}");

// Составить программу вывода на экран следующей информации: 5 10
//                                                           7 см
//int a = 5;
//int b = 10;
//string c = ("7 см");
//Console.WriteLine($"{a} {b} \n{c}");

// Составить программу вывода на экран следующей информации: 2 кг
//                                                          13 17

int[,] FillMatrixWithRandom(int row, int column)
{
  int[,] matrix = new int[row, column];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(0, 10);
    }
  }
  return matrix;
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

void PrintStatic(int[,] matrix)
{
  double resul = 0;
  double sumStolb = 0;
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
      sumStolb += matrix[j, i];
    }
    resul = sumStolb / matrix.GetLength(0);
    Console.WriteLine($"Средне арифметическое {i + 1} столбца = {resul}");
    resul = 0;
    sumStolb = 0;
  }
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(row, column);
PrintMatrix(matrix);

PrintStatic(matrix);


