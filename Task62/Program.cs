System.Console.WriteLine("Введите число строк двумерного массива: ");
int numberRows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов двумерного массива: ");
int numberCols = Convert.ToInt32(Console.ReadLine());

if (numberCols < 0 || numberRows < 0) System.Console.WriteLine("У двумерного массива должна быть хотя бы 1 строка или 1 столбец");
else
{
    int[,] matrix = GetMatrixBySpiral(numberRows, numberCols);
    System.Console.WriteLine("Массив, заполненный по спирали:");
    PrintMatrix(matrix);
}

int[,] GetMatrixBySpiral(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];
    int count = 0;
    int index = 0;
    for (int k = 0; k < rows; k++)
    {
        for (int i = index; i < index + 1; i++)
        {
            for (int j = index; j < cols; j++)
            {
                count++;
                matrix[i, j] = count;
            }
        }
        for (int i = index + 1; i < rows; i++)
        {
            for (int j = cols - 1; j > cols - 2; j--)
            {
                count++;
                matrix[i, j] = count;
            }
        }
        for (int i = rows - 1; i > rows - 2; i--)
        {
            for (int j = cols - 2; j >= index; j--)
            {
                count++;
                matrix[i, j] = count;
            }
        }
        for (int i = rows - 2; i > index; i--)
        {
            for (int j = index; j < index + 1; j++)
            {
                count++;
                matrix[i, j] = count;
            }
        }
        index++;
        rows--;
        cols--;
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
