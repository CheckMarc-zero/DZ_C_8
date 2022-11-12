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

            SortReverseArray(desiredArray);
            printArray(desiredArray);
            Console.WriteLine();
        
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

        //Метод создания одномерного массива из строки и сортировки его по убыванию
        int[] CreateRowArray(int[,] array, int rowNumber)
        {
            int[] rowArray = new int[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(1); i++)
            {
                rowArray[i] = array[rowNumber, i];
            }
            Array.Sort(rowArray);
            Array.Reverse(rowArray);
            return rowArray;
        }

        //Метод создания двумерного массива со строками, сортированными по убыванию
        void SortReverseArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] rowArray = CreateRowArray(array, i);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rowArray[j];
                }
            }
        }
    
