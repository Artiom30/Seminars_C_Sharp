

int[,] CreateRandom2DArray()
{
    Console.WriteLine("Imput number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
//           по убыванию элементы каждой строки двумерного массива.
//           Например, задан массив:
//                  1 4 7 2
//                  5 9 2 3
//                  8 4 2 4
//       В итоге получается вот такой массив:
//                  7 4 2 1
//                  9 5 3 2
//                  8 4 4 2
/*
void ArrayStingMaxMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            int maxj = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, maxj]) maxj = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, maxj];
            array[i, maxj] = temp;
        }
}
int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
Console.WriteLine();
ArrayStingMaxMin(newArray);
Show2DArray(newArray);
*/

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
//           которая будет находить строку с наименьшей суммой элементов.
//              Например, 
//            задан массив:
//              1 4 7 2
//              5 9 2 3
//              8 4 2 4
//              5 2 6 7
//       Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//       наименьшей суммой элементов: 1 строка. (i + 1)
/*
int[,] CreateRandomMarix()
{
    Console.WriteLine("Imput a Matrix size: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int columns = rows;
    Console.WriteLine("Imput a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Imput a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int EventMinString(int[,] array)
{
    int[] sumOfNumsStr = new int[array.GetLength(0)];
    int minStr = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumOfNumsStr[i] = sum;
    }

    for (int i = 0 ; i < sumOfNumsStr.Length; i++)
    {
        if (sumOfNumsStr[i] < sumOfNumsStr[minStr]) minStr = i;
    }    
    return minStr + 1;

}

int[,] matrix = CreateRandomMarix();
Show2DArray(matrix);
Console.WriteLine();
int minStr = EventMinString(matrix);
Console.WriteLine($" The min row is {minStr}");
*/

// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить
//            произведение двух матриц.
//              Например,
//              даны 2 матрицы:
//              2 4 | 3 4
//              3 2 | 3 3
//            Результирующая матрица 
//              будет:
//              18 20
//              15 18

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//           Напишите программу, которая будет построчно выводить массив, добавляя 
//           индексы каждого элемента.
//           Массив размером 2 x 2 x 2
//              66(0,0,0) 25(0,1,0)
//              34(1,0,0) 41(1,1,0)
//              27(0,0,1) 90(0,1,1)
//              26(1,0,1) 55(1,1,1)

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
//            Например, на выходе получается вот такой массив:
//              01 02 03 04
//              12 13 14 05
//              11 16 15 06
//              10 09 08 07














// mathProfi - математика...
