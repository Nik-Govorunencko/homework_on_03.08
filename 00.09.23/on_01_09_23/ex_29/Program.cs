// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите число и мы покажем вам массив состоящий из случайных чисел (количество чисел в этом массиве зависит от введённого вами числа)");

int[] Made_array()
{
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];
    return array;
}

int[] array_1 = Made_array();

void Fill_array(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(String.Join(" ", array));
}

Fill_array(array_1);