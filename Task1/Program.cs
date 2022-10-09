/* Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int Urgeent(string msg)
{
    Console.Write(msg);
    bool count = int.TryParse(Console.ReadLine(), out int number);
    if (count)
    {
        return number;
    }
    throw new Exception("Ошибка");
}

double[,] matrix(int lines, int columns)
{
    var matr = new double[lines, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble() * 10;
        }
    }
    return matr;
}
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2}  ");
        }
        Console.WriteLine();
    }
}
var lines = Urgeent("Введите количество строк - ");
var columns = Urgeent("Введите количество столбцов - ");
double[,] matr = matrix(lines, columns);
PrintArray(matr);