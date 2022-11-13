int n = insertNumber("Введите колличество строк и столбцов в массиве:");
int min = insertNumber("Введите минимальное значение членов массива:");
int max = insertNumber("Введите максимальное значение членов массива:");
Console.WriteLine();

if (n<=0 || min>max) Console.WriteLine("Данные введены неправильно.");
else
{
   int [,] desiredArray = createArray(n,min,max);
   printArray(desiredArray);
   Console.WriteLine();

}



//Метод ввода данных
int insertNumber (string message)
{
    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод ввода массива
int [,] createArray(int n, int min, int max)
{
    int [,] array = new int [n,n];
    for (int count = 0; count < n/2 ; count++)
    {
       for (int j = count; j < n-count; j++)  {
        array[count,j] = new Random().Next(min,max+1);
        Console.WriteLine($"{array[count,j]} ( {count} ,{j} )");
       }

       for (int i = count+1; i < n-count; i++) 
       {
        array[i,n-count-1] = new Random().Next(min,max+1);
        Console.WriteLine($"{array[i,n-count-1]} ( {i} ,{n-count-1} )");
        }

       for (int j = n-count-2; j>=0+count; j--) {
        array[n-count-1,j] = new Random().Next(min,max+1);
        Console.WriteLine($"{array[n-count-1,j]} ( {n-count-1} ,{j} )");
        }
       for (int i = n-count-2; i>=1+count; i--) 
       {
       array[i,count] = new Random().Next(min,max+1);
       Console.WriteLine($"{array[i,count]} ( {i} ,{count} )");
       }
    }
    if (n%2 != 0) 
    {
        array [n/2,n/2] = new Random().Next(min,max+1);
        Console.WriteLine($"{array[n/2,n/2]} ( {n/2} ,{n/2} )");
    }

    Console.WriteLine();
    Console.WriteLine("Полученная матрица:");
    
    return array;
}

//Метод вывода массива
void printArray( int[,] array)
{
    for (int row = 0; row < array.GetLength(0) ; row++)
    {
       for (int col = 0; col < array.GetLength(1) ; col++) 
       {
        Console.Write($"{array[row,col]}  ");
       }
       Console.WriteLine();
    }
}
