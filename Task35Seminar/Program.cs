// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].

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
int[] myArray = CreateRandomArray(123, -100, 100);
Console.WriteLine("Массив:");
ShowArray(myArray);
int num = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 9 && myArray[i] <100)
    {
        num = num + 1;
    }
}
Console.WriteLine($"Количество элементов массива лежащих в диапозоне [10,99] равно {num}!");
