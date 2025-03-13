using System.Collections;
using System.Transactions;

public class LinkedListEnumerator<T> : IDisposable, IEnumerator, IEnumerator<T>
{
    private DNode<T> FirstNode = null;
    private DNode<T> CurrentNode = null;
    public LinkedListEnumerator(DNode<T> node)
    {
        FirstNode = node;
    }

    public T Current
    {
        get
        {
            if(CurrentNode != null)
            {
                return CurrentNode.Value;
            }
            else
            {
                return default;
            }
        }
    }
    object? IEnumerator.Current => Current;
    public bool MoveNext()
    {
        if(CurrentNode == null)
        {
            CurrentNode = FirstNode;
            return true;
        }
        else if (CurrentNode.Next != null)
        {
            CurrentNode = CurrentNode.Next;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset()
    {

    }
    public void Dispose()
    {

    }
}