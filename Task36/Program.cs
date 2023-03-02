// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
for(int i =0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1,10);
}
return arr;
}

System.Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(length);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                  sum1 = sum1 + array[i];
                else
                  sum2 = sum2 + array[i];
            }
System.Console.WriteLine(sum2);
