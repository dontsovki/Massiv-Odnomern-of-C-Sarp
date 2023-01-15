// Функция заполнения массива с рандомными данными и функция вывод на экран
int[] CreateRandomArray(int N, int start, int end)   // В скобках указываются элементы которые будут обрабатываться, "Для функции "приготовить яйца", нужны яйца, сковородка, масло"
{
    int[] RandomArray = new int[N];  // Задаем массив в котором будут лежать значения, и определяем его длину. метод new - выделение динамической памяти
    for (int i = 0; i < N; i++)   // цикл. обрабатывает значения от i < N
    {
        RandomArray[i] = new Random().Next(start, end + 1);  // Заполняем массив при помощи метода new Random() в пределах от start до end + 1)
    }
    return RandomArray; // возвращяем заполненный масссив RandomArray
}

void ShowArray(int[] array) // Функция вывода на экран массив RandomArray[i]
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
} 

Console.WriteLine("Введите количество элементов в массиве"); // Запрашиваем у пользователя указать количество элементов в массиве
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());

int[] myRandomArray = CreateRandomArray(num, min, max); // Передаём запрощеные значения в функцию CreateRandomArray(int N, int start, int end)
ShowArray(myRandomArray); // Выводим на экран массив myRandomArray