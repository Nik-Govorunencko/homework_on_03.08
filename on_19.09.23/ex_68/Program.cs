Console.WriteLine("Введите два не отрицательных числа и мы покажем вам что получилось по функции Аккермана");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if(m < 0 || n < 0 || (m == 0 && n == 0))
{
    Console.WriteLine("Введите не отрицательные числа, или не два нуля!");
    Environment.Exit(0);
}

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if(m > 0 && n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}

int result = Akk(m, n);
Console.WriteLine($"Вот что получилось: {result}");