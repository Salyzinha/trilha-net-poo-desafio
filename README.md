# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.



## Minhas Implementações

Para resolver o desafio, segui os seguintes passos:

- Adicionei as propriedades **Modelo**, **IMEI** e **Memoria** na classe abstrata `Smartphone`, conforme o diagrama proposto.
- Ajustei o construtor da classe `Smartphone` para receber e inicializar essas novas propriedades.
- Implementei as classes filhas `Nokia` e `Iphone`, herdando de `Smartphone` e sobrescrevendo o método `InstalarAplicativo` com mensagens personalizadas para cada marca.
- Realizei testes no arquivo `Program.cs`, criando instâncias das duas marcas, chamando os métodos de ligar, receber ligação e instalar aplicativos, garantindo o funcionamento correto das implementações.