using System;
using System.Threading;
using System.Threading.Tasks;
using FullStackExample.Domain.Entities;

namespace FullStackExample.Domain.Abstract
{
    public interface IHelloWorldRepository
    {
        Task<HelloWorldModel> GetHelloWorld(CancellationToken cancelationToken);
    }
}
