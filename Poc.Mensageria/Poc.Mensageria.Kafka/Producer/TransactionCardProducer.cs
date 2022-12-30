using Confluent.Kafka;
using Poc.Mensageria.Kafka.DTO;
using Poc.Mensageria.Kafka.Topic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Mensageria.Kafka.Producer
{
    internal static class TransactionCardProducer
    {
        public static async void Execute()
        {
            TransactionPixCreditDto model = new (Guid.NewGuid(), Convert.ToDecimal(new Random().NextDouble()), $"PoC {DateTime.Now}", Convert.ToByte(new Random().Next(12)));

            var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

            using (var producerBuild = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    //var produce = await producerBuild.ProduceAsync(TopicKafka.TopicPixCredito, new Message<Null, string> { Value = model.ToString() });

                    producerBuild.Produce(TopicKafka.TopicPixCredito, new Message<Null, string> { Value = model.ToString() });
                    
                    //Console.WriteLine($"Delivered '{produce.Value}' to '{produce.TopicPartitionOffset}'");

                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }
            }

        }
    }
}
