// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine($"Введите числа(через пробел) соответствующие: b1, k1, b2 и k2");
double[] array = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);  //как тут применить - StringSplitOptions.RemoveEmptyEntries (чтобы избежать двойного пробела)

double b1 = array[0];
double k1 = array[1];
double b2 = array[2];
double k2 = array[3];

    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых X: {x}, Y: {y}");
