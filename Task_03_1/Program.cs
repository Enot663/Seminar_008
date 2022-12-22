//  В двумерном массиве целых чисел. Удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент
Console.Clear();

int EnterNumber(string message) // Метод ввода данных двумерного массива
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void ShowArray(int[,] array) // Вывод массива на печать.
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

int[,] CreateRandomArray(int rows, int columns) // Метод заполнения массива
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for( int j = 0; j < columns; j++)
      {
         array[i, j] = new Random().Next(1, 10);
      }
   }
   return array;
}

void FindingLess(int[,]array)
{
   int minLine = 0;
   int minColumn = 0;
   int min = array[0, 0];
   for (int i = 0; i < array.GetLength(0); i++)   
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if(array[i, j] < min)
         min = array[i, j];
         minLine = i;
         minColumn = j;         
      }
      
   }
   NewArray(array, minLine, minColumn);
   Console.WriteLine($"Минимальное значение ->->-> {min}.");
}

void NewArray(int[,]array, int minLine, int minColumn)
{
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                
                if ((i == minLine) || (j == minColumn))
                    continue;
                else
                Console.Write(array[i, j] + " ");
                
            }
            Console.WriteLine();
}
}


// получить от пользователя m и n:
int m = EnterNumber("Введите число строк массива: ");
int n = EnterNumber("Введите число столбцов массива: ");
Console.WriteLine();
// создаем и заполняем двумерный массив:
int[,] matrix = CreateRandomArray(m, n);

ShowArray(matrix);
Console.WriteLine();
FindingLess(matrix);