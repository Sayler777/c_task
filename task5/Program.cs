// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число");
//int newRandom = new Random().Next(100, 1000); тест 
int numberA = int.Parse(Console.ReadLine()!);

int SecondNumber(int num){
    int firstNum = num / 10;
    int lastNum = firstNum % 10;
    return lastNum;
}

if(numberA > 99 && numberA < 1000){
    Console.WriteLine("Введеное число: "+numberA);
    Console.WriteLine(SecondNumber(numberA));
}
else{
   Console.WriteLine("Фууу... надо было вводить трёхзначное число, фууу...!!! ");
}

    
