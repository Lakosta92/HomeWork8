// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Первая матрица: ");
int[,] matrix = new int[3, 3];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
int[,] matrix2 = new int[3, 3];
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

Console.WriteLine("Результат перемножения матриц: ");
int[,] finalMatrix = new int[3, 3];
MatrixMultiplication(finalMatrix);
PrintArray(finalMatrix);



void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                finalMatrix[i, j] += matrix[i, k] * matrix2[k, j];
            }

        }
    }
}

