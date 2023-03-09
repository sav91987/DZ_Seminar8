System.Console.WriteLine("Введите число строк двумерного массива: ");
int numberRows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов двумерного массива: ");
int numberCols = Convert.ToInt32(Console.ReadLine());

if (numberCols < 0 || numberRows < 0) System.Console.WriteLine("У двумерного массива должна быть хотя бы 1 строка или 1 столбец");
else
{
    if (numberCols == numberRows) System.Console.WriteLine("Задан квадратный массив, задайте прямоугольный");
    else
    {
        int[,] matrix = GetMatrix(numberRows, numberCols, 0, 10);
        System.Console.WriteLine("Исходный массив:");
        PrintMatrix(matrix);

        System.Console.WriteLine();

        FindRowMinSum(matrix);
    }
}

int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            System.Console.Write(inputMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindRowMinSum(int[,] inputMatrix)
{
    int[] arrayForSum = new int[inputMatrix.GetLength(0)];
    int min = int.MaxValue;
    int index = 0;

    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            sum += inputMatrix[i, j];
        }
        arrayForSum[i] = sum;
    }
    for (int k = 0; k < arrayForSum.Length; k++)
    {
        if (arrayForSum[k] < min)
        {
            min = arrayForSum[k];
            index = k;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов исходного массива в {index} строке");
}



