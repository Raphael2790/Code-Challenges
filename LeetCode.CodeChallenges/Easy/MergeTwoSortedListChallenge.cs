namespace LeetCode.CodeChallenges.Easy;

public class MergeTwoSortedListChallenge
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null)
            return null!;

        if (list1 is null)
            return list2;

        if(list2 is null) 
            return list1;

        ListNode result = list1.val < list2.val ? new(list1.val) : new(list2.val);

        if (result.val == list1?.val)
            FillNext(list1.next, list2, ref result);
        else
            FillNext(list1, list2.next, ref result);

        return result!;
    }

    public static void FillNext(ListNode list1, ListNode list2, ref ListNode result)
    {
        if(list1 is null && list2 is null)
            return;

        if (list1 is null && list2 is not null)
        {
            result.next = list2;
            list2 = list2.next;
            return;
        }

        if(list1 is not null && list2 is null)
        {
            result.next = list1;
            list1 = list1.next;
            return;
        }

        if(list1.val < list2.val)
        {
            result.next = list1;
            list1 = list1.next;
        }
        else
        {
            result.next = list2;
            list2 = list2.next;
        }

        FillNext(list1, list2, ref result.next);
    }
}

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
