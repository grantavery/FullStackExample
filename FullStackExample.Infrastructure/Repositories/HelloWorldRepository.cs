using System;
using System.Threading;
using System.Threading.Tasks;
using FullStackExample.Domain.Abstract;
using FullStackExample.Domain.Entities;

namespace FullStackExample.Infrastructure
{
    public class HelloWorldRepository : IHelloWorldRepository
    {
        private readonly HelloWorldModel helloWorld;

        public HelloWorldRepository()
        {
            helloWorld = new HelloWorldModel("Hello World");
        }

        public async Task<HelloWorldModel> GetHelloWorld(CancellationToken cancelationToken)
        {
            // Mocked delay to simulate the "async-ness" of the API
            await Task.Delay(500, cancelationToken);
            return helloWorld;
        }
    }
}
