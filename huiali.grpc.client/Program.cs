using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

using huiali.grpc.server;

namespace huiali.grpc.client
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client =  new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "huiali" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
    }
}
