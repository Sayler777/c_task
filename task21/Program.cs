// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
ArithmeticMean(array, rows, columns);

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

void ArithmeticMean(int[,] arr, int row, int column){
        for (int i = 0; i < column; i++){ 
            int Arithmetic = 0;
            double Arithmetic2 = 0;
            for (int j = 0; j < row; j++){
                Arithmetic = Arithmetic + arr[j,i];          
            }
            Arithmetic2 = (double) Arithmetic/row;

            Console.WriteLine($"Средняя арифметическая в столбце {i+1}: { Arithmetic2 = Math.Round(Arithmetic2, 1)}"); 
    } 
   
}