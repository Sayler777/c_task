// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int GetNumber(string message){
    Console.WriteLine(message + "");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltax = x2-x1;
int deltay = y2-y1;
int deltaz = z2-z1;
return Math.Sqrt(deltax*deltax+deltay*deltay+deltaz*deltaz);
}

int x1 = GetNumber("Введите координату X точки A");
int y1 = GetNumber("Введите координату Y точки A");
int z1 = GetNumber("Введите координату Z точки A");
int x2 = GetNumber("Введите координату X точки B");
int y2 = GetNumber("Введите координату Y точки B");
int z2 = GetNumber("Введите координату Z точки B");

Console.WriteLine(dis(x1,y1,z1,x2,y2,z2));