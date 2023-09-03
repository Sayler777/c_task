// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Напишите любое число");
int numberA = int.Parse(Console.ReadLine());

int index = 1;
int result;
while(index <= numberA){
    result = index%2;
    if(result == 0){
    Console.Write(index+" ");
    index++;
    }
    else{
        index++;
    }
}    

// Задача № 8 готова
