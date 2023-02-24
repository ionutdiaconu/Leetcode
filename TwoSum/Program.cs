namespace Test
{
    class Solution
    {

        /*
         * 
         * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
         * You may assume that each input would have exactly one solution, and you may not use the same element twice.
         * You can return the answer in any order. 
         * 
         * eg:
         * Input: nums = [2,7,11,15], target = 9
         * Output: [0,1]
         * Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
         */

        public static void Main()
        {

            //int[] problem = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] problem = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };

            int target = 11;


            //solution 1
            {
                try
                {
                    Console.WriteLine("Solution 1.");
                    var start = DateTime.Now;
                    int[] solution = TwoSumON2(problem, target);
                    Console.WriteLine("Search solution took: {0} ms.", (DateTime.Now - start).Milliseconds);
                    Console.WriteLine("nums:" + String.Join(',', problem));
                    Console.WriteLine("nums[" + solution[0] + "] + nums[" + solution[1] + "]=" + target);

                    if (problem[solution[0]] + problem[solution[1]] != target)
                    {
                        throw new Exception("Bad solution!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception:" + e.Message);
                }

            }

            Console.WriteLine("________________________________");


            //solution 2
            {
                try
                {
                    Console.WriteLine("Solution 2.");
                    var start = DateTime.Now;
                    int[] solution = TwoSumON1(problem, target);
                    Console.WriteLine("Search solution took: {0} ms.", (DateTime.Now - start).Milliseconds);
                    Console.WriteLine("nums:" + String.Join(',', problem));
                    Console.WriteLine("nums[" + solution[0] + "] + nums[" + solution[1] + "]=" + target);

                    if (problem[solution[0]] + problem[solution[1]] != target)
                    {
                        throw new Exception("Bad solution!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception:" + e.Message);
                }

            }
        }

        private static int[] TwoSumON2(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        if (i == j) continue; //may not use the same element twice.
                        return new int[] { i, j };
                    }
                }

            }

            throw new Exception("no solution found");

        }

        private static int[] TwoSumON1(int[] nums, int target)
        {

            Dictionary<int, int> lookup = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (lookup.TryGetValue(complement, out int idx))
                {
                    return new int[] { i, idx };
                }

                if (lookup.ContainsKey(nums[i]))
                {
                    lookup.Remove(nums[i]);
                    lookup.Add(nums[i], i);
                }
                else
                {
                    lookup.Add(nums[i], i);
                }
            }



            throw new Exception("no solution found");

        }

    }
}
