int m = insertNumber("Введите колличество столбцов первой и колличество строк второй матриц:");
int l = insertNumber("Введите колличество строк первой матрицы:");
int n = insertNumber("Введите колличество столбцов второй матрицы:");
int min = insertNumber("Введите минимальное значение членов матриц:");
int max = insertNumber("Введите максимальное значение членов матриц:");
Console.WriteLine();

if (n<=0 || m<=0 || l<=0 || min>max) Console.WriteLine("Данные введены неправильно.");
else
{
   int [,] firstMatrix = createArray(l,m,min,max);
   printArray(firstMatrix);
   Console.WriteLine();

    int [,] secondMatrix = createArray(m,n,min,max);
   printArray(secondMatrix);
   Console.WriteLine();

   Console.WriteLine("Результат умножения полученных матриц:");
   int [,] desiredArray = newMatrix(firstMatrix,secondMatrix);
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
int [,] createArray(int n, int m, int min, int max)
{
    int [,] a = new int [n,m];
    for (int row = 0; row < n ; row++)
    {
       for (int col = 0; col < m ; col++) 
       {
        a[row,col] = new Random().Next(min,max+1);
       }
    }
    return a;
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
   
//Метод умножения матриц
int[,] newMatrix (int[,] firstArray, int[,] secondArray)
{
   int[,] desiredArray = new int [l,n];

    for (int i = 0;i < firstArray.GetLength(0); i++)
    {
        for(int j = 0; j < secondArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int r = 0; r < firstArray.GetLength(1); r++) sum = sum + firstArray[i,r]*secondArray[r,j];
            desiredArray[i,j] = sum;
        }
    }
    return desiredArray;
} 
   
   
   