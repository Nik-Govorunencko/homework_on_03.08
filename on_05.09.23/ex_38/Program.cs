// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.WriteLine("Сейчас вы увидете массив, состоящий из 6 вещественных чисел, а потом мы покажем вам разницу между макс и мин числами в этом массиве!");

double[] Fill_array()
{
    double[] array = {8.9, 11.9, 74.8, 24.12, 99.89, 18.18}; // ТУТ МОЖНО ИЗМЕНИТЬ МАССИВ!!!
    Console.WriteLine(String.Join("; ", array));
    return array;
}

double[] array = Fill_array();

void Difference_of_numbers(double[] array)
{
    double max_number = array[0];
    double min_number = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max_number < array[i]){
            max_number = array[i];
        }
        else if(min_number > array[i]){
            min_number = array[i];
        }
    }
    Console.WriteLine($"Наибольшое число в данном массиве: {max_number}, а наименьшее {min_number}. А их разность равна: {max_number} - {min_number} = {max_number - min_number}");
}

Difference_of_numbers(array);


