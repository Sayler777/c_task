// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Напишите два число от 0 до 1000");
Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число Б");
int numberB = int.Parse(Console.ReadLine());

int max = numberA;

if(numberA == numberB){
    Console.WriteLine("Числа одинаковые, поэтому ответ "+ max);

}
else if (numberA < 0 || numberB < 0 || numberA >= 1001 || numberB >= 1001){
    Console.WriteLine("Фууу... надо было вводить числа от 0 до 1000, фууу...!!! ");
}

else if(max > numberB){
    Console.WriteLine("Введеные числа: " + numberA + " и " + numberB);
    Console.WriteLine("Max = " + max);
}
else{
    max = numberB;
    Console.WriteLine("Введеные числа: " + numberA + " и " + numberB);
    Console.WriteLine("Max = " + max);
}
// Задание 2 готова