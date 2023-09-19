Console.WriteLine("Введите два числа и мы покажем вам сумму всех чисел от первого ко второму (соотвественно первое число должно быть меньше!!!)");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());
if(numberOne > numberTwo)
{
    Console.WriteLine("Первое число должно быть МЕНЬШЕ чем второе!");
    Environment.Exit(0);
}

void SumOfNumber(int numberOne, int numberTwo)
{
    int sumOfNumbers = 0;
    for(int i = numberOne; i < numberTwo + 1; i++)
    {
        sumOfNumbers += i;
    }
    Console.WriteLine($"Получили число: {sumOfNumbers}");
}

SumOfNumber(numberOne, numberTwo);