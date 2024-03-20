using LinkedList;
using _io = FastIO.Output;
public class Program
{
    static void Main()
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
        /*        _io.Debug(linkedListOfInts);
                _io.Debug(linkedListOfStrings);*/
    }
}