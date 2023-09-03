// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int NewRandom(int run){
     int random = new Random().Next(1, 100);
     return random;
} 

int ArrayLength(string message){
    Console.WriteLine(message + "");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Filling(){
    int arrayConsole = ArrayLength("Введите длину массива");
    int[] array = new int[arrayConsole];
    
    for(int i = 0; i < arrayConsole; i++){
    array[i] = NewRandom(i);
    Console.Write((array[i])+ " ");
    };
}


Filling();

