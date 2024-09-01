namespace looked_for
{
    internal class Program
    {
        public static int[] LookedFor(int[] arr)
        {
            int x = 0;
            int variable = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - x; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        variable = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = variable;
                    }
                }
                x++;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] sortedArray = LookedFor(new int[] { 5, 3, 8, 4, 1 });
            Console.WriteLine(string.Join(", ", sortedArray));
        }
    }
}
