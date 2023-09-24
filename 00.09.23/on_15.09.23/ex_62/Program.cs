// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Вы увидете двумерный массив 4 на 4, который заполняется спирально!");
Console.WriteLine();

int[,] CreateAndFillArray()
{
    int[,] array = new int[4, 4];
    int currentNumb = 1;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i != 0)
            {
                break;
            }
            else
            {
                array[i, j] = currentNumb;
                currentNumb++;
                if(j == 3){
                    i++;
                }
            }
        }
        array[i, 3] = currentNumb;
        currentNumb++;
        if(i == 3){
            for(int j1 = 2; j1 > -1; j1--){
                array[i, j1] = currentNumb;
                currentNumb++;
            }
        }
    }
    for(int i = 2; i > 0; i--){
        array[i, 0] = currentNumb;
        currentNumb++;
        if(i == 1){
            for(int j = 1; j < 3; j++){
                array[i, j] = currentNumb;
                currentNumb++;
                if(j == 2){
                    array[i + 1, j] = currentNumb;
                    currentNumb++;
                    array[i + 1, j - 1] = currentNumb;
                }
            }
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int number = 0;
    string numberString = ("");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            number = array[i, j];
            if(number / 10 < 1)
            {
                numberString = Convert.ToString(array[i, j]);
                numberString = ("0" + number);
                Console.Write(numberString + " ");
            }
            else
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }
}

int[,] array = CreateAndFillArray();
PrintArray(array);