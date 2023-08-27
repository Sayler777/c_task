// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
SearchArr(array, rows, columns);

int GetNum(string message)
{
    Console.Write(message);
    int num =int.Parse(Console.ReadLine()!);
    return num;
}

int [,] GetArray(int row, int column){
    int[,] res = new int [row, column];
    for (int i = 0; i < row; i++){ 

        for (int j = 0; j < column; j++){
            res[i,j] = new Random().Next(0,100);          
        }
    }
    return res;
}

void PrintArray(int [,] arr){
    
    for (int i = 0; i < arr.GetLength(0); i++){ 
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");            
        }
        Console.WriteLine();
    }
}

void SearchArr(int[,] arr, int row, int column){
    Console.WriteLine("Введите координаты строки");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты столбца");
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > row && b > column)
    Console.WriteLine("такого числа нет");
    else
    {
    object c = array.GetValue(a,b)!;
    Console.WriteLine(c);
    }
}






