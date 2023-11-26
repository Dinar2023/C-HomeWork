//Задача №1. Задайте одномерный массив из 10 целых чисел от 1 до 100. 
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// void FillArray (int[] Arr)
// {
//     for (int i = 0; i<=9; i++)
//     {
//         Arr[i]= new Random().Next(1,100);
//         Console.Write (Arr[i]+" ");
//     }
// }

// int [] array = new int [10];
// FillArray(array);
// int count=0;
// for (int i=0; i<10; i++)
// {
//     if (array[i]<=90 && array[i]>=20) count++;
// }
// Console.WriteLine();
// Console.Write(count);
//=============================================================================



//Задача №2. Задайте массив на 10 целых чисел. 
//Напишите программу, которая определяет количество чётных чисел в массиве.

// void FillArray (int[] Arr)
// {
//     for (int i = 0; i<=9; i++)
//     {
//         Arr[i]= new Random().Next(1,100);
//         Console.Write (Arr[i]+" ");
//     }
// }

// int [] array = new int [10];
// FillArray(array);
// int count=0;
// for (int i=0; i<10; i++)
// {
//     if (array[i]%2==0) count++;
// }
// Console.WriteLine();
// Console.Write(count);
//============================================================================


//Задача №3. Задайте массив из вещественных чисел с ненулевой дробной частью. 
//Найдите разницу между максимальным и минимальным элементов массива. 

// void FillArray (double[] Arr)
// {
//     for (int i = 0; i<=9; i++)
//     {
//         Arr[i]= new Random().Next(100,10000)*0.01 ;
      
//         Console.Write (Arr[i]+" ");
//     }
// }

// double [] array = new double [10];
// FillArray(array);
// double max=array[0];
// double min=array[0];
// for (int i=0; i<10; i++)
// {
//     if (array[i] > max) max=array[i];
//     else if (array[i]<min) min= array[i];
// }
// double delta = max - min;
// Console.WriteLine();
// Console.WriteLine(max+" "+min+" "+delta);
//===============================================================================


//Задача 4. Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе массива,
//младший – на последнем. Размер массива должен быть равен количеству цифр.
int[] NumberToArray (int Number,int lenght)
{
    int[] Arr = new int [lenght];
    for (int i4 = 0; i4<lenght; i4++)
    {
        Arr[i4]=Number%10;
        Number/=10; 
       Console.Write(Arr[i4]+" ");
    }
    return Arr;
}


Console.WriteLine("Введите число от 1 до 100000");
int A = Convert.ToInt32(Console.ReadLine());
while (A<1||A>100000)
{
    Console.WriteLine("Введенное сисло не удовлетворяет условию, введите другое число");
    A = Convert.ToInt32(Console.ReadLine());
}
int B = A;
int n = 1;
while (B>=10)
{
    n++;
    B/=10;
}
Console.WriteLine(n);
int[] Array = NumberToArray(lenght: n, Number: A);


