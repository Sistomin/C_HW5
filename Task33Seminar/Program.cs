// task33 задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

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

int[] myArray = CreateRandomArray(12, -9, 9);
Console.WriteLine("Массив:");
ShowArray(myArray);
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

bool s = false;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] == num)
    {
        s = true;
    }
    
}
Console.WriteLine(s ? "Число присутствует в массиве!" : "Число НЕ присутствует в массиве!");

