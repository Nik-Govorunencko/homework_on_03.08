Console.Write("Напишите число, и мы покажем вам чётное ли оно: ");
int number = Convert.ToInt32(Console.ReadLine());
int number_2 = number % 2;
if(number_2 == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число не является чётным");
}

