// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь (без использования массива, ввод в цикле, и фиксировать в счетчике,если они положительные)

// int Positiv(int m){
//     int current = 0;
//     for(int i = 0; i<m; i++){
//         Console.Write("Введите число:");
//         int num1 = Convert.ToInt32(Console.ReadLine());
//         if(num1 > 0) current++;
//     }
//     return current;
// }

// Console.Write("Введите кол-во чисел: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int cur = Positiv(num);
// Console.WriteLine(cur + " чисел(ла) больше 0 ввел пользователь.");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//                                 значения b1, k1, b2 и k2 задаются пользователем.

double[] IntersPoint(double b1, double k1, double b2, double k2){
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;
    double[] array = {x, y};
    return array;
}
Console.Write("Введите значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
double[] Point = IntersPoint(b1, k1, b2, k2);
Console.WriteLine("Точка пересечения двух прямых " + Point[0] + " " + Point[1]);

