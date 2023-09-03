// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
Position(array,columns);

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

void Position(int [,] arr, int column){
    Console.WriteLine("Убывание элементов каждой строки:");
    int [] tamp = new int [column];
    for (int i = 0; i < arr.GetLength(0); i++){ 
        for (int j = 0; j < arr.GetLength(1); j++){
        tamp [j] = arr[i,j];              
        }
    int[] reversedSorted = tamp.OrderByDescending(x => x).ToArray();
    Console.WriteLine(String.Join(" ", reversedSorted));

}
}