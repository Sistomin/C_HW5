// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int[] myArray = CreateRandomArray(8, 1, 10);
Console.WriteLine("Массив:");
ShowArray(myArray);
int num = 0;
for (int i = 1; i < myArray.Length; i = i + 2)
{
    num = num + myArray[i];
}
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях: {num}");