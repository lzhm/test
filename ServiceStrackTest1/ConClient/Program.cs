using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;
using ServiceStrackTest1;

namespace ConClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ServiceStack Console Client";
            string url = "http://localhost/WebHost/";
            using (var client = new JsonServiceClient(url))
            {
                HelloResponse response = client.Get(new Hello { Name = "World!" });
                Console.Write("respnose:{0}", response.Result);
            }
        }
    }
}
