namespace TwoPointers;
//19. Remove Nth Node From End of List - необходимо удалить n-ый элемент с конца односвязного списка
public static class RemoveNthNodeFromEndOfList
{
    public static ListNode Execute(ListNode head, int n)
    {
        if (head.next == null)
        {
            return null;
        }

        var currentNode = head;
        var count = 0;
        var globalCount = 1;

        ListNode preNNode = head;
        while (currentNode.next != null)
        {
            globalCount++;
            if (count < n)
            {
                count++;
            }
            else
            {
                preNNode = preNNode.next;
            }

            currentNode = currentNode.next;
        }

        if (globalCount == n)
        {
            return head.next;
        }

        preNNode.next = preNNode.next.next;

        return head;
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