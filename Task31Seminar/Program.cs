// task31

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
ShowArray(myArray);

int sum_pos = 0;
int sum_neg = 0;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] >0)
        {
    sum_pos += myArray[i];    
    }
    else
    {
        sum_neg += myArray[i];
    }
}

Console.WriteLine($"Сумма положительных: {sum_pos} Сумма отрицательных: {sum_neg}");
