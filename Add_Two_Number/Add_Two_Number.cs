using System;
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int sum = new int();
        int curry = new int();
        ListNode answer = new ListNode(0);
        ListNode answerpoint = answer;
        do
        {
            answerpoint.next = new ListNode();
            answerpoint = answerpoint.next;
            sum = l1.val + l2.val + curry;
            curry = sum >= 10 ? curry = 1 : curry = 0;
            sum = sum >= 10 ? sum - 10 : sum;
            answerpoint.val = sum;
            if (curry == 1 || l1.next != null || l2.next != null)
            {
                l1 = l1.next != null ? l1.next : new ListNode(0);
                l2 = l2.next != null ? l2.next : new ListNode(0);
            }
            else
                break;
        } while (true);
        return answer.next;
    }
}