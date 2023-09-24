// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа, и мы покажем вам первое число в степени второго (x y --> x^y)");

int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());

void Degree_numbers(int number_1, int number_2)
{
    int number_1_2 = number_1;
    while(number_2 > 1)
    {
        number_1 = number_1 * number_1_2;
        number_2 = number_2 - 1;
    }
    Console.WriteLine($"Итоговое число: {number_1}");
}

Degree_numbers(number_1, number_2);
