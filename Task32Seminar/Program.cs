// task32 Замена элементов массива, положительные элементы замените на соотвествующие отрицательные, и на оборот.
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

int[] myArray = CreateRandomArray(4, -9, 9);
Console.WriteLine("Исходный массив:");
ShowArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = myArray[i] * -1;
}
Console.WriteLine("Негативный массив:");
ShowArray(myArray);
