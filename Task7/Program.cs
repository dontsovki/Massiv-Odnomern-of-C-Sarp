//  Программа запрашивает у пользователячисло, вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите числа через запятую: ");     //1. Пользователь вводит число
int[] numbers = StringToNum(Console.ReadLine());    //2 передаём в функцию StringToNum введёное значение 3. Передаем введёные значения пользователя numbers[index], которые были обработаны в функции StringToNum, в массив numbers
PrintArray(numbers);    //4. распечатываем переданный массив numbers
CountingPositiveNumbers(numbers);       // 5. Функция CountingPositiveNumbers принимает на обработу массив numbers

void CountingPositiveNumbers(int[] Positiv)       // 5. Функция посчитайте, сколько чисел больше 0 ввёл пользователь.
{
int PositiveNumbers = 0;

for (int i = 0; i < Positiv.Length; i++)
{
    if (Positiv[i] > 0)
    {
        PositiveNumbers++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {PositiveNumbers}");
}


int[] StringToNum(string input)     // 2. Функция заполнения массива через строку
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)        // 4. Функция распечатывание массива на экран
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}