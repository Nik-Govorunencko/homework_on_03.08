Console.WriteLine("Напишите число, и мы покажем все четные числа между ним и 0.");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    while(number > 0)
    {
        Console.Write(number + " ");
        number = number - 2;
    }
}
else
{
    number = number - 1;
    while(number > 0)
    {
        Console.Write(number + " ");
        number = number - 2;
    }
}

