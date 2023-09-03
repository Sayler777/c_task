// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Напишите три число от 0 до 1000");

Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число Б");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;
int index = 1;
while(index <= 3){
    if(max < numberB){
        max = numberB;
    }
    else if(max < numberC){
        max = numberC;
    }
    index++;
}

if (numberA < 0 || numberB < 0 || numberC < 0 || numberA >= 1001 || numberB >= 1001 || numberC >= 1001){
Console.WriteLine("Фууу... надо было вводить числа от 0 до 1000, фууу...!!! ");
} 
else{
    Console.WriteLine("Max = " + max); 
}

//Задача 4 готова