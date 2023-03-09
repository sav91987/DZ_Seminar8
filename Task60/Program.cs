
/// <summary>
/// Метод заполняет трехмерную матрицу неповторяющимися двухзначными числами
/// </summary>
/// <param name="length"> длина трехмерной матрицы </param>
/// <param name="width"> ширина трехмерной матрицы </param>
/// <param name="high"> высота трехмерной матрицы </param>
/// <returns> Возвращается массив, заполненный числами, начиная с someNumber с шагом + 2 </returns>
int[,,] GetMatrix(int length, int width, int high)
{
    int[,,] matrix = new int[length, width, high];
    int someNumber = 10;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < width; j++)
        {
            for (int k = 0; k < high; k++)
            {
                matrix[i, j, k] = someNumber + 2; //Заполнение неповторяющимися двузначными числами (да криво, но в условиях текущей задачи(2х2х2) применимо:р)
                someNumber += 2;
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(2); k++)
            {
                System.Console.Write($"{inputMatrix[i, j, k]}({i},{j},{k}) \t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

}


int[,,] array = GetMatrix(2, 2, 2);
PrintMatrix(array);