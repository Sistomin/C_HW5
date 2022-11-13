// Лекция №5

//Двухмерные массивы
/*string[,] table = new string[2, 5];
table[1, 2] = "slovo";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
Console.WriteLine("next code");


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];//3 кол-во строк, 4 кол-во столбцов
PrintArray(matrix);
Console.WriteLine("next code");
FillArray(matrix);
PrintArray(matrix);*/

//рекурсия на примере факториала
/*double Factorial(int n)
{
    if (n == 1) return 1;

    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"Факториал числа {i} = {Factorial(i)}");
}*/

//рекурсия на примере фибоначи
double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"Число Фибаначи от {i} = {Fibonacci(i)}");
}