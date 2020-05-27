using System;
using System.Threading;
using System.Threading.Tasks;
using FullStackExample.Domain.Abstract;
using FullStackExample.Domain.Entities;

namespace FullStackExample.API.Services
{
    public class HelloWorldService : IHelloWorldService
    {
        private IHelloWorldRepository helloWorldRepository;

        public HelloWorldService(IHelloWorldRepository helloWorldRepository)
        {
            this.helloWorldRepository = helloWorldRepository;
        }

        public async Task<HelloWorldModel> GetHelloWorld()
        {
            return await helloWorldRepository.GetHelloWorld(default);
        }
    }
}
