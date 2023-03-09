System.Console.WriteLine("Введите число, которое определит количество" + "\n" + "строк и столбцов квадратного двумерного массива: ");
int number = Convert.ToInt32(Console.ReadLine());



if (number < 0) System.Console.WriteLine("У двумерного массива должна быть хотя бы 1 строка или 1 столбец");
else
{
    int[,] firstMatrix = GetMatrix(number, 1, 3);
    System.Console.WriteLine("Первый массив:");
    PrintMatrix(firstMatrix);

    System.Console.WriteLine();

    int[,] secondMatrix = GetMatrix(number, 1, 3);
    System.Console.WriteLine("Второй массив:");
    PrintMatrix(secondMatrix);

    System.Console.WriteLine();

    int[,] resultMatrix = GetMultiMatrix(firstMatrix, secondMatrix);
    System.Console.WriteLine("Результирующий массив:");
    PrintMatrix(resultMatrix);

}

int[,] GetMatrix(int number, int minValue, int maxValue)
{
    int[,] matrix = new int[number, number];
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j < number; j++)
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

int[,] GetMultiMatrix(int[,] firstInputMatrix, int[,] secondInputMatrix)
{
    int[,] multiMatrix = new int[firstInputMatrix.GetLength(0), firstInputMatrix.GetLength(1)];


    for (int i = 0; i < firstInputMatrix.GetLength(0); i++)
    {

        for (int j = 0; j < firstInputMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < multiMatrix.GetLength(0); k++)
            {
                sum += firstInputMatrix[i, k] * secondInputMatrix[k, j];
                multiMatrix[i, j] = sum;
            }
        }
    }
    return multiMatrix;
}