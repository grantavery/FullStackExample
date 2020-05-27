using System;

namespace FullStackExample.Domain.Entities
{
    public class HelloWorldModel
    {
        public string HelloWorldString;

        public HelloWorldModel(string helloWorldString)
        {
            HelloWorldString = helloWorldString;
        }
    }
}
