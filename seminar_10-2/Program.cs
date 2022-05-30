// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

int a = InputNumbers("Введите первое число: ");
int b = InputNumbers("Введите второе число: ");
int n = InputNumbers("Введите число N: ");


Console.WriteLine(SumBetween(a, b, n)+", ");

int SumBetween(int numberFirst, int numberSecond, int n)
{
    if (n > 0)  return numberFirst + SumBetween(numberSecond, numberFirst + numberSecond, n-1);
  else return numberFirst;  
  // SumBetween(numberFirst + numberSecond, numberSecond, n-1);
  // Console.WriteLine(numberFirst);
}

// string NumberRec(int a, int b)
// {
// if (a <= b) return $"{a} " + NumberRec(a + 1, b);
// else return String.Empty;
// }


// void PrintNumber(int n, int count)
// {
//   if (count > n) return;
//   PrintNumber(n, count + 1);
//   Console.Write(count + ", ");
// }


/* void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
 */


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}







/* 
int number1 = Input("Введите значение 1: ");
int number2 = Input("Введите значение 2: ");
int count = Input("Введите значение N: ");

for (int i = 0; i < count; i++)
{
    Console.Write(SumBetweenNumbers(number1, number2, i) + " ");
}
Console.WriteLine();

int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumBetweenNumbers(int numberFirst, int numberSecond, int numberCount)
{
    if (numberCount == 0)
    {
        return numberFirst;
    }
    else if (numberCount == 1)
    {
        return numberSecond;
    }
    else
    {
        
        return  SumBetweenNumbers(numberFirst, numberSecond, numberCount - 1) + SumBetweenNumbers(numberFirst, numberSecond, numberCount - 2);
    }
}
 */




/* 
 int n1 = InputNumber("n1 = ");
int n2 = InputNumber("n2 = ");
int N = InputNumber("N = ");

OutputNumbers(n1, n2, N);

void OutputNumbers(int n1, int n2, int N)
{
    if (N == 2)
    {
        Console.Write($"{n1} {n2}");
    }
    else
    {
        Console.Write($"{n1} ");
        OutputNumbers(n2, n1 + n2, N - 1);
    }
}

int InputNumber(string message)
{
    Console.Write(message);
    return Int32.Parse(Console.ReadLine());
}
 */