using System;
using System.Collections;
class Stack_Example
{
    private Stack<int> stack = new Stack<int>();

    public void Push(int item)
    {
        stack.Push(item);
        Console.WriteLine($"Pushed: {item}");
    }

    public void Pop()
    {
        if (stack.Count > 0)
        {
            int popped = stack.Pop();
            Console.WriteLine($"Popped: {popped}");
        }
        else
        {
            Console.WriteLine("Stack is empty!");
        }
    }

    public void Peek()
    {
        if (stack.Count > 0)
        {
            Console.WriteLine($"Top item: {stack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty!");
        }
    }

    public void Contains(int item)
    {
        if (stack.Contains(item))
            Console.WriteLine($"Stack contains {item}");
        else
            Console.WriteLine($"Stack does not contain {item}");
    }

    public void Clear()
    {
        stack.Clear();
        Console.WriteLine("Stack cleared.");
    }

    public void Display()
    {
        Console.WriteLine("Current Stack:");
        if (stack.Count == 0)
        {
            Console.WriteLine("[Empty]");
        }
        else
        {
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }

}


