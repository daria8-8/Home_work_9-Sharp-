void Ex64()
{
 Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Натуральные числа в промежутке от N до 1 :");
Stroka(N);
Console.WriteLine();
void Stroka(int N)
{
    if (N<=0)
    {
        return;
    }
    else
    {
        Console.Write($"{N} ");
        Stroka(N - 1);
    }
}
}

void Ex66()
{
Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()?? "0");
Console.Write("Сумма чисел от M до N равна: ");
Console.WriteLine(Summ(M,N));
 
int Summ(int M, int N)
{    
  if (M == N) return (M+N)/2;    //return M                  
  else if (M < N) return N + Summ(M, N - 1);
  else return 0;   
}
}

void Ex68()
{
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine()?? "0");

Console.Write($"A(m,n) = ");
Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if ((n == 0)&&(m != 0))  return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}
}
Ex64();
Ex66();
Ex68();
