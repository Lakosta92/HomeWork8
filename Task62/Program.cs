// Задача 62: Заполните спирально массив 4 на 4.
Console.Clear();

System.Console.Write("Введите размер массива  ");
int x = Convert.ToInt32(Console.ReadLine());
int y = x;

int[,] array = new int [x, y];

int number = 1;
int i = 0;
int j = 0;

while (number <= x * x)
{
    array[i, j] = number;

    if (i <= j + 1 && i + j < x- 1)
    {
        ++j;
    }
    else if (i < j && i + j >=  x- 1)
    {
        ++i;
    }
    else if (i >= j && i + j > x - 1)
    {
        --j;
    }
    else
    {
        --i;
    }
    ++number;
}

for (int k = 0; k < array.GetLength(0); k++)
{
    for (int z = 0; z < array.GetLength(1); z++)
    {
        Console.Write(array[k, z] + " ");
    }
    System.Console.WriteLine();
}