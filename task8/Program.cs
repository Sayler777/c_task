// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



int GetNumber(string message){
    Console.WriteLine(message + "");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int Palindrom(int num){
    int conteinerNumber = num;
    int sum = 0;
    int fail = -1;
    if(num > 9999 && num < 100000){
        for(int i = 1; i <= 5; i++){
            int conteinerPalindrom = conteinerNumber % 10;
            sum = sum * 10 + conteinerPalindrom;
            conteinerNumber = conteinerNumber/10;
        }
        return sum;
    }
    else{
        return fail;
    }
}

void Result(int num2, int num3){
    if (num2 == -1){
        Console.WriteLine("Введено не пятизначное число");
    }
    else if(num2 == num3){
        Console.WriteLine("да");
    }
    else{
        Console.WriteLine("нет");
    }

}

int number = GetNumber("Введите на вход пятизначное число");

Result(Palindrom(number),number);

