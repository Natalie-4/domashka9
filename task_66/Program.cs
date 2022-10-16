/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120          M = 4; N = 8. -> 30           */



int SummaNaturalNumbers(int M, int N)
{
    if (M == N)
    return N;
    return SummaNaturalNumbers(M + 1, N) + (N - M);
}

Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SummaNaturalNumbers(M,N));
