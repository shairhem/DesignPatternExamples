using AdapterSample.Adapter;
using AdapterSample.Loggers;
using System;

namespace AdapterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value: ");
            var firstValue = int.Parse(Console.ReadLine());

            Console.Write("Enter second value: ");
            var secondValue = int.Parse(Console.ReadLine());

            var logger = new Logger();
            var loggerAdapter = new LoggerAdapter(new CustomLogger());
            var service = new SampleService(logger);
            service.Add(firstValue, secondValue);
        }
    }

    class SampleService
    {
        private readonly ILogger logger;

        public SampleService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Add(int firstvalue, int secondValue)
        {
            var sum = firstvalue + secondValue;
            this.logger.LogInfo($"The sum is: {sum}");
        }
    }
}
