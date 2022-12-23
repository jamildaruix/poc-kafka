# poc-kafka
PoC para Kafka

<p>
    <img src="https://kafka.apache.org/images/streams-and-tables-p1_p4.png" width="600" />
</p>

<p>
    <img src="https://i.stack.imgur.com/B6H90.png" width="600" />
</p>   


# AMPQ

https://www.amqp.org/
https://www.gta.ufrj.br/ensino/eel879/trabalhos_vf_2014_2/leonardo/protocols.html

## Divisão de garantia de entregas

- at-most-once
    - Onde a mensagem é entregue apenas uma vez ou nunca entregue.
- at-least-once
    - Onde uma mensagem com certeza será entregue mas, as vezes, será entregue mais de uma vez.
- exactly-once
    - Entrega garantida e somente uma vez.

# Diferença entre fila (queue) e tópico (topic)

- Fila é o middleware orientado a mensagens que retém a mensagem até que o receptor esteja pronto;
- Tópico é o middleware orientado a mensagens que é responsável por armazenar e entregar mensagens aos assinantes https://www.enterpriseintegrationpatterns.com/PublishSubscribeChannel.html


# Messging

https://kafka.apache.org/documentation/#uses_messaging

https://learn.microsoft.com/en-us/azure/architecture/patterns/category/messaging

https://microservices.io/patterns/communication-style/messaging.html

https://simplificandoredes.com/rabbitmq-1-o-que-sao-sistemas-de-mensageria/

https://www.enterpriseintegrationpatterns.com/

https://diogobemfica.com.br/categoria/mensageria

https://www.enterpriseintegrationpatterns.com/MessageBroker.html

https://www.enterpriseintegrationpatterns.com/books3.html

https://www.amazon.com/o/asin/0201325810/ref=nosim/enterpriseint-20

https://stackoverflow.com/questions/5576415/jms-topic-vs-queues

https://www.enterpriseintegrationpatterns.com/MessageBroker.html

https://www.enterpriseintegrationpatterns.com/patterns/messaging/

https://www.enterpriseintegrationpatterns.com/patterns/messaging/DeadLetterChannel.html

- Types Exchanges
    - Direct Exchange
    - Fanout Exchange
    - Topic Exchange
    - Headers Exchange

