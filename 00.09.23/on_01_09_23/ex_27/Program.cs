// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число, и мы покажем вам сумму чисел в этом числе.");

int Sum_ofnumbs_innumb()
{
    int number = Convert.ToInt32(Console.ReadLine());
    int sum_numbers = 0;
    if(number < 0)
    {
        number = number * -1;
    }
    while(number > 0)
    {
        sum_numbers = sum_numbers + (number % 10);
        number = number / 10;
    }
    return sum_numbers;
}

int sum_of_numbers = Sum_ofnumbs_innumb();
Console.WriteLine($"Сумма чисел в этом числе равна: {sum_of_numbers}");
