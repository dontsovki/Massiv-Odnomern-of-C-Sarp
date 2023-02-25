// Функция нахождения суммы элементов 3 чесел в массиве 
int[] GetRangeSum1(int[] array, int m)
{
  int n = array.Length;
  int[] t = new int[n - m + 1];

  int index = 0;

  for (int i = 0; i <= n - m; i++)
  {
    for (int j = i; j < i + m; j++)
    {
      t[index] += array[j];
    }
    index++;
  }
  return t;
}

int[] GetRangeSum2(int[] array, int m)
{
  int n = array.Length;
  int[] t = new int[n - m + 1];

  int index = 0;
  for (int i = 0; i < m; i++) t[index] += array[i];

  for (int i = 1; i <= n - m; i++)
  {
    index++;
    t[index] = t[index - 1] - array[i - 1] + array[i + m - 1];
  }
  return t;
}


int[] CreateArray(int size) => new int[size];

string Print(int[] array) => $"[{String.Join(", ", array)}]";

void Fill(ref int[] array) => array = array.Select(e => Random.Shared.Next(10)).ToArray();

int[] numbers = CreateArray(5);
Fill(ref numbers);
Console.WriteLine(Print(numbers));

int count = 2;
int[] sumGroupNumbers = GetRangeSum2(numbers, count);
Console.WriteLine(Print(sumGroupNumbers));

Console.WriteLine("+");