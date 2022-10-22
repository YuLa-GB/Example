// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double DegreeNum(double a, double b){
    double s = Math.Pow(a,b);
    return s;
}

Console.WriteLine("Введите число А: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
double b = Convert.ToInt32(Console.ReadLine());
double u = DegreeNum(a,b);
Console.WriteLine(u);

