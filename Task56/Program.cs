// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);

int min = int.MaxValue;
int summa=0;
int indexLine=0;

for (int i = 0; i < array.GetLength(0); i++)
{
    summa=0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
       summa+=array[i,j];
    }
    if (summa<min)
    {
        min=summa;
        indexLine=i;
    }
}
System.Console.WriteLine();
Console.WriteLine($"{indexLine+1} строка является наименьшей по сумме элементов");

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}


