// Составте частотный словарь злементов двумерного массива.


Console.Clear();

int[,] CreateRandomArray(int rows, int columns) // Метод заполнения массива
{
   int[,] array = new int[rows, columns];
   for (int i = 0; i < rows; i++)
   {
      for( int j = 0; j < columns; j++)
      {
         array[i, j] = new Random().Next(0, 10);
      }
   }
   return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int EnterNumber(string message) // Метод ввода данных двумерного массива
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void CountValue(int[,] array)
{
    for(int number = 0; number < 10; number++)
    {
        int count = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (number == array[i, j])
                {
                    count++;
                }
            }
        }
        if(count > 0) Console.WriteLine($"Элемент массива {number} встречается в массиве {count} раз.");
    }
    
}




int m = EnterNumber("Введите число строк массива: ");
int n = EnterNumber("Введите число столбцов массива: ");
Console.WriteLine("Созданный массив");
// создаем и заполняем двумерный массив:
int[,] matrix = CreateRandomArray(m, n);
PrintArray(matrix);
Console.WriteLine();
CountValue(matrix);

//Console.WriteLine("Перевернутый массив");
//ChangeRows(matrix);
//ShowArray(matrix);



