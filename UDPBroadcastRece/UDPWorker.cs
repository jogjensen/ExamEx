using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPBroadcastRece
{
    class UDPWorker
    {
        private const int PORT = 23233;

        public UDPWorker()
        {

        }

        public void Start()
        {
            UdpClient client = new UdpClient(PORT);

            byte[] buffer;

            while (true)
            {

                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, port:0);
                buffer = client.Receive(ref remoteEP);

                string str = Encoding.UTF8.GetString(buffer);
                Console.WriteLine("STR modtaget : \n" + str);

                //todo parsing
                string[] strs = str.Split(',');

                //temp [0]
                string tempStr = strs[0].Trim();
                Console.WriteLine(tempStr);
                string[] temps = tempStr.Split('=');
                double temp = Convert.ToDouble(temps[1]);
                Console.WriteLine("Temperature is " + temp);

                //pressure [1]
                string pressStr = strs[1].Trim();
                Console.WriteLine(pressStr);
                string[] press = pressStr.Split('=');
                double pres = Convert.ToDouble(pressStr[2]);
                Console.WriteLine("Pressure is " + pres);

                //humidity [2]


            }
        }


    }
}
