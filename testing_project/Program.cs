// Doubly Link list example

using System;

public class Node
{
    public int data;
    public Node prev;
    public Node next;

    public Node(int d)
    {
        data = d;
        prev = null;
        next = null;
    }
}

public class DoublyLinkedList
{
    public Node head;

    // Constructor
    public DoublyLinkedList()
    {
        head = null;
    }

    // Add a node at the front of the list
    public void InsertFront(int new_data)
    {
        Node new_node = new Node(new_data);
        new_node.next = head;
        if (head != null)
            head.prev = new_node;
        head = new_node;
    }

    // Add a node at the end of the list
    public void InsertEnd(int new_data)
    {
        Node new_node = new Node(new_data);
        Node last = head;
        new_node.next = null;
        if (head == null)
        {
            new_node.prev = null;
            head = new_node;
            return;
        }
        while (last.next != null)
            last = last.next;
        last.next = new_node;
        new_node.prev = last;
    }

    // Print the doubly linked list
    public void PrintList(Node node)
    {
        Node last = null;
        Console.WriteLine("Traversal in forward direction: ");
        while (node != null)
        {
            Console.Write(node.data + " ");
            last = node;
            node = node.next;
        }
        Console.WriteLine();
        Console.WriteLine("Traversal in reverse direction: ");
        while (last != null)
        {
            Console.Write(last.data + " ");
            last = last.prev;
        }
    }
}

public class Program
{
    public static void Main()
    {
        DoublyLinkedList dll = new DoublyLinkedList();
        dll.InsertEnd(1);
        dll.InsertFront(2);
        dll.InsertEnd(3);
        dll.InsertFront(4);

        Console.WriteLine("Doubly linked list is: ");
        dll.PrintList(dll.head);
    }
}
