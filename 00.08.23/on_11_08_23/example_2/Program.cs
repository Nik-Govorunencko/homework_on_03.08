Console.WriteLine("Напишите два числа, и мы покажем вам какое большее а какое меньшее.");
int number2 = Convert.ToInt32(Console.ReadLine());
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.Write("Наибольшее число: " + number1 + ", а наименьшее: " + number2);
}
else
{
    Console.Write("Наибольшее число: " + number2 + ", а наименьшее: " + number1);
}
