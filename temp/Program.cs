// See https://aka.ms/new-console-template for more information
// Console.WriteLine(10%5);
/* string group = string.Empty;
  for (int i = 1; i < 10; i++)
  {
    for (int j = 10; j > 1; j--)
    {
    if (j % i == 0) 
    {
      group += i+" ";
      // Console.WriteLine($"i={i}, j= {j}");
      i++;
    }
    }
  }
Console.WriteLine(group); */



// Console.WriteLine($"{5 % 10}");
// Console.WriteLine($"{10 % 5}");

int[] tempArray = new int[14] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
// tempArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
PrintArr(tempArray);
Console.WriteLine(""); 
CheckArray(tempArray);
Console.WriteLine(""); 
PrintArr(tempArray);

void CheckArray(int[] arrayCheck)
{
  int[] arrayTemp = new int[arrayCheck.Length];
  int m = 0;
  int count = 0;
  int tempNumber = 0;
  int tempSwitch = 0;
  int tempNumber2 = 0;

  for (int i = 0; i < arrayCheck.Length; i++)
  {
    Array.Clear(arrayTemp);
    count = 0;

    if (arrayCheck[i] != 0)
    {

      arrayTemp[count] = arrayCheck[i];
      tempNumber2 = arrayCheck[i];

      for (int j = i; j < arrayCheck.Length; j++)
      {

        if (arrayCheck[j] % tempNumber2 != 0 || arrayCheck[j] / tempNumber2 == 1)
        {
          tempSwitch = 0;
          tempNumber = arrayCheck[j];
          for (int k = 0; k < count; k++)
          {
            if (tempNumber % arrayTemp[k] == 0) tempSwitch++;
          }

          if (tempSwitch == 0)
          {
            arrayTemp[count] = arrayCheck[j];
            count++;
            arrayCheck[j] = 0;
          }
        }

      }
      m++;
      Console.WriteLine($"Группа {m}: {PrintIntArray(arrayTemp)}");

    }
  }
}




void PrintArr(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]}  ");
  }
}



string PrintIntArray(int[] array)
{
  string result = string.Empty;
  // result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
   if (array[i]!=0) result += $"{array[i],1} ";
  }
  // result += " ]";
  return result;
} 
