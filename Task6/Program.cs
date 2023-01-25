// программа через char[] которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Write("введите число ");
string str = Console.ReadLine();
   Console.WriteLine("Вы ввели не трехзначное число");
char[] a=str.ToCharArray();

Console.Write($"Второе число {a[1]} из числа {str}");