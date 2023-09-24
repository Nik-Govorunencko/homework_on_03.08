Console.WriteLine("Введите число (в котором есть сотни), и мы покажем число сотен в этом числе");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0)
{
    number = number * -1;
}

if(number < 100)
{
    Console.WriteLine("Введите число в котором есть сотни!");
}
else
{
    number = number / 100 % 10;
    Console.WriteLine($"Число сотен в этом числе: {number}");
}

