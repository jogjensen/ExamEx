using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace UDPBroadcaster
{
    class UDPWorker
    {
        private const int PORT = 23233;
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);
        private const int SEC = 1;

        public UDPWorker()
        {

        }

        public void Start()
        {

            UdpClient client = new UdpClient();

            byte[] buffer;

            //Opretter måling der sender hvert sekund
            while (true)
            {
                double temp = rnd.NextDouble() * 5 + 30; //laver tal mellem 30.0 og 34.999
                double press = rnd.NextDouble() * 25 + 1000;
                double humidity = rnd.NextDouble() * 40 + 50;


                String str = $"temp = {temp}, press = {press}, humidity = {humidity}";

                //
                IPEndPoint SendToEP = new IPEndPoint(IPAddress.Broadcast, PORT);
                byte[] outbuffer = Encoding.UTF8.GetBytes(str);
                client.Send(outbuffer, outbuffer.Length, SendToEP);

                Thread.Sleep(1000 * SEC);
            }
        }

    }
}
