// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] RandomArr(int size){
    int[] arr = new int[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().Next(-100, 101);
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
    int sumArrOdd = 0;
    int[] array = RandomArr(GetNumber("Введите длину массива"));
    Console.WriteLine("\nНечетные числа:");
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 > 0 || array[i]%2 < 0 ){
        Console.Write($"{array[i]} ");
        sumArrOdd += array[i];
        }
    }
    Console.WriteLine($"\nСумма нечетных чисел: {sumArrOdd}");
}

Start();
