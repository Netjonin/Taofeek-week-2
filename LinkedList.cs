class LinkedList<T>
{

    private Node<T> Head;
    private Node<T> Tail;
    public int Count { get; private set; }

    public int Add(T value){
        Node<T> node = new Node<T>(value);
        Node<T> temp = Head;

        Head = node;
        Head.Next = temp;

        Count++;
        
        if(Count == 1){
            Tail = Head;
        }
        
        return Count;
    }

    public bool Remove(T value){
        Node<T> previous = null;
        Node<T> current = Head;

        while (current != null)
        {
            if (current.value.Equals(value)) {
                if (previous != null) {
                    previous.Next = current.Next;

                    if (current.Next == null) {
                        Tail = previous;
                    }
                    Count--;
                }

                else{
                    if (Count != 0){
                        Head = Head.Next;
                        Count--;

                        if (Count == 0){
                            Tail = null;
                        }
                    }  
                }
                return true;
            }
            previous = current;
            current = current.Next;
        }
        return false;
    }

    public bool Check(T value){
        Node<T> current = Head;
        while (current != null)
        {
            if (current.value.Equals(value))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public int Index(T value){
        int index = 0;
        Node<T> current = Head;

        while(current != null){
            if(value.Equals(current.value)){
                return index;
            }
            current = current.Next;
            index++;
        }
        return -1;
    }
}

