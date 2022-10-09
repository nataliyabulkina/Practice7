/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix(int lines, int columns)
{
    var matr = new int[lines, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }

    }
    return matr;
}
void Sumofvalues(int[,] matrix)
{
    int sum = 0;
    int aver = 0;
    int index = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        aver = sum / matrix.GetLength(0);
        Console.WriteLine($"Среднее арифмитическое {index}-го столбца = {aver}");
        aver = 0;
        sum = 0;
        index++;
    }
}
var lines = Urgeent("Введите количество строк -");
var columns = Urgeent("Введите количество столбцов -");
var matr = matrix(lines, columns);
PrintArray(matr);
Sumofvalues(matr);
