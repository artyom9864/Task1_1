using StringLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length==0)
            {
                Console.WriteLine("Error");
                return;
            }

            string username = args[0];

            var helloMessage = new HelloMessage();
            var message = helloMessage.GetHelloMessage(username);

            Console.WriteLine(message);
        }
    }
}
