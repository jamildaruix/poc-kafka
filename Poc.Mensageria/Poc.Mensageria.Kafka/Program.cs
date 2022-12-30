// See https://aka.ms/new-console-template for more information
using Poc.Mensageria.Kafka.Producer;

Console.WriteLine("Iniciando PoC Kafka");

for (int i = 0; i < 2; i++)
{
    TransactionCardProducer.Execute();
}

Console.ReadLine();
Console.WriteLine("PoC finalizada");