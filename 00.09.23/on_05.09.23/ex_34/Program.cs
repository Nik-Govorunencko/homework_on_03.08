// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Напишите число, и мы покажем вам массив заполненый случайными числами, а также количество чётных чисел. (в зависимости от введённого вами числа меняется количество цифр в массиве)");

int[] Fill_array()
{
    int number = Convert.ToInt32(Console.ReadLine());
    if(number < 0){
        Console.WriteLine("Напишите любое положительное число! (не пешите отрицательное, так-как массива с отриц. кол-вом элементов быть не может!)");
    }
    int[] array = new int[number];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;
}

int[] array = Fill_array();

void Even_numbers_inarray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"И того чётных чисел в данном массиве: {count}");
}

Even_numbers_inarray(array);

