// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] RandomArr(int size){
    int[] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    return arr;  
}

int GetNumber(string message){
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Start(){
    int[] array = RandomArr(GetNumber("Введите длину массива"));
    Console.WriteLine("\nЧетные числа:");
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0 )
        Console.Write($"{array[i]} ");
    }
}

Start();



