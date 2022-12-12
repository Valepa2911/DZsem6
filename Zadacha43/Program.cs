// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите 4 числа через запятую(k1,k2,b1,b2): ");
double[] mass = Array.ConvertAll(Console.ReadLine(). Split(",") , double. Parse);
double k1 = mass[0];
double k2 = mass[1];
double b1 = mass[2];
double b2 = mass[3];
int Len = mass.Length;
//double x = -(b1 - b2) / (k1 - k2);
//double y = k1 * x + b1;
Uravnenie (mass);



void Uravnenie (double[] mass)
{
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
        
    Console.WriteLine($"Пересечение в точке: {x};{y}");
}
