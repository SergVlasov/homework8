//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetRandomMatrix(int rows, int columns, int minVal, int maxVal) 
{ 
int[,] matrix = new int[rows, columns]; 
var random = new Random(); 
for (int i = 0; i < rows; i++) 
{ 
    for (int j = 0; j < columns; j++) 
    { 
        matrix[i,j] = random.Next(minVal, maxVal+1); 
    } 
} 
return matrix; 
} 
 
void PrintMatrix(int[,] matrix) 
{ 
    for (int i = 0; i < matrix.GetLength(0); i++) 
{ 
  for (int j = 0; j < matrix.GetLength(1); j++)   
  { 
    Console.Write(matrix[i,j] + " "); 
  } 
  Console.WriteLine();  
} 
} 

int[,] matrixRandom1 = GetRandomMatrix(2, 2, 0, 10);
PrintMatrix(matrixRandom1); 
System.Console.WriteLine( );
int[,] matrixRandom2 = GetRandomMatrix(2, 2, 0, 10);
PrintMatrix(matrixRandom2); 
Console.WriteLine("Matrix 1 Matrix 2:");
int[,] newMatrix = Multyplication(matrixRandom1, matrixRandom2);
PrintMatrix(newMatrix);

int[,] Multyplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Do not multiply matrices");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
           for (int k = 0; k < b.GetLength(0); k++)
           {
            r[i,j] += a[i,k] * b[k,j];
            
           } 
        }
    }
    return r;
}