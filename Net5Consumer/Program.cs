using System;
using NetStdAndNet5Tests;

namespace Net5Consumer
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var api = new Api();
            var hello = api.SayHello("John");

            Console.WriteLine(hello);

            var john = api.CreateJohnDoe();
            var helloJohn = api.SayHello($"{john.FirstName} {john.LastName}");
            Console.WriteLine(helloJohn);

            var jane = new Person("Jane", "Doe");
            var helloJane = api.SayHello($"{jane.FirstName} {jane.LastName}");
            Console.WriteLine(helloJane);

            Console.WriteLine($"4 + 4 = {api.Add(4.0, 4.0)}");
        }
    }
}
