// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Напишите любое число");
int numberA = int.Parse(Console.ReadLine());

int result = numberA%2;
if(result == 0){
    Console.WriteLine("Число " + numberA + " является чётным");
}
else{
    Console.WriteLine("Число " + numberA + " нечётное");
}

//задача 6 готова