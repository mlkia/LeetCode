// See https://aka.ms/new-console-template for more information

//876. Middle of the Linked List
//https://leetcode.com/problems/middle-of-the-linked-list/


//My solution 

public ListNode MiddleNode(ListNode head) {
       int count = 1;
	   ListNode middlenode = head;
	
	while (head.next != null)
	      {
		    count +=1;
	        head = head.next;
	      }

	for (int i = 0; i < count / 2  ; i ++)
	    {
            middlenode = middlenode.next;
	    }

        return middlenode;
    }

Console.WriteLine ("----------------------------------------------------");
Console.WriteLine ("Big o (Time Complexity) of this is ? ");	
Console.WriteLine ("----------------------------------------------------");



//Approach 1: Fast and Slow Pointer

public ListNode middleNode(ListNode head) {
        ListNode slow = head, fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }

Console.WriteLine ("----------------------------------------------------");
Console.WriteLine ("Big o (Time Complexity) of this is O(n)");	
Console.WriteLine ("----------------------------------------------------");


//Approach 2: Output to Array

 public ListNode middleNode(ListNode head) {
        ListNode[] A = new ListNode[100];
        int t = 0;
        while (head != null) {
            A[t++] = head;
            head = head.next;
        }
        return A[t / 2];
    }

Console.WriteLine ("----------------------------------------------------");
Console.WriteLine ("Big o (Time Complexity) of this is O(n)");	
Console.WriteLine ("----------------------------------------------------");
