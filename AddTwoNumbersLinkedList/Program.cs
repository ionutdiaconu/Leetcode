

using System.Numerics;

namespace Test
{

    class Solution
    {
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