using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__5
{
    internal class List_Example
    {
        private List<string> students = new List<string>();

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
            if (students.Count == 0)
            {
                Console.WriteLine("[No students in the list]");
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i}: {students[i]}");
                }
            }
        }
    }
}


        
 
