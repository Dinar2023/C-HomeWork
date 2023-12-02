
Console.Clear();
// Задача 1: Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// void FillArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Arr[i, j] = new Random().Next(1, 100);

//         }

//     }
// }

// void PrintArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write(Arr[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }

// void FindNumInArr (int[ , ] Arr)
// {
//     Console.WriteLine("Введите номер строки");
//     int n = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите номер столбца");
//     int m = int.Parse(Console.ReadLine()!);
//     if (n-1 > Arr.GetLength(0) || m-1 > Arr.GetLength(1)) Console.WriteLine("Такого элемента нет");
//     else Console.WriteLine(Arr[n-1,m-1]);
// }


// int[,] array = new int[4, 5];
// FillArray2(array);
// PrintArray2(array);
// FindNumInArr(array);
//===========================================================================================================================


// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
// void FillArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Arr[i, j] = new Random().Next(1, 100);

//         }

//     }
// }

// void PrintArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write(Arr[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }

// void RevStrArr(int[,] Arr)
// {
//     for (int j = 0; j < Arr.GetLength(1); j++)
//     {
//         Arr[0, j] = Arr[0, j] + Arr[Arr.GetLength(0)-1, j];
//         Arr[Arr.GetLength(0)-1, j] = Arr[0, j] - Arr[Arr.GetLength(0)-1, j];
//         Arr[0, j] = Arr[0, j] - Arr[Arr.GetLength(0)-1, j];
//     }
// }

// int[,] array = new int[5, 5];
// FillArray2(array);
// PrintArray2(array);
// RevStrArr(array);
// Console.WriteLine();
// PrintArray2(array);
//===========================================================================================================================

// Задача 3: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с
//наименьшей суммой элементов.

// void FillArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Arr[i, j] = new Random().Next(1, 100);

//         }

//     }
// }

// void PrintArray2(int[,] Arr)
// {
//     for (int i = 0; i < Arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             Console.Write(Arr[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
// }
// int[,] array = new int [5,5];

// int FindMinStr (int[,] Arr)
// {
//     int sum = 0;
//     for (int j = 0; j < Arr.GetLength(1); j++) sum +=Arr[0,j];
//     int min = sum;
//     int x = 0;
//     Console.WriteLine(sum);


//     for (int i = 1; i < Arr.GetLength(0); i++)
//     {
//         sum = 0;
//         for (int j = 0; j < Arr.GetLength(1); j++)
//         {
//             sum +=Arr[i,j];
//         }
//         Console.WriteLine(sum);
//         if (min > sum)
//         {
//             min = sum;
//             x = i;
//         }
//     }
//     return (x);
// }


// FillArray2(array);
// PrintArray2(array);
// int S = FindMinStr(array);
// Console.Write ("Минимальная сумма на строке № "+(S+1));
//================================================================================================================

//Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

void FillArray2(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Arr[i, j] = new Random().Next(1, 100);

        }

    }
}

void PrintArray2(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write(Arr[i, j] + " ");
        }

        Console.WriteLine();
    }
}
int[,] array = new int [5,5];

int[,] GeneratteNewArr (int[,] Arr)
{
    int min = Arr[0,0];
    int iMin=0;
    int jMin=0;
    for (int i = 0; i < Arr.GetLength(0); i++)  // Нахожу индексы минималбного элемента
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            if (Arr[i,j]<min)
            {
                min = Arr[i,j];
                iMin = i;
                jMin = j;
        
            }
        }  
    }                                            // Конец нахождения iMin jMin
    
    int [,] Arr2 = new int [Arr.GetLength(0)-1, Arr.GetLength(1)-1];
    for (int i = 0; i < Arr2.GetLength(0); i++)  // Заполняю новый массив
    {
        for (int j = 0; j < Arr2.GetLength(1); j++)
        {
            if (i<iMin)
            {
                if (j<jMin) Arr2[i,j]=Arr[i,j];
                else Arr2[i,j]=Arr[i,j+1];       
            }
            else
            {
                if (j<jMin) Arr2[i,j]=Arr[i+1,j];
                else Arr2[i,j]=Arr[i+1,j+1];  
            }        
        }
    }  




    Console.WriteLine(iMin+" "+jMin);
    return (Arr2);
}


FillArray2(array);
PrintArray2(array);
int[,] array2 = GeneratteNewArr(array);
PrintArray2(array2);