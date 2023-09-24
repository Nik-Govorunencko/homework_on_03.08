// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.WriteLine("Сейчас вы увидите двумерный массив, после чего из него будет убраны столбец и строка, которые пересекают min значение, но перед этим:");
Console.WriteLine();

int[,] CreateAndFillArray()
{
    Console.Write("Напишите количество строк в массиве: ");
    int rowInArray = Convert.ToInt32(Console.ReadLine());
    Console.Write("Напишите количество столбцов в массиве: ");
    int columnInArray = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rowInArray, columnInArray];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

int[] FindMinNumberAndCords(int[,] array)
{
    int[] minNumberCords = new int[2];
    int minNumber = array[0, 0];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(array[i, j] < minNumber){
                minNumber = array[i, j];
                minNumberCords[0] = i;
                minNumberCords[1] = j;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine(minNumber + " - это минимальное число в данном массиве.");
    Console.WriteLine($"Номер его строки: {minNumberCords[0] + 1}, номер его столбца: {minNumberCords[1] + 1}");
    Console.WriteLine();
    return minNumberCords;
}

void PrintArrayWithoutMinCords(int[,] array, int[] minNumberCords)
{
    Console.WriteLine("По итогу мы получили: ");
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(i == minNumberCords[0] || j == minNumberCords[1]){}
            else{
                Console.Write(array[i, j] + " ");
            }
        }
        if(i == minNumberCords[0]){}
        else{
            Console.WriteLine();
        }
    }
}

int[,] array = CreateAndFillArray();
int[] minNumberCords = FindMinNumberAndCords(array);
PrintArrayWithoutMinCords(array, minNumberCords);
