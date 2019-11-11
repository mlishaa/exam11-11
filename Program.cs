using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            String[] mySTr = { "mike", "Vero", "Nadia" };

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
            Console.ReadKey();

        }
    }
}
