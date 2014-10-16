using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;

namespace ServiceStrackTest1
{
    //Request DTO
    [Route("/hello1")]
    [Route("/hello1/{Name}")]
    public class Hello:IReturn<HelloResponse>
    {
        public string Name { get; set; }
    }

    //Response DTO
    //Follows naming convention
    public class HelloResponse : IHasResponseStatus
    {
        public ResponseStatus ResponseStatus { get; set; } //Automatic exception handling

        public string Result { get; set; }
    }

    public class HelloService : Service
    {
        public object Any(Hello request)
        {
            //throw new Exception("1111");
            return new HelloResponse { Result = "Hello world, " + request.Name
                                        //, ResponseStatus=new ResponseStatus("111","error")  
                                    };
        }
    }
}
