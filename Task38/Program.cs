// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int Promt (string message)
{
  System.Console.WriteLine(message);
  string str = System.Console.ReadLine() ?? String.Empty;
  double numberDouble = (int) Convert.ToDouble(str);
  int result = Convert.ToInt32(numberDouble);
  return result;
}

double [] IntDoubleMassive (int length)
{
  double [] arr = new double [length];
  Random rnd = new Random();
  for (int i = 0; i < length; i++)
  {
    arr[i] = rnd.Next(-99,100) + Math.Round(rnd.NextDouble(), 2);
  }
  return arr;
}

double DiffBetweemMaxMin (double [] Array)
{
  double maxElement = Array[0];
  double minElement = Array[0];
  
  for (int i = 0; i < Array.Length; i++)
  {
    if (maxElement<Array[i])
    {
      maxElement = Array[i];
    }
    if (minElement>Array[i])
    {
      minElement = Array[i];
    }
  }
   return maxElement-minElement;
}

int lengthMassive = Promt ("Введите длину массива: ");
double [] newArray = IntDoubleMassive(lengthMassive);
System.Console.WriteLine(string.Join("; ", newArray));
System.Console.WriteLine($"Разница между максимальным и минимальным значением: {DiffBetweemMaxMin(newArray)}");