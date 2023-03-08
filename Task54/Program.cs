System.Console.WriteLine("Введите число строк двумерного массива: ");
int numberRows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов двумерного массива: ");
int numberCols = Convert.ToInt32(Console.ReadLine());

if (numberCols < 0 || numberRows < 0) System.Console.WriteLine("У двумерного массива должна быть хотя бы 1 строка или 1 столбец");
else
{
    int[,] matrix = GetMatrix(numberRows, numberCols, 0, 10);
    System.Console.WriteLine("Исходный массив:");
    PrintMatrix(matrix);

    System.Console.WriteLine();

    SortingRowsMaxToMin(matrix);
    System.Console.WriteLine("Сортированный построчно массив:");
    PrintMatrix(matrix);
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

void SortingRowsMaxToMin(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int k = 0; k < inputMatrix.GetLength(1); k++)
        {
            for (int j = 0; j < inputMatrix.GetLength(1) - 1; j++)
            {

                if (inputMatrix[i, j + 1] > inputMatrix[i, j])
                {
                    int temp = inputMatrix[i, j];
                    inputMatrix[i, j] = inputMatrix[i, j + 1];
                    inputMatrix[i, j + 1] = temp;
                }
            }
        }
    }

}

