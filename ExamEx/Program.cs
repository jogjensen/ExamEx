using System;
using UDPBroadcaster;

namespace ExamEx
{
    class Program
    {
        static void Main(string[] args)
        {
            UDPWorker worker = new UDPWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
