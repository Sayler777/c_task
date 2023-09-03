// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите на вход цифру (от 1 до 7), обозначающую день недели");
int newRandom = int.Parse(Console.ReadLine()!); //new Random().Next(1, 7); 

void Week(int num){
    if(num == 1){
        Console.WriteLine("Понедельник");
        return;
    }
    else if(num == 2){
        Console.WriteLine("Вторник");
         return;
    }
    else if(num == 3){
        Console.WriteLine("Среда");
         return;
    }
    else if(num == 4){
        Console.WriteLine("Четверг");
         return;
    }
    else if(num == 5){
        Console.WriteLine("Пятница");
         return;
    }
    else if(num == 6){
        Console.WriteLine("Суббота");
         return;
    }
    else if(num == 7){
        Console.WriteLine("Воскресенье");
         return;
    }
    else if(num == 7){
        Console.WriteLine("Воскресенье");
         return;
    }
    else{
        Console.WriteLine("Фууу...нужно было вводить на вход цифру, обозначающую день недели...фууу! ");
         return;
    }
}

Console.WriteLine(newRandom);
Week(newRandom);