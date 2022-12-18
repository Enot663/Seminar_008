// Задайте двумерный массив. Напишите программу которая заменяет строки на столбцы.
// В случае, если это не возможно, программа должна вывести сообщение пользователю.

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

void RowsColumns(int[,] array)
{
   if (array.GetLength(0) == array.GetLength(1))
   {
      int[,] nums = new int[array.GetLength(0), array.GetLength(1)];
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            nums[i, j] = array[i, j];
         }
      }
      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            array[i, j] = nums[j, i];                        
         }
      }
      
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
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
RowsColumns(matrix);
ShowArray(matrix);