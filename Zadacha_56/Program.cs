int n = insertNumber("Введите колличество строк в массиве:");
int m = insertNumber("Введите колличество столбцов в массиве:");
int min = insertNumber("Введите минимальное значение членов массива:");
int max = insertNumber("Введите максимальное значение членов массива:");
 Console.WriteLine();

if (n <= 0 || m <= 0 || min > max) Console.WriteLine("Данные введены неправильно.");
  else
 {
    int[,] desiredArray = createArray(n, m, min, max);
    printArray(desiredArray);
    Console.WriteLine();
    

     Console.WriteLine($"Наименьшая сумма элементов у {numberMinSumRow (desiredArray)+1} строки.");

 }





        //Метод ввода данных
        int insertNumber(string message)
        {
            Console.WriteLine(message);
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        //Метод ввода массива
        int[,] createArray(int n, int m, int min, int max)
        {
            int[,] a = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    a[row, col] = new Random().Next(min, max + 1);
                }
            }
            return a;
        }

        //Метод вывода массива
        void printArray(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write($"{array[row, col]}  ");
                }
                Console.WriteLine();
            }
        }

        //Метод создания одномерного массива из строки поиск суммы его элементов
        int SumRowArray(int[,] array, int rowNumber)
        {
            int[] rowArray = new int[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                rowArray[i] = array[rowNumber, i];
            }
           int sum = rowArray.Sum();
            return sum;
        }

        //Метод нахождения строки с наименьшей суммой элементов
        int numberMinSumRow (int [,] array)
        {
            int count = 0;
            int sum = SumRowArray(array,0);
            for (int i = 0; i< array.GetLength(0); i++)
            {
                if (sum>SumRowArray(array,i)) 
                {
                    sum = SumRowArray(array,i);
                    count = i;
                }
            }
            return count;
        }