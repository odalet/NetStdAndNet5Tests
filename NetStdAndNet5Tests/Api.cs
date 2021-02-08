using System.Diagnostics.CodeAnalysis;

namespace NetStdAndNet5Tests
{
    // This blog post explains how to 'enable' records when targetting frameworks older than .NET 5 and Lang Version < 9:
    // See https://blog.ndepend.com/using-c9-record-and-init-property-in-your-net-framework-4-x-net-standard-and-net-core-projects/
    // Nicely provided by nuget 'IsExternalInit': see https://github.com/manuelroemer/IsExternalInit

    // This one is similar, but for Nullable support
    // See https://www.meziantou.net/how-to-use-nullable-reference-types-in-dotnet-standard-2-0-and-dotnet-.htm
    // And also provided by the same author by nuget 'Nullable'. See https://github.com/manuelroemer/Nullable

    public class Api
    {
        [return: NotNull]
        public string SayHello(string? name) => $"Hello {name ?? ", who are you"}";

        [return: NotNull]
        public Person CreateJohnDoe() => new Person("John", "Doe");

        // Useless, but shows that code with a static local function can be consumed from 'old' Netstandard 2 code.
        public double Add(double x, double y)
        {
            static double addDoubles(double a, double b) => a + b;

            return addDoubles(x, y);
        }
    }

    public record Person(string FirstName, string LastName);
}