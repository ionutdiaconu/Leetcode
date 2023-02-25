

using System.Numerics;

namespace Test
{

    class Solution
    {
        static void Main()
        {
            Solution s = new Solution();

            
            {
                ListNode l1 = new ListNode(9);
                ListNode l2 = new ListNode(1, new ListNode(9));

                ListNode result = s.AddTwoNumbers(l1, l2);
                string resultValue = result.next.next.val + "" + result.next.val + "" + result.val;

                if (!"100".Equals(resultValue))
                {
                    Console.WriteLine("bad solution!");
                }
                Console.WriteLine("9 + 91 = " + resultValue);
            }


            {
                ListNode l1 = new ListNode(5);
                ListNode l2 = new ListNode(7, new ListNode(4));
                ListNode result = s.AddTwoNumbers(l1, l2);
                string resultValue = result.next.val + "" + result.val;


                if (!"52".Equals(resultValue))
                {
                    Console.WriteLine("bad solution!");
                }
                Console.WriteLine("5 + 47 = " + resultValue);
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode ();
            int carry = 0;
            ListNode cur = result;

            while (l1 != null || l2 != null || carry > 0)
            {

                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;

                int thisVal = val1 + val2 + carry;

                carry = thisVal / 10;
                thisVal %= 10;


                cur.next = new ListNode (thisVal);
                cur = cur.next;
                


                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;

            }
            return result.next;

        }
    }
}