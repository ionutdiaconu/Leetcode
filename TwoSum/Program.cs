namespace Test
{
    class Solution
    {

        public static void Main()
        {

            int[] problem = new int[] { 1, 2, 3, 4, 5, 6 };
            int target = 6;

            try
            {
                int[] solution = TwoSum(problem, target);

                Console.WriteLine("nums:" + String.Join(',', problem));
                Console.WriteLine("nums[" + solution[0] + "] + nums[" + solution[1] + "]=" + target);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }

        }

        private static int[] TwoSum(int[] nums, int target)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        return new int[] { i, j };
                    }
                }

            }

            throw new Exception("no solution found");

        }

    }
}
