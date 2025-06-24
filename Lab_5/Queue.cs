using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Queue_Example
{
    private Queue<int> queue = new Queue<int>();

    public void Enqueue(int item)
    {
        queue.Enqueue(item);
        Console.WriteLine($"Enqueued: {item}");
    }

    public void Dequeue()
    {
        if (queue.Count > 0)
        {
            int removed = queue.Dequeue();
            Console.WriteLine($"Dequeued: {removed}");
        }
        else
        {
            Console.WriteLine("Queue is empty!");
        }
    }

    public void Peek()
    {
        if (queue.Count > 0)
        {
            Console.WriteLine($"First item: {queue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty!");
        }
    }

    public void Contains(int item)
    {
        if (queue.Contains(item))
            Console.WriteLine($"Queue contains {item}");
        else
            Console.WriteLine($"Queue does not contain {item}");
    }

    public void Clear()
    {
        queue.Clear();
        Console.WriteLine("Queue cleared.");
    }

    public void Display()
    {
        Console.WriteLine("Current Queue:");
        if (queue.Count == 0)
        {
            Console.WriteLine("[Empty]");
        }
        else
        {
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }


}



        
