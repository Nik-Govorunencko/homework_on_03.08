int number = 55;
if(number < 10000 || number > 99999)
    {
     Console.WriteLine("Число не пятизначное");
    }
    int num_1 = number % 100;
    int num_2 = (number / 10000) + (((number / 1000) % 10) * 10);
    bool result = num_1 == num_2;
    if(num_1 == num_2)
    {
        Console.WriteLine($"{result}");
    }
    else
    {
        Console.WriteLine($"{result}");
    }
