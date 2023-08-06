// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] RandomArr(int size){
    double[] arr = new double[size];
    for(int i = 0; i < size; i++){
        arr[i] = new Random().NextDouble()* 100;
        arr[i] = Math.Round(arr[i], 2);
        Console.Write($"{arr[i]} ");

        
    }
    return arr;  
}

int GetNumber(string message){
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double MaxArr(double[] arr){
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        
        if (arr[i] > max){
            max = arr[i];
            max = Math.Round(max, 2);
        }
    }
    return max;
}

double MinArr(double[] arr){
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        
        if (arr[i] < min){
            min = arr[i];
            min = Math.Round(min, 2);
        }
    }
    return min;
}

void Start(){
    double[] array = RandomArr(GetNumber("Введите длину массива"));
    double max = MaxArr(array);
    double min = MinArr(array);
  
    Console.WriteLine($"\nРазница между Max и Min числом: {max} - {min} = {max - min}");
}

Start();
