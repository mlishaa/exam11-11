using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tutorials
{
    //struct xPoint
    //{
    //   public int x;
    //   public int y;
    //}
    class Program
    {
        //enum colors
        //{
        //    RED = 1, // 1
        //    BLUE = 2, //2
        //    ORANGE = 3//3
        //}

       public static void Main(string[] args)
        {
            //foreach (String icolor in Enum.GetNames(typeof(colors)))
            //{
            //    Console.Write(icolor + " ");
            //}
            
            // xPoint[] arr=new xPoint[5];
            //arr[0].x = 5;
            //arr[0].y = 1;

            String[] mySTr = { "mike", "Vero", "naty" };

            LinkedList<String> myLinkList = new LinkedList<string>(mySTr);
            myLinkList.AddLast("Christina");

            foreach(String name in myLinkList)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine(myLinkList.First.Value);
            Console.WriteLine(myLinkList.Contains("Christina"));

            

            SortedDictionary<String, int> sortedList = new SortedDictionary<string, int>();
            String[] names = { "mike", "mike", "malak", "malak", "mom", "mom", "mary" };

            for(int i = 0; i < names.Length; ++i)
            {
                if (sortedList.ContainsKey(names[i]))
                {
                    int count = sortedList[names[i]];
                    sortedList.Remove(names[i]);
                    count++;
                    sortedList.Add(names[i], count);
                }
                else
                    sortedList.Add(names[i], 1);
            }

            foreach(KeyValuePair<String,int> pair in sortedList)
            {
                Console.WriteLine("Name {0} coours {1} times ",pair.Key,pair.Value);
            }


            int[] mi=new int[] {2,3,4,5,6};
            int position=2;
            int[] tempArray = new int[0];
            int counter = 0;
            for(int i = 0; i<mi.Length; i++)
            {
                if(i != position)
                {
                    counter++;
                    Array.Resize(ref tempArray, counter);
                    tempArray[tempArray.Length-1] = mi[i];
                }
            }

            foreach(int el in tempArray)
            {
                Console.Write(el + " ");
            }

              FileStream output;

           
          
           output = new FileStream("TextBook.txt", FileMode.Create, FileAccess.Write);
          
            using(StreamWriter writeTo=new StreamWriter(output))
            {
                writeTo.Write("My New Txt");
                writeTo.WriteLine("Mike");
                writeTo.WriteLine();
                writeTo.WriteLine("greetings");

            }

            String namex = String.Empty;
            FileStream input = new FileStream("TextBook.txt", FileMode.Open, FileAccess.Read);
            using(StreamReader readFrom=new StreamReader(input))
            {
              namex = readFrom.ReadLine();
            }
            Console.WriteLine(namex);
            Console.ReadKey();

        }
    }
}
