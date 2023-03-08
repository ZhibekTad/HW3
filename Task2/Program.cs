//Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите координаты трех точек");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Az = Convert.ToInt32(Console.ReadLine());
int Bx = Convert.ToInt32(Console.ReadLine());
int By = Convert.ToInt32(Console.ReadLine());
int Bz = Convert.ToInt32(Console.ReadLine());
double i = Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Bx - By, 2) + Math.Pow(Az - Bz, 2));
Console.WriteLine("Расстояние между тремя точками на плоскости =  " + Math.Round(i, 2));