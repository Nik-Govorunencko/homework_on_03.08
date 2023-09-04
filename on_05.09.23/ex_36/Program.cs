// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Напишите число, которое обозначит количество чисел в массиве, а потом мы выведем на экран сумму всех чисел в данном массиве, стоящих на нечётных позициях.");

int[] Fill_array()
{
    int number = Convert.ToInt32(Console.ReadLine());
    if(number < 0){
        Console.WriteLine("Напишите любое положительное число! (не пешите отрицательное, так-как массива с отриц. кол-вом элементов быть не может!)");
    }
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}

int[] array = Fill_array();

void Count_of_numbers(int[] array)
{
    int i = 1;
    int sum_of_numbers = 0;
    while(i < array.Length){
        sum_of_numbers = sum_of_numbers + array[i];
        i = i + 2;
    }
    Console.WriteLine($"Сумма всех чисел на нечётных позициях равна: {sum_of_numbers}");
}

Count_of_numbers(array);

