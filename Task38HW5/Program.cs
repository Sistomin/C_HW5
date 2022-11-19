// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int[] myArray = CreateRandomArray(8, 1, 100);
Console.WriteLine("Массив:");
ShowArray(myArray);

int maxNum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (maxNum < myArray[i])
    {
        maxNum = myArray[i];
    }
}
Console.WriteLine($"Max number: {maxNum}");

int minNum = 101;
for (int i = 0; i < myArray.Length; i++)
{
    if (minNum > myArray[i])
    {
        minNum = myArray[i];
    }
}
Console.WriteLine($"Min number: {minNum}");
int result = maxNum - minNum;
Console.WriteLine($"Pазницa между максимальным и минимальным элементом массива: {result}");