// Console.WriteLine("Введите число от 1 до 7");
// int num = int.Parse(Console.ReadLine());

// string day1 = "понедельник";
// string day2 = "вторник";
// string day3 = "среда";
// string day4 = "четверг";
// string day5 = "пятница";
// string day6 = "суббота";
// string day7 = "воскресенье";
// string day0 = "фууу, нужно вводить от 1 до 7 цмооо";
// int index = 1;

// if(num > 0 && num <= 7){
//     if(num == 1){
//         Console.WriteLine(day1);
//     }
//     if(num == 2){
//         Console.WriteLine(day2);
//     }
//     if(num == 3){
//         Console.WriteLine(day3);
//     }
//     if(num == 4){
//         Console.WriteLine(day4);
//     }
//     if(num == 5){
//         Console.WriteLine(day5);
//     }
//     if(num == 6){
//         Console.WriteLine(day6);
//     }
//     if(num == 7){
//         Console.WriteLine(day7);
//     }
// } 
// else{
//     Console.WriteLine(day0);
// }


// Урок 1. Знакомство с языком программирования С# //  
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Напишите два число от 0 до 1000");
// Console.WriteLine("Введите число А");
// int numberA = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число Б");
// int numberB = int.Parse(Console.ReadLine());

// int max = numberA;

// if(numberA == numberB){
//     Console.WriteLine("Числа одинаковые, поэтому ответ "+ max);

// }
// else if (numberA < 0 || numberB < 0 || numberA >= 1001 || numberB >= 1001){
//     Console.WriteLine("Фууу... надо было вводить числа от 0 до 1000, фууу...!!! ");
// }

// else if(max > numberB){
//     Console.WriteLine("Введеные числа: " + numberA + " и " + numberB);
//     Console.WriteLine("Max = " + max);
// }
// else{
//     max = numberB;
//     Console.WriteLine("Введеные числа: " + numberA + " и " + numberB);
//     Console.WriteLine("Max = " + max);
// }
// Задание 2 готова






// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Напишите три число от 0 до 1000");

// Console.WriteLine("Введите число А");
// int numberA = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число Б");
// int numberB = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число В");
// int numberC = int.Parse(Console.ReadLine());

// int max = numberA;
// int index = 1;
// while(index <= 3){
//     if(max < numberB){
//         max = numberB;
//     }
//     else if(max < numberC){
//         max = numberC;
//     }
//     index++;
// }

// if (numberA < 0 || numberB < 0 || numberC < 0 || numberA >= 1001 || numberB >= 1001 || numberC >= 1001){
// Console.WriteLine("Фууу... надо было вводить числа от 0 до 1000, фууу...!!! ");
// } 
// else{
//     Console.WriteLine("Max = " + max); 
// }

//Задача 4 готова






// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Напишите любое число");
// int numberA = int.Parse(Console.ReadLine());

// int result = numberA%2;
// if(result == 0){
//     Console.WriteLine("Число " + numberA + " является чётным");
// }
// else{
//     Console.WriteLine("Число " + numberA + " нечётное");
// }

//задача 6 готова


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Напишите любое число");
// int numberA = int.Parse(Console.ReadLine());

// int index = 1;
// int result;
// while(index <= numberA){
//     result = index%2;
//     if(result == 0){
//     Console.Write(index+" ");
//     index++;
//     }
//     else{
//         index++;
//     }
// }    

// Задача № 6


