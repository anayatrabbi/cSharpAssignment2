using System;
using System.Threading.Tasks;
using cSharpAssignment2;
namespace cSharpAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ method optput
            var LINQ = new LINQandCollection();
            LINQ.QueryHighScores(1, 90);

            //async
            Method1();
            Method2();
        }

        //asyncronus programming
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    Task.Delay(100).Wait();
                }
            });
        }


        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
                
                Task.Delay(100).Wait();
            }
        }
    }
}
