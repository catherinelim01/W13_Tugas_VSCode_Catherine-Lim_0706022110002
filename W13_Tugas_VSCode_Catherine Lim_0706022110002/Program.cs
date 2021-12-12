using System;
using System.Linq;
using System.Collections.Generic;


namespace W13_Tugas_VSCode_Catherine_Lim_0706022110002
{
    class Program
    {
        public static void Catherine()
        {
            Console.WriteLine("Tugas Week 13\nCatherine Lim_0706022110002\n");
        }
        static void Main(string[] args)
        {
            Catherine();
            int pilihanMenu, addScrolls, numberQueue, queueListToSearch, queueListToRemove, scrollQueueToRemove;
            int repeatProgram = 0, countList = 0;
            string nameScrolls, scrollNameToSearch, removeListSelection, scrollNameToRemove;
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            do
            {
                Console.WriteLine("1. My Scroll List");
                Console.WriteLine("2. Add Scroll");
                Console.WriteLine("3. Search Scroll");
                Console.WriteLine("4. Remove Scroll");
                Console.Write("\nChoose What To Do: ");
                pilihanMenu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Clear();
                if (pilihanMenu == 1)
                {
                    Console.WriteLine("Scroll To Learn List:");
                    countList = 1;
                    foreach (var scroll in scrolls)
                    {
                        Console.WriteLine($"Scroll {countList}: {scroll}");
                        countList++;
                    }
                }
                else if (pilihanMenu == 2)
                {
                    Console.WriteLine("How Many Scroll To Add:");
                    addScrolls = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In What Number Of Queue?");
                    numberQueue = Convert.ToInt32(Console.ReadLine());

                    if (numberQueue > scrolls.Count)
                    {
                        numberQueue = scrolls.Count + 1;
                    }
                    for (int i = 0; i < addScrolls; i++)
                    {
                        numberQueue++;
                        Console.WriteLine("Scroll " + (i + 1) + " Name:");
                        nameScrolls = Console.ReadLine();
                        scrolls.Insert(numberQueue - 1, nameScrolls);
                    }
                    Console.Clear();
                }
                else if (pilihanMenu == 3)
                {
                    Console.WriteLine("Insert Scroll Name: ");
                    scrollNameToSearch = Console.ReadLine();

                    if (scrolls.FindIndex(x => x.Equals(scrollNameToSearch, StringComparison.OrdinalIgnoreCase)) != -1)
                    {
                        queueListToSearch = scrolls.FindIndex(x => x.Equals(scrollNameToSearch, StringComparison.OrdinalIgnoreCase));
                        queueListToSearch = queueListToSearch + 1;
                        Console.WriteLine("Book Found. Queue Number: " + queueListToSearch + "\n");
                    }
                    else
                    {
                        Console.Write("Book Not Found\n\n");
                    }
                }
                else if (pilihanMenu == 4)
                {
                    Console.WriteLine("Remove From List By Scroll Name? (Y/N)");
                    removeListSelection = Console.ReadLine();

                    while (removeListSelection != "Y" && removeListSelection != "N")
                    {
                        Console.WriteLine("Wrong Selection. Choose Again:");
                        Console.WriteLine("Remove From List By Scroll Name? (Y/N)");
                        removeListSelection = Console.ReadLine();
                    }
                    if (removeListSelection == "Y")
                    {
                        Console.WriteLine("\nInput Scroll Name: ");
                        scrollNameToRemove = Console.ReadLine();

                        if (scrolls.FindIndex(x => x.Equals(scrollNameToRemove, StringComparison.OrdinalIgnoreCase)) != -1)
                        {
                            queueListToRemove = scrolls.FindIndex(x => x.Equals(scrollNameToRemove, StringComparison.OrdinalIgnoreCase));
                            scrolls.RemoveAt(queueListToRemove);
                            Console.WriteLine("Book Removed!\n");
                        }
                        else
                        {
                            Console.Write("Book Not Found\n\n");
                        }
                    }
                    if (removeListSelection == "N")
                    {
                        Console.WriteLine("\nInput Scroll Queue: ");
                        scrollQueueToRemove = Convert.ToInt32(Console.ReadLine());
                        while (scrollQueueToRemove > scrolls.Count || scrollQueueToRemove < 1)
                        {
                            Console.WriteLine("Queue Not Found. Insert Scroll Queue:");
                            scrollQueueToRemove = Convert.ToInt32(Console.ReadLine());
                        }
                        scrollQueueToRemove = scrollQueueToRemove - 1;
                        scrolls.RemoveAt(scrollQueueToRemove);
                        Console.WriteLine("Book Removed!");
                    }
                }
                else
                {
                    Console.Write("\nMenu Option Not Available\n\n");
                }
            }
            while (repeatProgram == 0);
        }
    }
}
