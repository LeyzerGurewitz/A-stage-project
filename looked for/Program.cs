using System.Runtime.Serialization.Formatters;

namespace looked_for
{
    internal class Program
    {
        public static int[] selectionSort(int[] selection)
        {
            int variable = 0;
            for (int i = 0; i < selection.Length; i++)
            {

                for (int j = i; j < selection.Length; j++)
                {

                    if (selection[j] < selection[i])
                    {
                        variable = selection[j];
                        selection[j] = selection[i];
                        selection[i] = variable;
                    }
                }
            }
            return selection;
        }
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

            int[] sortedArray1 = selectionSort(new int[] { 5, 3, 8, 4, 1 });
            Console.WriteLine(string.Join(", ", sortedArray));
        }
    }
}
