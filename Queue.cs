class Queue<T> {
    public Node<T> head;
    public Node<T> tail;

    private int Count;

    public bool IsEmpty(){
        return head == null;
    }

    public void Enqueue(T value){
        Node<T> node = new Node<T>(value);

        if(tail != null) {
            tail.Next = node;
        }
        tail = node;

        if(head == null){
            head = node;
        }

        Count++;
    }

    public T Dequeue() {
        if(head != null){
            T value = head.value;
            head = head.Next;
            Count--;
            return value;
        }
        else{
            tail = null;
        }
        return default(T);
    }

    public int Size() {
        return Count;
    }
    

}