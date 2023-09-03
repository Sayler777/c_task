// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
SumInRow(array);

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
            res[i,j] = new Random().Next(1,10);         
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

void SumInRow(int[,] arr){
    int[] sumInRow = new int[arr.GetLength(0)];
    Console.Write("Суммы элементов в каждой строке: ");
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            sumInRow[i] += arr[i, j];
        }
                Console.Write($"{sumInRow[i]} ");
    }
    int minRow = 0;
    for (int i = 0; i < sumInRow.Length; i++){
        if (sumInRow[minRow] > sumInRow[i]) minRow = i;
    }
    Console.Write($"\nНаименьшая сумма элементов: {sumInRow[minRow]}");
}
