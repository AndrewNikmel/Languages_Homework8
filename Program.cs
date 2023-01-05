


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows, cols];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < cols; j++){
//             array[i,j]=new Random().Next(min, max+1);
            
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }


    



// Console.WriteLine("Enter the amount of the rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of the columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of the minimal: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of the maximal: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// SortNumbers(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58. DONE : Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows, cols];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < cols; j++){
            array[i,j]=new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

int [,] MultiplyedArrays(int [,] firstArray, int [,] secondArray){
    int [,] multyArray = new int [firstArray.GetLength(0),firstArray.GetLength(1)];
    for(int i = 0; i<firstArray.GetLength(0); i++){
        for(int j = 0; j<secondArray.GetLength(1); j++){
            for(int x = 0; x<secondArray.GetLength(0); x++){
                multyArray[i,j] += firstArray[i,x]*secondArray[x,j];
            }
            Console.Write(multyArray[i,j] + ", ");
        }
        Console.WriteLine();
    }
    return multyArray;
}

Console.WriteLine("Enter the amount of rows and columns: ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = rows;
Console.WriteLine("Enter the minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] firstArray = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(firstArray);
Console.WriteLine();
int [,] secondArray = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(secondArray);
Console.WriteLine();
int [,] resultArray = MultiplyedArrays(firstArray, secondArray);
Console.WriteLine(resultArray);




// Задача 60. DONE...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2 (надо проверить, действительно ли числа не повторяются)
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// int[,,] CreateRandom3dArray(int rows, int cols, int smth, int min, int max){
//     int[,,] array = new int[rows, cols, smth];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < cols; j++){
//             for(int k = 0; k < smth; k++){
//             array[i,j,k]=new Random().Next(min, max+1);
//             }
//         }
//     }
//     return array;
// }

// void Show3dArray(int[,,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             for(int k = 0; k < array.GetLength(2); k++){
//             Console.Write($" {array[i,j,k]} ({i},{j},{k})");
//             }
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Prove3dArray(int[,,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             for(int k = 0; k < array.GetLength(2); k++){
//                 if(array[i,j,k] == array[i+1,j,k] || array[i,j,k] == array[i,j+1,k] || array[i,j,k] == array[i,j,k+1]){
//                     Console.WriteLine("The 3d array has equal numbers. We have to start again");
//                 }
//                 else
//                     Console.WriteLine("The 3d array has been build correct");
//             }
//         }
//     }
// }
    

// Console.WriteLine("Enter the amount of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of the value, that measures the 3d dimension: ");
// int smth = Convert.ToInt32(Console.ReadLine());
// int min = 9;
// int max = 100;
// int [,,] array = CreateRandom3dArray(rows, cols, smth, min, max);
// Show3dArray(array);
// Prove3dArray(array);


// Задача 62. DONE Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] CreateSpiral2dArray(int rows, int cols){
//     int iStart = 0;
//     int iFin = 0;
//     int jStart = 0;
//     int jFin = 0;
//     int k = 1;
//     int i = 0;
//     int j = 0;
//     int[,] array = new int[rows, cols];
//     while(k<=rows*cols){
//         array[i,j] = k;
//         if(i == iStart && j < rows- jFin -1){
//             j++;
//         }
//         else if(j == rows - jFin - 1 && i < cols - iFin -1){
//             i++;
//         }
//         else if(i == cols - iFin - 1 && j > jStart){
//             j--;
//         }
//         else
//             i--;
        
//         if((i == iStart + 1) && (j == jStart) && (jStart != cols - jFin -1)){
//             iStart++;
//             iFin++;
//             jStart++;
//             jFin++;
//         }
//         k++;
//     }
//     for(i = 0; i < array.GetLength(0); i++){
//         for(j = 0; j < array.GetLength(1); j++){
//         }
//     }
//     return array;
// }    

// void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Enter the amount of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the amount of columns: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreateSpiral2dArray(rows, cols);
// Show2dArray(array);