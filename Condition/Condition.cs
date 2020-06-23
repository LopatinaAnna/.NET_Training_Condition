namespace Condition
{
    public static class Condition
    {
        /// <summary>
        /// Implement code according to description of  task 1
        /// </summary>
        public static int Task1(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n < 0)
            {
                return n * (-1);
            }
            else
            {
                return n * n;
            }
        }

        /// <summary>
        /// Implement code according to description of  task 2
        /// </summary>
        public static int Task2(int n)
        {
            int[] array = new int[3];
            int index = 0;

            while (index != 3)
            {
                array[index] = n % 10;
                n /= 10;
                index++;
            }

            int temp;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return (array[0] * 100 + array[1] * 10 + array[2]);
        }
    }
}