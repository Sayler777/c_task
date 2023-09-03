// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M от 0 и более");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N больше M и более");
int n = int.Parse(Console.ReadLine()!);


int Sum(int m, int n){
    if (m==n){
        return n;
    }
    else{
        return m + Sum(m + 1, n);
    } 
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {Sum(m,n)}");

