// Функция заполнения массива с рандомными данными и функция вывод на экран и функция запись в файл, с костылём

int[] CreateRandomArray(int N, int start, int end)   // В скобках указываются элементы которые будут обрабатываться, "Для функции "приготовить яйца", нужны яйца, сковородка, масло"
{
    int[] RandomArray = new int[N];  // Задаем массив в котором будут лежать значения, и определяем его длину. метод new - выделение динамической памяти
    for (int i = 0; i < N; i++)   // цикл. обрабатывает значения от i < N
    {
        RandomArray[i] = new Random().Next(start, end + 1);  // Заполняем массив при помощи метода new Random() в пределах от start до end + 1)
    }
    return RandomArray; // возвращяем заполненный масссив RandomArray
}

string NamberToString(int[] arrayres) // Функция Костыль для перевода числового массива в строковый
{
    string strigres = string.Join(string.Empty, arrayres); //метод для объединения элементов массива с разделителем

    return strigres;
}

void WritingToFile(string res) //Функция записи пезультата в файл
{
string path = @"file.txt"; // Создаём файл
File.WriteAllText(path, res); // метод файлового класса, который используется для создания нового файла. Чертовка не работает с маиссивом из числовых значений int, нужно переделывать весь код на строку
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
string s = NamberToString(myRandomArray);
WritingToFile(s);