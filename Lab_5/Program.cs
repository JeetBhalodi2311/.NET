using Lab__5;

class Program
{
    static void Main()
    {
        //ArrayList_Example list = new ArrayList_Example();
        //while (true)
        //{
        //    Console.WriteLine("\n--- Menu ---");
        //    Console.WriteLine("1. Add student");
        //    Console.WriteLine("2. Remove student by index");
        //    Console.WriteLine("3. Remove range");
        //    Console.WriteLine("4. Display students");
        //    Console.WriteLine("5. Clear list");
        //    Console.WriteLine("6. Exit");
        //    Console.Write("Choose an option: ");
        //    string input = Console.ReadLine();

        //    switch (input)
        //    {
        //        case "1":
        //            Console.Write("Enter student name: ");
        //            string name = Console.ReadLine();
        //            list.Add(name);
        //            break;
        //        case "2":
        //            Console.Write("Enter index to remove: ");
        //            int index = int.Parse(Console.ReadLine());
        //            list.Remove(index);
        //            break;
        //        case "3":
        //            Console.Write("Enter start index: ");
        //            int start = int.Parse(Console.ReadLine());
        //            Console.Write("Enter count: ");
        //            int count = int.Parse(Console.ReadLine());
        //            list.RemoveRange(start, count);
        //            break;
        //        case "4":
        //            list.Display();
        //            break;
        //        case "5":
        //            list.Clear();
        //            break;
        //        case "6":
        //            return;
        //        default:
        //            Console.WriteLine("Invalid choice!");
        //            break;
        //    }
        //}


        //List_Example studentList = new List_Example();
        //while (true)
        //{
        //    Console.WriteLine("\n--- Menu ---");
        //    Console.WriteLine("1. Add student");
        //    Console.WriteLine("2. Remove student by index");
        //    Console.WriteLine("3. Remove range");
        //    Console.WriteLine("4. Display students");
        //    Console.WriteLine("5. Clear list");
        //    Console.WriteLine("6. Exit");
        //    Console.Write("Choose an option: ");
        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            Console.Write("Enter student name: ");
        //            string name = Console.ReadLine();
        //            studentList.Add(name);
        //            break;
        //        case "2":
        //            Console.Write("Enter index to remove: ");
        //            int index = int.Parse(Console.ReadLine());
        //            studentList.Remove(index);
        //            break;
        //        case "3":
        //            Console.Write("Enter start index: ");
        //            int start = int.Parse(Console.ReadLine());
        //            Console.Write("Enter count: ");
        //            int count = int.Parse(Console.ReadLine());
        //            studentList.RemoveRange(start, count);
        //            break;
        //        case "4":
        //            studentList.Display();
        //            break;
        //        case "5":
        //            studentList.Clear();
        //            break;
        //        case "6":
        //            return;
        //        default:
        //            Console.WriteLine("Invalid choice!");
        //            break;
        //    }
        //}


        //Stack_Example s = new Stack_Example();
        //while (true)
        //{
        //    Console.WriteLine("\n--- Stack Menu ---");
        //    Console.WriteLine("1. Push");
        //    Console.WriteLine("2. Pop");
        //    Console.WriteLine("3. Peek");
        //    Console.WriteLine("4. Contains");
        //    Console.WriteLine("5. Clear");
        //    Console.WriteLine("6. Display");
        //    Console.WriteLine("7. Exit");
        //    Console.Write("Select option: ");
        //    string option = Console.ReadLine();

        //    switch (option)
        //    {
        //        case "1":
        //            Console.Write("Enter integer to push: ");
        //            int val = int.Parse(Console.ReadLine());
        //            s.Push(val);
        //            break;
        //        case "2":
        //            s.Pop();
        //            break;
        //        case "3":
        //            s.Peek();
        //            break;
        //        case "4":
        //            Console.Write("Enter value to check: ");
        //            int item = int.Parse(Console.ReadLine());
        //            s.Contains(item);
        //            break;
        //        case "5":
        //            s.Clear();
        //            break;
        //        case "6":
        //            s.Display();
        //            break;
        //        case "7":
        //            return;
        //        default:
        //            Console.WriteLine("Invalid option!");
        //            break;
        //    }
        //}



        //Queue_Example q = new Queue_Example();
        //while (true)
        //{
        //    Console.WriteLine("\n--- Queue Menu ---");
        //    Console.WriteLine("1. Enqueue");
        //    Console.WriteLine("2. Dequeue");
        //    Console.WriteLine("3. Peek");
        //    Console.WriteLine("4. Contains");
        //    Console.WriteLine("5. Clear");
        //    Console.WriteLine("6. Display");
        //    Console.WriteLine("7. Exit");
        //    Console.Write("Choose an option: ");
        //    string option = Console.ReadLine();

        //    switch (option)
        //    {
        //        case "1":
        //            Console.Write("Enter an integer to enqueue: ");
        //            int value = int.Parse(Console.ReadLine());
        //            q.Enqueue(value);
        //            break;
        //        case "2":
        //            q.Dequeue();
        //            break;
        //        case "3":
        //            q.Peek();
        //            break;
        //        case "4":
        //            Console.Write("Enter value to check: ");
        //            int item = int.Parse(Console.ReadLine());
        //            q.Contains(item);
        //            break;
        //        case "5":
        //            q.Clear();
        //            break;
        //        case "6":
        //            q.Display();
        //            break;
        //        case "7":
        //            return;
        //        default:
        //            Console.WriteLine("Invalid option!");
        //            break;
        //    }
        //}

        //Dictionary_Example dict = new Dictionary_Example();
        //while (true)
        //{
        //    Console.WriteLine("\n--- Dictionary Menu ---");
        //    Console.WriteLine("1. Add key-value pair");
        //    Console.WriteLine("2. Remove key");
        //    Console.WriteLine("3. Check if key exists");
        //    Console.WriteLine("4. Check if value exists");
        //    Console.WriteLine("5. Clear dictionary");
        //    Console.WriteLine("6. Display contents");
        //    Console.WriteLine("7. Exit");
        //    Console.Write("Select option: ");
        //    string choice = Console.ReadLine();

        //    switch (choice)
        //    {
        //        case "1":
        //            Console.Write("Enter key (int): ");
        //            int keyAdd = int.Parse(Console.ReadLine());
        //            Console.Write("Enter value (string): ");
        //            string valueAdd = Console.ReadLine();
        //            dict.Add(keyAdd, valueAdd);
        //            break;
        //        case "2":
        //            Console.Write("Enter key to remove: ");
        //            int keyRemove = int.Parse(Console.ReadLine());
        //            dict.Remove(keyRemove);
        //            break;
        //        case "3":
        //            Console.Write("Enter key to check: ");
        //            int keyCheck = int.Parse(Console.ReadLine());
        //            dict.ContainsKey(keyCheck);
        //            break;
        //        case "4":
        //            Console.Write("Enter value to check: ");
        //            string valueCheck = Console.ReadLine();
        //            dict.ContainsValue(valueCheck);
        //            break;
        //        case "5":
        //            dict.Clear();
        //            break;
        //        case "6":
        //            dict.Display();
        //            break;
        //        case "7":
        //            return;
        //        default:
        //            Console.WriteLine("Invalid option!");
        //            break;
        //    }
        //}


        Hashtable_Example ht = new Hashtable_Example();
        while (true)
        {
            Console.WriteLine("\n--- Hashtable Menu ---");
            Console.WriteLine("1. Add key-value pair");
            Console.WriteLine("2. Remove key");
            Console.WriteLine("3. Check if key exists");
            Console.WriteLine("4. Check if value exists");
            Console.WriteLine("5. Clear hashtable");
            Console.WriteLine("6. Display contents");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter key: ");
                    string key = Console.ReadLine();
                    Console.Write("Enter value: ");
                    string value = Console.ReadLine();
                    ht.Add(key, value);
                    break;
                case "2":
                    Console.Write("Enter key to remove: ");
                    string remKey = Console.ReadLine();
                    ht.Remove(remKey);
                    break;
                case "3":
                    Console.Write("Enter key to check: ");
                    string checkKey = Console.ReadLine();
                    ht.ContainsKey(checkKey);
                    break;
                case "4":
                    Console.Write("Enter value to check: ");
                    string checkValue = Console.ReadLine();
                    ht.ContainsValue(checkValue);
                    break;
                case "5":
                    ht.Clear();
                    break;
                case "6":
                    ht.Display();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }


    }
}