Console.Write("Введите трехзначное число, и мы покажем вам его десятки: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number = number * -1;
}

if(number > 999 || number < 100)
{
    Console.WriteLine("Введите трёхзначное число!");
}
else
{
    number = number / 10 % 10;
    Console.WriteLine($"Число его десятков: {number}");
}