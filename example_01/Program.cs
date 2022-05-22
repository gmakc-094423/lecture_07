// See

Console.WriteLine(NumberRec(1, 10));

string NumberRec(int a, int b)
{
if (a <= b) return $"{a} " + NumberRec(a + 1, b);
else return String.Empty;
}

Console.WriteLine(NumberReversRec(1, 10));

string NumberReversRec(int a, int b)
{
  if (a <= b) return NumberReversRec(a + 1, b) + $"{a} ";
  else return String.Empty;
}
