int n = insertNumber("Введите колличество строк в массиве:");
int m = insertNumber("Введите колличество столбцов в массиве:");
int l = insertNumber("Введите глубину массива:");
int min = 10;

Console.WriteLine();

if (n<=0 || m<=0 || l<=0) Console.WriteLine("Данные введены неправильно.");
else if(n*m*l > 99) Console.WriteLine("Нет столько неповторяющихся двузначных чисел.");

else
{
   int [,,] desiredArray = createArray(n,m,l,min);
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
int [,,] createArray(int n, int m, int l,int min)
{
    int [,,] a = new int [n,m,l];
    for (int row = 0; row < n ; row++)
    {
       for (int col = 0; col < m ; col++) 
       {
         for (int deep = 0; deep < l; deep++) 
         {
         a[row,col,deep] = min ;
         min = min+1;
         }
       }
    }
    return a;
}

//Метод вывода массива
void printArray( int[,,] array)
{
    for (int row = 0; row < array.GetLength(0) ; row++)
    {
       for (int col = 0; col < array.GetLength(1) ; col++) 
       {
        for (int deep = 0; deep < array.GetLength(2) ; deep++)
        {
        Console.Write($"{array[row,col,deep]} ({row}, {col}, {deep}) ");
        }
        Console.WriteLine();
       }
       Console.WriteLine();
    }
}
