using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitMQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RabbitMQProducer producer = new RabbitMQProducer();
            RabbitMQConsumer consumer = new RabbitMQConsumer();
            int i = 0;
            consumer.StartConsumer("hello");
            var task = Task.Run(() =>
            {
                while (true)
                {
                    producer.Send($"hello{i++}", "hello");
                    Thread.Sleep(1000);
                }
            });


            //Task.WaitAll(task);
            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
