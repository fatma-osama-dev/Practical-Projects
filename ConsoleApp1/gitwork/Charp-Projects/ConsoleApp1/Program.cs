
using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAPP
{
    class Program
    {
        class desorder : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                return y.CompareTo(x);
            }
        }
        static void Main(string[] args)
        {

            //////Point p1 = new Point() { X = 19, Y = 70 };
            //////Point p2 = new Point() { X = 89, Y = 90 };
            //////Helper<Point>.Swap(ref p1, ref p2);
            //////Console.WriteLine($"p1 = {p1}   p2={p2}");
            ////int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            ////Console.WriteLine( Helper<int>.search(a, 5));

            ////GenericData<int> a = new GenericData<int>();
            ////a.data = 10;
            ////Console.WriteLine(a.data);
            ////GenericData<string> b = new GenericData<string> { data = "sherien" };
            ////Console.WriteLine(b.data);
            ////GenericData<string> data1 = new GenericData<string>() {data="fatma osama" };
            ////data1.print(data1.data);

            //ArrayList arr = new ArrayList() { 1, 2, 4, "nouran" };

            //// arr.AddRange(new() { 2, 5, 6, " .... " });
            ////foreach (var i in arr) {
            ////    Console.WriteLine(i);
            ////}
            ////for(var i = 0; i < arr.Count; i++) { Console.WriteLine(arr[i]); }
            //arr.Insert(1, "fatma");
            ////for (var i = 0; i < arr.Count; i++) { Console.WriteLine($"\n {arr[i]}"); }
            ////Console.WriteLine(arr.Contains("fatma")?"true":"false");
            ////arr.Add(300);
            ////arr.Add(300);
            ////arr.Add(300);
            ////arr.Add(300);
            ////arr.Add(400);


            ////for(var i = 0; i < arr.Count; i++) { Console.WriteLine(arr[i]); }

            ////arr.Remove(300);
            ////for (var i = 0; i < arr.Count; i++) { Console.WriteLine(arr[i]); }

            ////Console.WriteLine(arr.IsFixedSize);
            ////int[] a=new int[7];
            ////Console.WriteLine(a.IsFixedSize);
            //// Console.WriteLine(arr);
            //for (var i = 0; i < arr.Count; i++) { Console.WriteLine(arr[i]); }
            //arr.RemoveRange(1, 2);
            //for (var i = 0; i < arr.Count; i++) { Console.WriteLine(arr[i]); }

            //    List<int> l = new List<int>();

            //    l.Add(1);
            //    l.Add(2);
            //    l.Add(3);
            //    l.Add(4);
            //    for (int i = 0; i < l.Count; i++)
            //    {
            //        Console.WriteLine(l[i]);
            //    }
            //  //  l.RemoveRange(1,3);
            //    Console.WriteLine("---------------------------------");

            //    //for (int i = 0; i < l.Count; i++)
            //    //{
            //    //    Console.WriteLine(l[i]);
            //    //}
            //    Console.WriteLine( l.Count());
            //
            //List<Point> points = new List<Point>() { new Point() { X = 1, Y = 9 }, new Point() { X = 5, Y = 7 } };
            ////foreach (Point p in points) {
            ////    Console.WriteLine(p);
            ////}
            //points.ForEach(num=> Console.WriteLine(num));
            //var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            //numbers.Remove(10); // removes the first 10 from a list

            //numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            ////numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            //foreach (var el in numbers)
            //    Console.WriteLine(el); //prints 20 30


            // Stack<string> st=new Stack<string>();
            // st.Push("alaa");
            // st.Push("hassan");
            // st.Push("doaa");
            // st.Push("bosbos");
            // st.Push("hagar");

            // while (st.Count>0) {
            //     Console.WriteLine(st.Pop());

            // }
            //// Console.WriteLine(st.Count());
            //int[] arr = { 1, 2, 3, 4, 5 };
            //Stack<int> s = new Stack<int>(arr);
            //foreach(var i in s) Console.WriteLine(i);
            //Queue<string> q=new Queue<string>();
            //q.Enqueue("t1rue");
            //q.Enqueue("f1alse");
            //q.Enqueue("t2rue");
            //q.Enqueue("f2alse");

            //while (q.Count > 0) {
            //    Console.WriteLine(q.Dequeue());
            //}

            //Hashtable num_names = new Hashtable();
            //num_names.Add("fatma", 1);
            //num_names.Add("mo", 2);
            //num_names.Add("lolo", 3);
            ////foreach(var p in num_names) Console.WriteLine(p);
            //Console.WriteLine(num_names["fatma"]);

            //creating a Hashtable using collection-initializer syntax
            //            var cities = new Hashtable(){
            //    {"UK", "London, Manchester, Birmingham"},
            //    {"USA", "Chicago, New York, Washington"},
            //    {"India", "Mumbai, New Delhi, Pune"}
            //};

            //            string citiesOfUK = (string)cities["UK"]; //cast to string
            //            string citiesOfUSA = (string)cities["USA"]; //cast to string
            //            Console.WriteLine(citiesOfUK);


            //            cities.Remove("UK");
            //            Console.WriteLine(cities.ContainsKey("UK"));

            //Dictionary<string , string> dict = new Dictionary<string , string>();
            //dict.Add("fatma", ".net");
            //dict.Add("ahmed", "it");
            //dict.Add("alaa", "network");
            //foreach (KeyValuePair<string, string> mp in dict)
            //    Console.WriteLine($"{mp}");
            //utility<string,string>.dict.Add("nour", "asp.net");
            //utility<string,string>.dict.Add("ola", "it");
            //utility<string,string>.dict.Add("omar", "network");
            //utility<string,string>.dict.Add("ahmed", "asp.net");
            //utility<string,int>.dict.Add("omar", 16000);
            //utility<string, int>.dict.Add("hassan", 18000);
            //utility<string, int>.dict.Add("mona", 20000);

            //utility<decimal,decimal>.dict.Add(15.8m, 12.2m);

            //foreach(KeyValuePair<string,int> item in utility<string,int>.dict) Console.WriteLine(item);

            //Console.WriteLine( utility<string, string>.dict.ContainsKey("ola"));
            // SortedDictionary<string, int> info = new SortedDictionary<string, int>(){
            //     { "goda", 100 },
            //     { "ziad",19 },
            // //     { "khaled",80},
            // //     { "alaa",80 }
            // //};
            // SortedDictionary<int, string> info = new SortedDictionary<int,string>(){
            //     { 3,"goda" },
            //     { 0,"ziad"},
            //     {1, "khaled"},
            //     {9, "alaa"}
            //};


            // //info.Add("goda", 100);
            // //info.Add("ziad", 19);
            // //info.Add("khaled", 80);
            // //info.Add("alaa", 80);
            // foreach (KeyValuePair<int, string> p in info) {
            //     Console.WriteLine(p);
            // }
       

            SortedList<string, int> li = new SortedList<string, int>( new desorder()) {
                { "noha",15000},
                {"Asmaa" ,19000},
                 { "omar",15000},
                {"Ali" ,19000},

            };
            foreach (KeyValuePair<string, int> p in li) {
                Console.WriteLine(p);
            }


        }


    }
}
