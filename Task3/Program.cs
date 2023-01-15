// Программа заполнения массива через функцию, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(" , ", array)} ] ");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}




//Console.WriteLine("Hello, World!");
//int [] boolNum = new int [8];

//for (int i=0; i < 8; i++){
//    boolNum[i] = new Random().Next(0, 2);
//    Console.Write(boolNum[i]);
//}

