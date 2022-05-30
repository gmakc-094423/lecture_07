// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };

string[] output = new string[info.Length];
int[] outputInt32 = new int[info.Length];

ParseArray(data, info, output);

Console.WriteLine(PrintStringArray(output));

for (int i = 0; i < outputInt32.Length; i++)
{
  outputInt32[i] = ConvertToInt32(output[i]);
}


Console.WriteLine(PrintIntArray(outputInt32));

void ParseArray(int[] data, int[] info,  string[] output)
{
  int temp = 0;
  int temp1 = temp;
  for (int i = 0; i < info.Length ; i++)
  {
    temp += info[i];
    for (int j = temp1; j < temp; j++)
    {
      output[i] += data[j];
    }
     temp1 = temp;
  }
}


/* int ConvertToInt32(string str, int index = 0)
    {
        return index == str.Length ? 0 : ConvertToInt32(str, index + 1) + (str[str.Length - 1 - index] == '0' ? 0 : (int)Math.Pow(2, index));
    } */


int ConvertToInt32(string str)
{
  int result = 0;
  int size = str.Length - 1;
  for (int i = size; i >= 0; i--)
  {
    result += ((str[i]) - '0') * Convert.ToInt32(Math.Pow(2, (size - i)));
  }
  return result;
}

string PrintStringArray(string[] array)
{
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],3} ";
  }
  result += " ]";
  return result;
}


string PrintIntArray(int[] array)
{
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],3} ";
  }
  result += " ]";
  return result;
}
