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


# DotNet Example

https://github.com/confluentinc/confluent-kafka-dotnet

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

https://www.blogdoft.com.br/2021/03/28/rodando-o-kafka-no-meu-computador-com-docker-compose/

- Types Exchanges
    - Direct Exchange
    - Fanout Exchange
    - Topic Exchange
    - Headers Exchange

# Exemplo Docker Compose 

https://github.com/ftathiago/blogdoft-toycode/blob/feature/RunningKafkaLocally/KafkaExamples/.docker/docker-compose.yaml

https://www.blogdoft.com.br/2021/03/28/rodando-o-kafka-no-meu-computador-com-docker-compose/

https://github.com/conduktor/kafka-stack-docker-compose

https://www.conduktor.io/kafka/how-to-start-kafka-using-docker

https://medium.com/xp-inc/dica-r%C3%A1pida-gerenciando-t%C3%B3picos-do-kafka-com-o-conduktor-20b1bd557840

https://www.conduktor.io/get-started#docker

## Comando Windows 

docker run --rm `
  -p "8080:8080" --pull=always `
  --mount "type=bind,source=$pwd/platform-config.yaml,target=/opt/conduktor/default-platform-config.yaml" `
  --mount "source=conduktor_data,target=/var/conduktor" `
conduktor/conduktor-platform:latest

## Comando Linux

docker run --rm \
  -p "8080:8080" --pull=always \
  --mount "type=bind,source=$PWD/platform-config.yaml,target=/opt/conduktor/default-platform-config.yaml" \
  --mount "source=conduktor_data,target=/var/conduktor" \
conduktor/conduktor-platform:latest

## Login

http://localhost:8080

User: admin@conduktor.io
Pass: admin