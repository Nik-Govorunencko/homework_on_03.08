// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Напишите число, которое обозначит количество чисел в массиве, а потом сами напишите каждое число для заданного вами массива. Мы покажем сколько чисел >0 вы написали!");

int[] Create_array()
{
    Console.Write("Чисел в данном массиве: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number <= 0){
        Console.WriteLine("Напишите любое положительное число! (не пешите отрицательное, так-как массива с отриц. кол-вом элементов быть не может! Также не пешите 0, потому-что массив с нулём элементов - это бессмысленно!)");
        Environment.Exit(0);
    }
    int[] array = new int[number];
    return array;
}

int[] array = Create_array();

int[] Fill_array(int[] array)
{
    int number = 0;
    int count_number = 1;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{count_number} число в массиве равно: ");
        number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
        count_number++;
    }
    Console.WriteLine("А вот весь получившийся массив:");
    Console.WriteLine(String.Join(" ", array));
    return array;
}

int[] filled_array = Fill_array(array);

void Numbers_in_array(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            count++;
        }
    }
    Console.WriteLine($"Всего чисел больше нуля в данном массиве: {count}");
}

Numbers_in_array(filled_array);