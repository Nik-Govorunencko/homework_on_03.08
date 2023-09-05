// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите 4 числа которые обозначат: k1 и b1, k2 и b2 двух прямых: y = k1*x + b1; y = k2*x + b2; И мы покажем вам их точку пересечения! (если результатом получиться вещественное число, то мы округлим его до сотых)");

double[] Fill_numbers()
{
    double[] array = new double[4];
    Console.Write("k1 = ");
    array[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("k2 = ");
    array[1] = Convert.ToDouble(Console.ReadLine());
    Console.Write("b1 = ");
    array[2] = Convert.ToDouble(Console.ReadLine());
    Console.Write("b2 = ");
    array[3] = Convert.ToDouble(Console.ReadLine());
    if(array[0] == array[1] && array[2] == array[3]){
        Console.WriteLine("Так как k1 = k2 и b1 = b2 прямые - равны. Что означает что у них бесконечное множество общих точек!");
        Environment.Exit(0);
    }
    if(array[0] == array[1] && array[2] != array[3]){
        Console.WriteLine("Так как k1 = k2 а b1 не равно b2 данные прямые параллельны. Что означает что у них нет общих точек!");
        Environment.Exit(0);
    }
    Console.WriteLine($"Итого мы получили две прямых: y = {array[0]}x + {array[2]}; y = {array[1]}x + {array[3]}");
    return array;
}

double[] array = Fill_numbers();

void Dot(double[] array)
{
    double x = (array[3] - array[2]) / (array[0] - array[1]);
    double y = array[0] * x + array[2];
    Console.WriteLine($"Координата точки пересечения этих двух прямых: ({Math.Round(x, 3)}; {Math.Round(y, 3)})");
}

Dot(array);