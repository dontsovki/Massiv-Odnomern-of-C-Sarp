// Функция заполнения массива с входящими данными и функция вывод его на экран
int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива"); // Просим у пользователя ввести длину массива
    int size = Convert.ToInt32(Console.ReadLine());  // присвиваем длину к меременноц size
    int[] array = new int[size];  // Задаем массив в котором будут лежать значения, и определяем его длину. метод new - выделение динамической памяти
    for (int i = 0; i < size; i++)  // Цикл заполнения массива array[i]
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)  // Функция вывода на экран массив array[i]
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateArray();
ShowArray(myArray);
