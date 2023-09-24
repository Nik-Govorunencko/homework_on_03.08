// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("В этой программе вы увидите две матрицы, после чего вы увидите их перемножение (при чём кол-во строк и столбцов задаёте вы!).");
Console.WriteLine();

int[,] CreateAndFillMatrix1()
{
    Console.Write("Напишите количество строк первой матрицы: ");
    int rowMatrix1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Напишите количество столбцов первой матрицы: ");
    int coloumnMatrix1 = Convert.ToInt32(Console.ReadLine());
    int[,] matrix1 = new int[rowMatrix1, coloumnMatrix1];
    for(int i = 0; i < matrix1.GetLength(0); i++){
        for(int j = 0; j < matrix1.GetLength(1); j++){
            matrix1[i, j] = new Random().Next(1, 101);
            Console.Write(matrix1[i, j] + "\t");
        } 
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}

int[,] CreateAndFillMatrix2(int[,] matrix1)
{
    Console.Write("Напишите количество строк второй матрицы: ");
    int rowMatrix2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Напишите количество столбцов второй матрицы: ");
    int coloumnMatrix2 = Convert.ToInt32(Console.ReadLine());
    int[,] matrix2 = new int[rowMatrix2, coloumnMatrix2];
    if(matrix1.GetLength(1) != rowMatrix2){
        Console.WriteLine();
        Console.Write("Количество столбцов первой матрицы должны совпадать с количеством строк второй!!! Перезапустите программу.");
        Environment.Exit(0);
    }
    for(int i = 0; i < matrix2.GetLength(0); i++){
        for(int j = 0; j < matrix2.GetLength(1); j++){
            matrix2[i, j] = new Random().Next(1, 101);
            Console.Write(matrix2[i, j] + "\t");
        } 
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix2;
}

int[,] matrix1 = CreateAndFillMatrix1();
int[,] matrix2 = CreateAndFillMatrix2(matrix1); // мы подаём первую матрицу чтобы проверить соотвествует ли кол-во столбцов первой с кол-вом строк второй

void MultiOfMatrix(int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine("Получили:");
    int multiOfNumbers = 0;
    int j1 = 0;
    for(int i1 = 0; i1 < matrix1.GetLength(0); i1++)
    {
        for(int j2 = 0; j2 < matrix2.GetLength(1); j2++)
        {
            for(int i2 = 0; i2 < matrix2.GetLength(0); i2++)
            {
                multiOfNumbers += matrix1[i1, j1] * matrix2[i2, j2];
                j1++;
            }
            Console.Write(multiOfNumbers + "\t");
            multiOfNumbers = 0;
            j1 = 0;
        }
        Console.WriteLine();
    }
}

MultiOfMatrix(matrix1, matrix2);