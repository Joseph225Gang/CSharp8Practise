using System;
using System.Threading;

namespace OtherLanguageSample
{
    class Program
    {
        static int ThreadId => Thread.CurrentThread.ManagedThreadId;

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            IAnimalWidget.SetAmountToFeed(20);
            var dog = new DogWidget();
            var cat = new CatWidget();
            var hamster = new HamsterWidget();

            var animals = new IAnimalWidget[] { dog, cat, hamster };

            dog.Feed();

            foreach (var animal in animals)
            {
                animal.Feed();
                Console.WriteLine($"Happiness level for {animal.Name}: {animal.Happiness}");
            }

            var orderFactory = new OrderFactory();

            Console.WriteLine($"[{ThreadId}]Enumerating orders...");

            await foreach (var order in orderFactory.MakeOrdersAsync(5))
            {
                Console.WriteLine($"[{ThreadId}]Received order {order.Id}.");
            }

            Console.WriteLine($"[{ThreadId}]All orders created!");

            var demo = new StaticLocalDemo();
            demo.Run();

            using var resource = new DisposableResource();

            Console.WriteLine($"Using resource: {resource.Value}");


            Console.WriteLine("All finished!");
            Console.WriteLine("Hello World!");
        }
    }
}
