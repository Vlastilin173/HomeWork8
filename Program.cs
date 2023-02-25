// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный массив: ");
// ReleaseMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// Console.WriteLine("Отсортированный массив: ");
// ReleaseMatrix(matrix);

// void InputMatrix(int[,] matrix)  //Заполнение массива
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)  // Сортировка
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// void ReleaseMatrix(int[,] matrix)   // Вывод
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {   
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();
// int n = 4;
// int m = 4;
// int[,] matrix = new int[n, m];

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintMatrix(int[,] matrix)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// InputMatrix(matrix);
// int indexLine = 0;
// int ReleaseMatrix(int[,] matrix)
// {
//     int minRow = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//         minRow += matrix[0, i];

//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sumRow += matrix[i, j];
//         }
//         if (minRow > sumRow)
        
//         {
//         minRow = sumRow;
//         indexLine++;
//         }
            
            
//     }
//     return minRow;
// }

// Console.WriteLine();
// Console.WriteLine("Начальный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine();
// Console.WriteLine($"Результат: {ReleaseMatrix(matrix)}");
// Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (indexLine +1));




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11);
//     }
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }

// int[,] ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
// {
//     int[,] result = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
//     for (int i = 0; i < FirstMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < FirstMatrix.GetLength(1); j++)
//             result[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
//     }
//     return result;
// }

// Console.Clear();
// int[,] FirstMatrix = new int[2,2]; //Размер первой матрицы
// int[,] SecondMatrix = new int[2,2]; //Размер второй матрицы
// InputMatrix(FirstMatrix);
// InputMatrix(SecondMatrix);
// Console.WriteLine("Первый массив: ");
// PrintMatrix(FirstMatrix);
// Console.WriteLine();
// Console.WriteLine("Второй массив: ");
// PrintMatrix(SecondMatrix);
// Console.WriteLine();
// Console.WriteLine("Результат:");
// PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void InputMatrix(int[,,] matrix)
// {
//     int number = 1;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//                 matrix[i, j, k] = number++; 
//         }
//     }
// }

// void PrintMatrix(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//                 Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
//         }
//     }
// }

// Console.Clear();
// int[,,] matrix = new int[2,2,2]; //Изменение размеров матрицы
// InputMatrix(matrix);
// PrintMatrix(matrix);


// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

// int factorial(int n)
// {
//     int i, x = 1;
//     for (i = 1; i <= n; i++)
//     {
//         x *= i;
//     }
//     return x;
// }

// void ReleaseTask(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j <= (n - i); j++)
//         {
//             Console.Write(" ");
//         }
//         for (int j = 0; j <= i; j++)
//         {
//             Console.Write(" ");
//             Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк треугольника Паскаля: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ReleaseTask(n);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        j++;
    else if (i < j && i + j >= size - 1)
        i++;
    else if (i >= j && i + j > size - 1)
        j--;
    else
        i--;
    num++;
}

Console.Clear();
Console.WriteLine("Спиральный массив: ");
PrintArray(array);