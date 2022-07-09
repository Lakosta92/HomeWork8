// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите размерность массива");
int x = Input("Введите значение x= ");
int y = Input("Введите значение y= ");
int z = Input("Введите значение z= ");
int[,,] matrix = new int[x, y, z];
int maxCount = 89;
if (x * y * z > maxCount)
{
    System.Console.WriteLine("Массив слишком большой для выполения условий");
}
else
{
    int[,,] numbers = NumberArray(x, y, z);

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                Console.Write($"[{i} {j} {k}]{numbers[i, j, k]}  ");
            }
             System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }




    int[,,] NumberArray(int size1, int size2, int size3)
    {
        int[,,] array = new int[size1, size2, size3];
        int[] randomValue = new int[maxCount];
        int minNumber = 10;

        for (int i = 0; i < randomValue.Length; i++)
        {
            randomValue[i] = minNumber++;
        }
        for (int i = 0; i < randomValue.Length; i++)
        {
            int randomIndex = new Random().Next(0, randomValue.Length);
            int temp = randomValue[i];
            randomValue[i] = randomValue[randomIndex];
            randomValue[randomIndex] = temp;
        }
        int numberIndex = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = randomValue[numberIndex++];
                }

            }
        }
        return array;

    }

}