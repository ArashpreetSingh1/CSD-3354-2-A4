using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace CSD_3354_2_A4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Downloading File");
            Download();
            Console.ReadLine();
        }
        static async void Download()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("http://rouxacademy.com");
            Console.WriteLine("Download Complete" + data);
        }
    }
    class Network
    {
        static public Task Download()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(3000);
            });
        }
    }


}


