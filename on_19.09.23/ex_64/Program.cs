Console.WriteLine("Напишите НАТУРАЛЬНОЕ число, и мы покажем вам все числа в промежутке от него и до 1");

int number = Convert.ToInt32(Console.ReadLine());
if(number < 0){
    Console.WriteLine("НАТУРАЛЬНОЕ ЧИСЛО!!!");
    Environment.Exit(0);
}
if(number == 0){
    Console.WriteLine("Я не знаю что вы хотели увидеть, но ладно: ");
    Console.WriteLine(0);
    Environment.Exit(0);
}
Console.WriteLine();
int[] array = new int[number];
int currentIndex = 0;

int[] ArrayOfNumbers(int number, int[] array, int currentIndex)
{
    if(number > 1){
        array[currentIndex] = number;
        ArrayOfNumbers(number - 1, array, currentIndex + 1);
    }
    else
    {
        array[currentIndex] = number;
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Получили: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

int[] currentArray = ArrayOfNumbers(number, array, currentIndex);
PrintArray(currentArray);