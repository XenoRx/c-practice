internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, 5 ,6 ,6 ,7 ,7 ,8 ,9};
        int target = 15;
        FindTriplet(array, target);

        static bool FindTriplet(int[] arr, int targetSum)
        {
            for (int i = 0; i < arr.Length - 2; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;

                while (left < right)
                {
                    int currentSum = arr[i] + arr[left] + arr[right];

                    if (currentSum == targetSum)
                    {
                        Console.WriteLine(arr[i] + " " + arr[left] + " " + arr[right]);
                        return true;
                    }

                    else if (currentSum < targetSum)
                        left++;

                    else
                        right--;
                }
            }

            return false;
        }
    }
}