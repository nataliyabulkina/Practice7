
/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
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
void SearchCordInMatrix(int[,] matr)
{
    var lines = Urgeent("Введите номер строки -");
    var columns = Urgeent("Введите номер столбца -");
    if (0 <lines || lines > matr.GetLength(0) || 0 < columns|| columns > matr.GetLength(1))
    {
        Console.WriteLine("Элемента нет");
    }
    else
        Console.WriteLine($"{matr[lines - 1, columns - 1]}");
}
var lines = Urgeent("Введите количество строк -");
var columns = Urgeent("Введите количество столбцов -");
var matr = matrix(lines, columns);
PrintArray(matr);
SearchCordInMatrix(matr);

