// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Random rnd = new Random();
int[,] matrix = new int[2, 2];
int[,] matrix2 = new int[2, 2];
int[,] multiplyMatrix = new int[2, 2];


fillMatrix(matrix,rnd);
Console.WriteLine("Вывод 1 матрицы:");
printMatrix(matrix);

fillMatrix(matrix2,rnd);
Console.WriteLine("Вывод 2 матрицы:");
printMatrix(matrix2);
multiPlyMatrix(matrix, matrix2,multiplyMatrix);

Console.WriteLine("Произведение матриц:");
printMatrix(multiplyMatrix);


void fillMatrix(int[,] matrix,Random rnd){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        matrix[i, j] = rnd.Next(20);
        }

    }
}

void printMatrix(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        Console.Write(matrix[i, j]+ " ");
        }
        Console.WriteLine();
    }

}
void multiPlyMatrix(int[,] matrix, int[,] matrix2, int[,] multMatrix){

    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
        multMatrix[i, j] = matrix2[i, j] * matrix[i, j];
        }

    }
}