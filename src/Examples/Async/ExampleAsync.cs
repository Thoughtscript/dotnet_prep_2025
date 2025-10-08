using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExampleAsync
{
    class ExampleTasks
    {
        // Use lock keyword to enforce thread safety.
        private static int ThreadExample()
        {
            int result = 0;

            Thread t = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    result++;
                }
            }));

            t.Start(); // Start, non-blocking
            t.Join(); // Then convert to blocking, await

            return result;
        }

        private static async void AsyncExample()
        {
            int result = 0;

            Task t = Task.Run(() => {
                 for (int i = 0; i < 100000; i++)
                    {
                    result++;
                }

                return result;
            });

            // t.Start();
            // Not needed here

            try
            {
                await t;
                Console.WriteLine("Async task " + t.Status + " " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static async void Run()
        {
            Console.WriteLine("============== ExampleAsync ==============");

            AsyncExample();
            Console.WriteLine(ThreadExample());
        }
    }
}
