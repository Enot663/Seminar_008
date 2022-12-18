﻿// See https://aka.ms/new-console-template for more information
Console.Clear();



void ShowArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($" {array[i, j]} ");        
      }
      Console.WriteLine();
   }
}

void ChangeRows(int[,] array)
{
   for (int i = 0; i < array.GetLength(1); i++)
   {
    int k = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = k;   
   }
   
   
}

int[,] CreateRandomArray(int rows, int columns) // Метод заполнения массива
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for( int j = 0; j < columns; j++)
      {
         array[i, j] = new Random().Next(0, 20);
      }
   }
   return array;
}

int EnterNumber(string message) // Метод ввода данных двумерного массива
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// получить от пользователя m и n:

int m = EnterNumber("Введите число строк массива: ");
int n = EnterNumber("Введите число столбцов массива: ");
Console.WriteLine("Созданный массив");
// создаем и заполняем двумерный массив:
int[,] matrix = CreateRandomArray(m, n);

ShowArray(matrix);
Console.WriteLine("Перевернутый массив");
ChangeRows(matrix);
ShowArray(matrix);