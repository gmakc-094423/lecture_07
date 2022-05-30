// число от 1 до 10 рекурсия

Console.WriteLine(NumberRec(1, 10));

string NumberRec(int a, int b)
{
if (a <= b) return $"{a} " + NumberRec(a + 1, b);
else return String.Empty;
}

// число от 19 до 1 рекурсия
Console.WriteLine(NumberReversRec(1, 10));

string NumberReversRec(int a, int b)
{
  if (a <= b) return NumberReversRec(a + 1, b) + $"{a} ";
  else return String.Empty;
}
Console.ReadKey();

// сумма чисел

int SumIoN(int n)
{
  if (n == 0) return 0;
  else return n + SumIoN(n-1);
}
Console.WriteLine(SumIoN(10));

// факториал

int FactorialN(int n)
{
  if (n == 1) return 1;
  else return n*FactorialN(n-1);
}
Console.WriteLine(FactorialN(10));