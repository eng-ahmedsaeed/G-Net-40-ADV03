using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.Intrinsics.X86;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass03Advc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            #region Exercise 1
            //Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> Numbers = new();
            //Numbers.AddRange([85, 92, 78, 95, 88, 70, 100, 65]);
            //Print the collection, Count, first and last grade
            //Numbers.ForEach(x => Console.WriteLine($"{x}"));
            //int first = Numbers[0];
            //int last = Numbers[Numbers.Count-1];
            //Console.WriteLine($"count:{Numbers.Count} | firstelement: {first} | lastelement : {last}");
            //Sort the grades ascending, then print
            //Numbers.Sort();
            //Numbers.ForEach(x => Console.WriteLine($"{x}"));
            //Get the first grade above 90
            //int firstgradeabove = Numbers.Find(x => x > 90);
            //Console.WriteLine($"firstgradeabove:{firstgradeabove}");
            //Get all grades below 75 
            // List<int> failingGrades = Numbers.FindAll(x => x < 75);
            //failingGrades.ForEach(x=> Console.WriteLine(x));
            //Remove all failing grades (below 75)
            //Numbers.RemoveAll(x => x < 75);
            //Numbers.ForEach(x => Console.WriteLine($"{x}"));
            //Check if any grade equals 100
            //Console.WriteLine($"is 100 : {Numbers.Contains(100)}");
            //List<string> strings = Numbers.ConvertAll(x=>$"Grade : {x}");
            //strings.ForEach(x=> Console.WriteLine(x));
            #endregion
            #region Exercise 2
            //Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //SortedList<int, string> players = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};
            //Print all entries (they should be sorted by score automatically)
            //foreach (var kvp in players)
            //    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            ////Access the first key and first value 
            //Console.WriteLine($"firstKey:{players.Keys[0]} | Firstvalue:{players.Values[0]}");
            //Check if score 500 exists
            //Console.WriteLine($"is 500 : {players.ContainsKey(500)}");
            //Safely get the player with score 999
            //bool isplayer = players.TryGetValue(999,out string val);
            //Console.WriteLine(isplayer);
            //Remove the player with score 200 and print the updated list
            //players.Remove(200);
            //foreach (var kvp in players)
            //  Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            #endregion
            #region Exercise 3
            //Create a Collection  with 4 contacts (name → phone number)
            //Dictionary<string,string> dic = new()
            //{
            //    ["Ahmed"]="01000442120",
            //    ["mona"]="01152422162",
            //    ["adham"]="01222247530",
            //    ["nour"]="01524874210"
            //};
            //Add a new contact using [] syntax (add or update)
            //dic["walid"]= "01075204561";
            //Try adding a duplicate using .Add() — catch the exception and print the error
            // dic.Add("walid", "01145525480"); //Unhandled exception. System.ArgumentException
            //Try adding a duplicate using .TryAdd() — print whether it succeeded
            //Console.WriteLine(dic.TryAdd("walid", "01145525480"));
            //Search for a contact that doesn’t exist
            //Console.WriteLine(dic.ContainsValue("01555555555"));
            //Get a contact with a fallback of "Not Found"
            //if(dic.TryGetValue("Not Found",out string val))
            //{
            //    Console.WriteLine(val);
            //}
            //Print all Keys on one line, then all Values on another line
            //foreach (string key in dic.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //foreach (string value in dic.Values) 
            //{
            //    Console.WriteLine(value);
            //}
            #endregion
            #region Exercise 4
            //Create a HashSet<string>
            //HashSet<string> strings = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            //Add these emails
            //strings.Add("ahmed@test.com");
            //strings.Add("AHMED@test.com");
            //strings.Add("sara@test.com");
            //strings.Add("Sara@Test.Com");
            //Print Count — how many are actually stored? Explain why
            //Console.WriteLine(strings.Count);
            //Create two sets: Set A = {1,2,3,4,5} and Set B = {4,5,6,7,8}
            //HashSet<int> A = new() { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new() { 4, 5, 6, 7, 8 };
            //Print the result of: UnionWith, IntersectWith, ExceptWith
            //A.UnionWith(B);
            //foreach (int i in A) 
            //{
            //    Console.WriteLine(i);
            //}
            //A.IntersectWith(B);
            //foreach (int i in A)
            //{
            //    Console.WriteLine(i);
            //}
            //A.ExceptWith(B);
            //foreach (int i in A)
            //{
            //    Console.WriteLine(i);
            //}
            //Use IsSubsetOf to check if {1,2} is a subset of Set A
            //HashSet<int> C = new() { 1, 2 };
            //Console.WriteLine(C.IsSubsetOf(A)); 

            #endregion
            #region Exercise 5
            //Create a Queue<string>
            //Queue<string> strings = new();
            //strings.Enqueue("Report.pdf");
            //strings.Enqueue("Invoice.pdf");
            //strings.Enqueue("Letter.docx");
            //strings.Enqueue("Resume.pdf");
            //strings.Enqueue("Photo.jpg");
            //Print the queue contents and Count
            //foreach (var item in strings)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(strings.Count);
            //Use Peek to see which document will print next(without removing)
            //Console.WriteLine(strings.Peek());
            //Process the queue: Dequeue each document and print "Printing: [name]"
            //for (int i = 0; i < 5; i++)
            //{
            //    string first = strings.Dequeue();
            //    Console.WriteLine($"Printing: {first}");
            //}
            //Console.WriteLine(strings.TryDequeue(out string p));
            #endregion
            #region Exercise 6
            //Create a Stack<string>
            //Stack<string> strings = new();
            //Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com", "claude.ai"
            //strings.Push("google.com");
            //strings.Push("github.com");
            //strings.Push("stackoverflow.com");
            //strings.Push("youtube.com");
            //strings.Push("claude.ai");
            //Use Peek to see the current page (top of stack)
            //Console.WriteLine(strings.Peek());
            //Press "back" 3 times using Pop — print each page you leave
            //Console.WriteLine(strings.Pop());
            //Console.WriteLine(strings.Pop());
            //Console.WriteLine(strings.Pop());
            //Print the current page after going back
            //Console.WriteLine(strings.Peek());
            //Try TryPop on an empty stack — what happens?
            //Console.WriteLine(strings.Pop());
            //Console.WriteLine(strings.Pop());
            //Console.WriteLine(strings.TryPop(out string val));
            #endregion
        }
    }
}
