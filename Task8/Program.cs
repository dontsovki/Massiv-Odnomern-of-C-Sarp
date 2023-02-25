// Функции перевода массива чисел в строку
// функция преобразования числового массива в строку
// int[] bases = { 2, 8, 10, 16};
// int[] numbers = { Int32.MinValue, -19327543, -13621, -18, 12,
//                              19142, Int32.MaxValue };

// foreach (int baseValue in bases)
// {
//    Console.WriteLine("Base {0} conversion:", baseValue);
//    foreach (int number in numbers)
//    {
//       Console.WriteLine("   {0,-15}  -->  0x{1}",
//                         number, Convert.ToString(number, baseValue));
//    }
// }

// public class Example  // Метод перевода массива в строку использование имеет конструктор, который принимает массив символов в качестве параметра и инициализирует новый экземпляр класса String соответствующими символами. В следующем примере создается экземпляр строки из массива символов
// {
//     public static void Main()
//     {
//         char[] chars = {'s', 'o', 'm', 'e', ' ', 's', 't', 'r', 'i', 'n', 'g'};
 
//         string s = new string(chars);
 
//         Console.WriteLine(s);        // какая-то строка
//     }
// }

public class Example  // Метод перевода массива в строку использование String.Join метод для объединения элементов массива с разделителем
{
    public static void Main()
    {
        char[] chars = {'s', 'o', 'm', 'e', ' ', 's', 't', 'r', 'i', 'n', 'g'};
 
        string s = string.Join(string.Empty, chars);
 
        Console.WriteLine(s);        // какая-то строка
    }
}