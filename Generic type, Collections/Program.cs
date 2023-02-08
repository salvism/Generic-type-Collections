using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic_type__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(4);
            numbers.Add(8);
            numbers.Add(16);

            numbers.Remove(16);
            numbers.RemoveAt(1);

            Console.WriteLine(numbers.Contains(4)); 

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\n");

            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "one");
            numberNames.Add(2, "two");
            numberNames.Add(3, "three");
            numberNames.Add(4, "four");

            numberNames.Clear();

            foreach (var item in numberNames)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            SortedList<int, string> students = new SortedList<int, string>()
            {
                {4, "Salvi" },
                {2, "Nazile" },
                {1, "Nigar" },
                {3, "Guler" }
            };
            Console.WriteLine("\n");

            foreach (var student in students)
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
            Console.WriteLine("\n");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.Peek());

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Pop();

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            HashSet<char> letters = new HashSet<char>();
            letters.Add('a');
            letters.Add('a');
            letters.Add('b');
            letters.Add('b');

            foreach (char letter in letters)
            {
                Console.WriteLine(letter);
            }

            var arrList = new ArrayList();
            arrList.Add(4);
            arrList.Add("Harry");
            arrList.Add(" ");
            arrList.Add(true);
            arrList.Add(4.5);
            arrList.Add(null);

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arrList.AddRange(myQ);

            foreach (var arr in arrList)
            {
                Console.WriteLine(arr);
            }

        }
    }
}
