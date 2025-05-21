public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];
        int value = 1;
        int top = 0, bottom = size - 1, left = 0, right = size - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = value++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = value++;
            }
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom, i] = value++;
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i, left] = value++;
                }
                left++;
            }
        }

        return matrix;
    }
}
