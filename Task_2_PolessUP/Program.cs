internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        Console.WriteLine("Ввод: ");
        Console.WriteLine(string.Join(" ", nums));
        Console.WriteLine(target);
        int[] indexes = IndexElementsSumThisEqualTarget(nums, target);
        Console.WriteLine("Вывод: ");
        Console.WriteLine("[{0},{1}]", indexes[0], indexes[1]);
        Console.ReadLine();
    }

    static int[] IndexElementsSumThisEqualTarget(int[] nums, int target)
    {
        int[] indexSum = new int[] {0, 0};
        bool check = true;
        int index1 = 0;

        while (check)
        {
            for (int index2 = index1 + 1; index2 < nums.Length; index2++)
            {
                if (nums[index1] + nums[index2] == target)
                {
                    indexSum[0] = index1;
                    indexSum[1] = index2;
                    check = false;
                    break;
                }
            }
            index1++;
        }

        return indexSum;
    }
}

