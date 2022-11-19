// Task37 Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int[] CreateRandomArray(int N, int start, int end)//рандомный по параметрам
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array) //ввыод массива на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(7, -10, 10);
Console.WriteLine("Массив:");
ShowArray(myArray);
for (int i = 0; i < myArray.Length / 2; i++)
{
    Console.Write(myArray[i] * myArray[myArray.Length - i - 1] + " ");
}
if (myArray.Length % 2 != 0)
{
    Console.Write(myArray[myArray.Length / 2] + " ");
}