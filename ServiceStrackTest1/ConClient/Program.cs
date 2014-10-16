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
            Async(url);
        }

        static void Sync(string url)
        {
            using (var client = new JsonServiceClient(url))
            {
                //HelloResponse response = client.Get(new Hello { Name = "World!" });
                HelloResponse response = client.Get<HelloResponse>("/hello1/World!");
                Console.Write("respnose:{0}", response.Result);
            }
        }

        static void Async(string url)
        {
            using (var client = new JsonServiceClient(url))
            {
                var response = client.GetAsync <HelloResponse>(new Hello { Name = "World!" });
                response.Success(r => Console.Write("respnose:{0}", r.Result));
                
            }
        }
        static void Async1(string url)
        {
            using (var client = new JsonServiceClient(url))
            {
                client.GetAsync(new Hello { Name = "World!" })
                .Success(r =>Console.Write("respnose:{0}",r.Result))
                .Error(ex => { throw ex; });
            }
        }
    }
}
