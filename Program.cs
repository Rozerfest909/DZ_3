// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    Console.WriteLine ($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int Ax = ReadInt("Введите A(X)");
int Ay = ReadInt("Введите A(Y)");
int Az = ReadInt("Введите A(Z)");

int Bx = ReadInt("Введите B(X)");
int By = ReadInt("Введите B(Y)");
int Bz = ReadInt("Введите B(Y)");

int A = (Ax - Bx);
int B = (Ay - By);
int C = (Az - Bz);

double W = Math.Sqrt(Math.Pow(A,2) + Math.Pow(B,2) + Math.Pow(C,2) );

Console.WriteLine($"Расстояние между точками А({Ax},{Ay},{Az}) и B({Bx},{By},{Bz}) равно {W:f2}");