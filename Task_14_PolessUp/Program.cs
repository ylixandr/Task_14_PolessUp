using System;

class Program
{
    static int MaximizeMatrixSum(int[][] matrix)
    {
        int n = matrix.Length;
        int sum = 0;

        // Подсчитываем сумму всех положительных элементов
        // и применяем операцию умножения на -1 ко всем отрицательным элементам
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] > 0)
                {
                    sum += matrix[i][j];
                }
                else
                {
                    matrix[i][j] *= -1;
                }
            }
        }

        // Если размер матрицы четный, сумма максимизируется путем
        // умножения на -1 всех положительных элементов кроме одного
        if (n % 2 == 0)
        {
            int minPositive = int.MaxValue;

            // Находим наименьший положительный элемент
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] > 0 && matrix[i][j] < minPositive)
                    {
                        minPositive = matrix[i][j];
                    }
                }
            }

            sum -= minPositive;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int[][] matrix = new int[][] {
            new int[] { 1, -1 },
            new int[] { -1, 1 }
        };

        int result = MaximizeMatrixSum(matrix);
        Console.WriteLine(result);
    }
}
