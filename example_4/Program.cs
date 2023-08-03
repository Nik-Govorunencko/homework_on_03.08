Console.WriteLine("Напишите три числа, и мы покажем вам наибольшее.");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number2 > max)
{
    Console.WriteLine("Наибольшее число: " + number2);
}
else if(number3 > max)
{
    Console.WriteLine("Наибольшее число: " + number3);
}
else
{
    Console.WriteLine("Наибольшее число: " + max);
}
