Console.WriteLine("Введите день недели (цифрой) и мы скажем вам является ли этот день выходным");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1 || number > 7)
{
    Console.WriteLine("Это не является днём недели");
}
else
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("Да, этот день является выходным");
    }
    else
    {
        Console.WriteLine("Нет, это не выходной");
    }
}
