using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main;

internal class TestMethods
{
    public void TestSinglyLinkedList()
    {
        SinglyLinkedList<int> linkedListOfInts = new SinglyLinkedList<int>();
        linkedListOfInts.AddFirst(1);
        linkedListOfInts.AddFirst(2);
        linkedListOfInts.AddLast(3);
        linkedListOfInts.PrintList();
        SinglyLinkedList<string> linkedListOfStrings = new();
        linkedListOfStrings.AddFirst("Hello");
        linkedListOfStrings.AddLast("World!");
        linkedListOfStrings.AddFirst("_");
        linkedListOfStrings.RemoveFirst();
        linkedListOfStrings.RemoveLast();
        linkedListOfStrings.PrintList();
    }
}
