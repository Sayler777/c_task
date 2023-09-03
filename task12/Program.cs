// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetNumber(string message){
    Console.WriteLine(message + "");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}


int SumNumber(int num){
    int sum = 0;
    for(int i = 0; num > 0; i++){
        int conteinerNum = num % 10;
        sum = sum + conteinerNum;
        num = num /10;
    }
    return sum;
}

int number = GetNumber("Введите число");

Console.WriteLine(SumNumber(number));
            