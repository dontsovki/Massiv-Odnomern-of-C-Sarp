// Функция по перевороту одномерного массива (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Revers(int [] array){
    
    int temp = 0;
    
    for (int i=0; i < array.Length/2; i++){
        temp = array[i];
        array[i] = array[(array.Length - 1) - i];
        array[(array.Length - 1) - i] = temp;
    }

    return array;
}


int [] array = CreateRandomArray(7, -5, 5);
Console.Write("Массив:                  ");
ShowArray(array);

Revers(array);
Console.Write("Отсортированный массив:  ");
ShowArray(array);

