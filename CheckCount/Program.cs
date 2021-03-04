using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CheckCount
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<int> lst = new List<int>();


            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {

                    Method1(lst);
                    Method2(lst);
                    Task.Delay(100).Wait();
                }
            });

            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {

                    var data= CheckCount(lst);
                    Task.Delay(500).Wait();
                }
            });

          
          
        }

        public static void Method1(List<int> list)
        {
                
            Random rnd = new Random();
            int val1 = rnd.Next(0, 10);
            int val2 = rnd.Next(2, 10);
            int val3 = rnd.Next(0, 10);

            list.Add(val1);
            list.Add(val2);
            list.Add(val3);
                  
       
           
        }


        public static void Method2(List<int> list)
        {
            Random rnd = new Random();
            int val1 = rnd.Next(0, 10);
            int val2 = rnd.Next(0, 1);
            int val3 = rnd.Next(1, 10);

            list.Add(val1);
            list.Add(val2);
            list.Add(val3);

          
        }


        public static List<int> CheckCount(List<int> list)
        {
            List<int> returnList = new List<int>();
          

                  
                    int count1 = 0, count0 = 0;                  

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == 0)
                            count0++;
                        if (list[i] == 1)
                            count1++;
                    }

                    returnList.Add(count0);
                    returnList.Add(count1);

            Console.WriteLine("Cunt of 0: " + count0 + " ; Count of 1:" + count1);

            return returnList;
        }
    }
}
