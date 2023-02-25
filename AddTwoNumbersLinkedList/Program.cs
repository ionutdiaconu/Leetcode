

using System.Numerics;

namespace Test
{



    class Solution
    {
        /*
         * You are given two non-empty linked lists representing two non-negative integers.
         * The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
         * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
         *
         * eg:
         * Input: l1 = [2,4,3], l2 = [5,6,4]
         * Output: [7,0,8]
         * Explanation: 342 + 465 = 807.
         */

        static void Main()
        {
            Solution s = new Solution();

            ListNode l1 = s.IntToNode(9);
            ListNode l2 = s.IntToNode(1999999999);

            ListNode result = s.AddTwoNumbers(l1, l2);

            Console.WriteLine("Result: {0}", s.NodeToNumber(result));
        }

        private ListNode GetNode(char[] valArray)
        {

            if (valArray.Length == 0)
            {
                return null;
            }

            char[] newValArray = valArray[1..];

            return new()
            {
                val = int.Parse("" + valArray[0]),
                next = GetNode(newValArray),
            };

        }

        private ListNode IntToNode(BigInteger val)
        {
            char[] valArray = val.ToString().ToCharArray();
            Array.Reverse(valArray);

            return GetNode(valArray);
        }


        private BigInteger NodeToNumber(ListNode node)
        {
            string val = "";
            ListNode current = node;

            while (current != null)
            {
                val += "" + current.val;
                current = current.next;
            }

            char[] valArray = val.ToCharArray();
            Array.Reverse(valArray);

            string nodeValueStrig = new(valArray);
            Console.WriteLine("nodeValueStrig:" + nodeValueStrig);

            return BigInteger.Parse(nodeValueStrig);

        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            BigInteger sum = NodeToNumber(l1) + NodeToNumber(l2);
            return IntToNode(sum);
        }
    }
}