// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SunNumbers(int M, int N)
{
    if(N == M)
    {
        return M;
    }

    return N + SunNumbers(M,N-1);  
}
Console.Write("Введите число M ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"{SunNumbers(numberM,numberN)}");