using System.Collections;

public class DoublyLinkedList<T> : IDoubleEndedCollection<T>, IEnumerable<T>
{
    private DNode<T>? _head = null;
    private DNode<T>? _tail = null;
    public int Length { get; set;} = 0;


    // ToDo: implement the methods of the Terface
    public T First => _head.Value;
    public T Last => _tail.Value;
    public void AddLast(T value)
    {
        DNode<T> tempNode = new DNode<T>();
        tempNode.Value = value;
        if(_tail == null)
        {
            _head = tempNode;
            _tail = tempNode;
        }
        else
        {
            _tail.Next = tempNode;
            tempNode.Previous = _tail;
            _tail = tempNode;
        }
        Length++;
    }

    public void AddFirst(T value)
    {
        DNode<T> tempNode = new DNode<T>();
        tempNode.Value = value;
        if(_head == null)
        {
            _head = tempNode;
            _tail = tempNode;
        }
        else
        {
            _head.Previous = tempNode;
            tempNode.Next = _head;
            _head = tempNode;
        }
        Length++;
    }

    public void RemoveFirst()
    {
        if(_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _head.Next = _head;
            _head.Previous = null;
        }
        Length--;
    }

    public void RemoveLast()
    {
        if(_head == _tail)
        {
            _head = null;
            _tail = null;
        }
        else
        {
            _tail = _tail.Previous;
            _tail.Next = null;
        }
        Length--;
    }

    public void InsertAfter(DNode<T> node, T value)
    {
        DNode<T> newNode = new DNode<T>();
        newNode.Value = value;
        newNode.Next = node.Next;
        newNode.Previous = node;

        if(node.Next != null)
        {
            node.Next.Previous = newNode;
        }

        node.Next = newNode;

        if(_tail == node)
        {
            _tail = newNode;
        }
        Length++;
    }

    public void RemoveByValue(T value)
    {
        DNode<T> temp = _head;
        while(temp != null)
        {
            if(temp.Value.Equals(value))
            {
                if(temp.Previous != null)
                {
                    temp.Previous.Next = temp.Next;
                }
                if(temp.Next != null)
                {
                    temp.Next.Previous = temp.Previous;
                }
                if(_head == temp)
                {
                    _head = temp.Next;
                }
                if(_tail == temp)
                {
                    _tail = temp.Previous;
                }
                Length--;
            }
            temp = temp.Next;
        }
    }

    public void ReverseList()
    {
        DNode<T> current = _head;
        DNode<T> temp = null;

        while(current != null)
        {
            temp = current.Previous;
            current.Previous = current.Next;
            current.Next = temp;
            current = current.Previous;
        }

        if(temp != null)
        {
            _head = temp.Previous;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(_head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}