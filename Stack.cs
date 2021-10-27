using System;
class Stack<T>
{
    public Node<T> top;

    private int counter;
    public bool IsEmpty(){
        return top == null;
    }

    public T Peek(){
        if(top != null){
            return top.value;
        }
        return default(T);
    }

    public void Push(T value){
        Node<T> node = new Node<T>(value);
        node.Next = top;
        top = node;
        counter++;
    }

    public T Pop(){
        if(top != null){
            T value = top.value;
            top = top.Next;

            counter--;
            return value;
        }
        return default(T);
    }

    public int Size() {
        return counter;
    }

}