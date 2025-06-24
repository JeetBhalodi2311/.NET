using System;
using System.Collections;

class ArrayList_Example
{
    private ArrayList students = new ArrayList();

    public void Add(string studentName)
    {
        students.Add(studentName);
        Console.WriteLine($"Added student: {studentName}");
    }

    public void Remove(int index)
    {
        if (index >= 0 && index < students.Count)
        {
            Console.WriteLine($"Removed student: {students[index]}");
            students.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Invalid index!");
        }
    }

    public void RemoveRange(int startIndex, int count)
    {
        if (startIndex >= 0 && startIndex + count <= students.Count)
        {
            students.RemoveRange(startIndex, count);
            Console.WriteLine($"Removed {count} students starting from index {startIndex}");
        }
        else
        {
            Console.WriteLine("Invalid range!");
        }
    }

    public void Clear()
    {
        students.Clear();
        Console.WriteLine("All students removed from the list.");
    }

    public void Display()
    {
        Console.WriteLine("Student List:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

   
}