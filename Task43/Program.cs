// Задача 43. Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y1=k1*x + b1 y=5*x + 2
// y2=k2*x + b2 y=9*x + 4

double[] line1=new double[2];
double[] line2=new double[2];
double x1 = 1;
double y1 = 0;
Console.WriteLine("Введите коэффициент B1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент K1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент B2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент K2: ");
double K2 = Convert.ToDouble(Console.ReadLine());
x1=(b2-b1)/(k1-K2);
y1=k1*x1 + b1;
Console.WriteLine(x1);
Console.WriteLine(y1);
if(k1 == K2)
{
      Console.WriteLine("Прямые паралельны и не пересекаются");
}
