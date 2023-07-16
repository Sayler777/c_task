// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string message){
    Console.WriteLine(message + "");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}


double numA = GetNumber("Введите число A");
double numB = GetNumber("Введите число B");

double Degree(double num1, double num2){
    double result = Math.Pow(num1,num2);
    return result;
}

Console.WriteLine(Degree(numA,numB));